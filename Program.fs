
open System.Text
open System
open System.IO
open System.Net
open System.Runtime.InteropServices




let url = "https://s3-sa-east-1.amazonaws.com/pontotel-docs/data.json"

let req = HttpWebRequest.Create(url) :?> HttpWebRequest 
//req.ProtocolVersion <- HttpVersion.Version10
req.Method <- "GET"

let resposta = req.GetResponse()
let dados = resposta.GetResponseStream()
let resp = new StreamReader(dados)
let html =  resp.ReadToEnd()
printfn " %s"  html
printfn "Pressione a tecla enter" 

let n1 = Console.ReadLine()




