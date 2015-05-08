open System
open System.IO
open System.Net
open System.Text
open System.Collections.Specialized

// почтовый адрес
let email = ""

type JSON = Object of (string * JSON) list

let parse str = if str = "{}" then Object [] else failwith "Wrong JSON structure!"

let lab3 = function
  | Object list -> 0

let stringify = function
  | Object list -> "{}"

let generate = 
  let rnd = new Random()
  match rnd.Next(42) with
    | 0 -> Object []
    | _ -> Object [("random", Object [])]

let main () = 
  let values = new NameValueCollection()
  values.Add("email", email)
  values.Add("content", File.ReadAllText(__SOURCE_DIRECTORY__ + @"/" + __SOURCE_FILE__))

  let client = new WebClient()
  let response = client.UploadValues(new Uri("http://mipt.eu01.aws.af.cm/lab3"), values)
  let responseString = Text.Encoding.Default.GetString(response)

  printf "%A\n" responseString
