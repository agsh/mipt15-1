#r "../packages/FSharp.Data.2.2.0/lib/net40/FSharp.Data.dll"
open FSharp.Data
open System.IO
open System.Net
open System.Text

let main () =
  let bases = HtmlDocument.Load("http://mipt.ru/diht/bases/")
  bases.Descendants ["ul"] 
    |> Seq.filter (fun x -> x.HasClass("right-menu")) 
    |> Seq.collect (fun (x:HtmlNode) -> x.Descendants ["a"])
    |> Seq.map(fun x -> x.InnerText())
    |> Seq.toList
