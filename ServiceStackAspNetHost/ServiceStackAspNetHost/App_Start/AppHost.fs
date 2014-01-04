namespace ServiceStackAspNetHost.App_Start
    open ServiceStack
    open ServiceStack.Common
    open ServiceStack.WebHost.Endpoints
    open ServiceStackAspNetHost
    open System

    //[<assembly: WebActivator.PreApplicationStartMethod(typeof<ServiceStackAspNetHost.App_Start.AppHost>, "Start")>]
    
    
    type AppHost() = 
        inherit AppHostHttpListenerBase("Hello F# Service", 
                                        typeof<HelloService>.Assembly)
        override this.Configure container = 
            ignore()

        static member start() = 
            let apphost = new AppHost()
            apphost.Init() 
            
            

