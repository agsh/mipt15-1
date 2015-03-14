module lab1

open System
open System.Net
open System.IO
open System.Collections.Specialized

// почтовый адрес
let email = ""
// общий тип для возвращаемых вашими функциями значений, где первая часть кортежа это само значение функции, вторая - кол-во операций
type Result = float * int
let delta = 1e-10

// *** Первая часть

let fTailor x : float = x // функция, которую раскладываем
let n, a, b = 20., -1., 1. // интервал

let tailor x : Result = (x, 0) 
let tailorA x : Result = (x, 0)

let printTailor () = 
    [a .. (b-a)/n .. b] 
    |> List.map (fun x -> let (firstRes, firstCou), (secondRes, secondCou) = tailor x, tailorA x in (x, firstRes, firstCou, secondRes, secondCou, fTailor x))
    |> List.iter (fun (a,b,c,d,e,f) -> printf "%f\t%f\t%d\t%f\t%d\t%f\n" a b c d e f )

// *** Вторая часть

let fSolve = fun x -> x // функция, решение которой ищем

let iter f a b : Result = (42., 0)
let newton f a b : Result = (42., 0)
let dichotomy =
    // для функций с аккумулятором удобно ставить его в начало
    let rec dichotomyA i (f:float->float) (a:float) (b:float) : Result = (42., 0) 
    dichotomyA 0 // чтобы воспользоваться каррированием

let printSolve () =
    [iter; newton; dichotomy] 
    |> List.map (fun f -> f fSolve a b) 
    |> List.iter (fun (res, cou) -> printf "%f\t%d\n" res cou)

let main () = 
  let values = new NameValueCollection()
  values.Add("email", email)
  values.Add("content", File.ReadAllText(__SOURCE_DIRECTORY__ + @"/" + __SOURCE_FILE__))

  let client = new WebClient()
  let response = client.UploadValues(new Uri("http://mipt.eu01.aws.af.cm/lab1"), values)
  let responseString = Text.Encoding.Default.GetString(response)

  printf "%A\n" responseString
