{-# LANGUAGE OverloadedStrings #-}

import Control.Monad
import Network.HTTP.Conduit
import Data.Text.Encoding
import qualified Data.ByteString.Lazy as L
import qualified Data.ByteString.Char8 as C

(email, name) = ("", encodeUtf8 "") -- адрес почты и фамилия с инициалами

pascal _ _ = 1 // а тут решение

printIt n = C.pack $ show $ [0..n] >>= (\x -> map (\y -> pascal y x) [0..x])

main = do
  initReq <- parseUrl "http://mipt.eu01.aws.af.cm/lab0"
  let req = urlEncodedBody [("email", email), ("name", name), ("lang", "haskell"), ("content", printIt 20)] $ initReq { method = "POST" }
  response <- withManager $ httpLbs req
  L.putStr $ responseBody response
