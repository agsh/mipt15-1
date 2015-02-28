{-# LANGUAGE OverloadedStrings #-}
 
import System.IO
import System.Environment  
import System.Directory
import Control.Monad
import Network.HTTP.Conduit
import qualified Data.ByteString.Lazy as L
import qualified Data.ByteString.Char8 as C
 
(email, name) = ("", "")
 
main = do
  args <- getArgs
  mapM_ putStrLn args
  dir <- getCurrentDirectory
  putStrLn dir
  initReq <- parseUrl "http://mipt.eu01.aws.af.cm/lab1"
  handle <- openFile (dir ++ "/boilerplate.hs") ReadMode
  content <- hGetContents handle
  let req = urlEncodedBody [("email", email), ("name", name), ("content", C.pack content)] $ initReq { method = "POST" }
  response <- withManager $ httpLbs req
  L.putStr $ responseBody response
