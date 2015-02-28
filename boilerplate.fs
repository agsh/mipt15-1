open System
open System.Net
open System.IO
open System.Collections.Specialized

let (email, name) = ("", "")

let values = new NameValueCollection()
values.Add("email", email)
values.Add("name", name)
values.Add("content", File.ReadAllText(__SOURCE_DIRECTORY__ + @"\" + __SOURCE_FILE__))

let client = new WebClient()
let response = client.UploadValues(new Uri("http://mipt.eu01.aws.af.cm/lab1"), values)
let responseString = Text.Encoding.Default.GetString(response)

printf "%A" responseString
