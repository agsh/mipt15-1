{-# LANGUAGE OverloadedStrings #-}

import Network.HTTP.Conduit (simpleHttp)
import qualified Data.Text as T
import Text.HTML.DOM (parseLBS)
import Text.XML.Cursor (Cursor, attributeIs, content, element, fromDocument, child, ($//), (&|), (&//), (&/), (>=>)) 
import Network (withSocketsDo)

cursorFor :: String -> IO Cursor
cursorFor u = do
     page <- withSocketsDo $ simpleHttp u
     return $ fromDocument $ parseLBS page

main :: IO()
main = do
  cursor <- cursorFor "http://mipt.ru/diht/bases/"
  let infoNodes = cursor $// element "ul" >=> attributeIs "class" "right-menu" &// element "a" >=> child &| T.concat . content
  mapM_ putStrLn $ map T.unpack infoNodes
