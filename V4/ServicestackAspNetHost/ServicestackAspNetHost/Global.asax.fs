namespace ServicestackAspNetHost

open System

type Global() = 
    inherit System.Web.HttpApplication()
    let apphost = new App_Start.AppHost()
    member x.Application_Start (sender:Object, e:EventArgs) = 
        apphost.Init() 
 

