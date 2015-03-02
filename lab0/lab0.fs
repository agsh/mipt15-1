module lab0

open System
open System.Net
open System.Collections.Specialized

let (email, name) = ("", "") // адрес почты и фамилия с инициалами

let pascal a b = 1 // а тут решение

let printIt n = 
  "[" +
  ([for x in 0..n do yield! List.map (fun y -> pascal y x) [0..x]] 
    |> List.map (fun x -> x.ToString())
    |> List.reduce (fun x y -> x + "," + y) )
  + "]"

let main () = 
  let values = new NameValueCollection()
  values.Add("email", email)
  values.Add("name", name)
  values.Add("lang", "fsharp")
  values.Add("content", printIt 20)

  let client = new WebClient()
  let response = client.UploadValues(new Uri("http://mipt.eu01.aws.af.cm/lab0"), values)
  let responseString = Text.Encoding.Default.GetString(response)

  printf "%A\n" responseString
