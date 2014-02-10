namespace ServicestackAspNetHost

open System
(*
--- Updated find out
    If I comment apphost.Init() break point will hit application start on console.writeline. But if uncomment it, it is not working. 
    So, here I am successfully creating instance of AppHost but busting it somewhere in Init.
    --- It is working now
*)
type Global() = 
    inherit System.Web.HttpApplication()
//    let apphost = new App_Start.AppHost()
    member x.Application_Start (sender:Object, e:EventArgs) = 
//        Console.WriteLine("Just to put break point");
        let apphost = new App_Start.AppHost()
        apphost.Init() |> ignore
 

