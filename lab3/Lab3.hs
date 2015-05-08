{-# LANGUAGE OverloadedStrings #-}

import System.IO
import System.Environment
import System.Directory
import System.Random
import Control.Monad
import Control.Monad.State
import Network.HTTP.Conduit
import qualified Data.ByteString.Lazy.Char8 as L
import Data.Text.Encoding
import qualified Data.Text as T
import Network (withSocketsDo)

-- почтовый адрес
email = ""

newtype JSON = Object [(String, JSON)]

-- добавим сответствующие классы типов для JSON
instance Show JSON where
  show = stringify
instance Read JSON where
  readsPrec _ x = parse x

parse :: ReadS (JSON)
parse "{}" = [(Object [], "")]

lab3 (Object list) = 0

stringify (Object list) = "{}"

-- вариант с монадой IO
generateIO :: IO JSON
generateIO = do
  num <- randomRIO (1, 2) :: IO Int
  let json = case num of
               1 -> Object [];
               2 -> Object [("io", Object [])]
  return json

-- чистый вариант с генератором, заключённым в состояние
-- мы храним в состоянии генератор, каждый раз используя
-- его, возвращаем в состояние новый

type GeneratorState = State StdGen

generate' :: GeneratorState JSON
generate' = do
  gen <- get
  let (num, newGen) = randomR (1, 2) gen :: (Int, StdGen)
  let json = case num of
               1 -> Object [];
               2 -> Object [("pure", Object [])]
  put newGen
  return json

generate :: JSON
generate = evalState generate' (mkStdGen 0)

main :: IO()
main = withSocketsDo $ do
  dir <- getCurrentDirectory
  initReq <- parseUrl "http://mipt.eu01.aws.af.cm/lab3"
  handle <- openFile (dir ++ "/Lab3.hs") ReadMode
  hSetEncoding handle utf8_bom
  content <- hGetContents handle
  let req = urlEncodedBody [("email", email), ("content", encodeUtf8 $ T.pack content) ] $ initReq { method = "POST" }
  response <- withManager $ httpLbs req
  hClose handle
  L.putStrLn $ responseBody response
