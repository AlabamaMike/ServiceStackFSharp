namespace ServicestackAspNetHost.App_Start
    open ServiceStack
    open ServiceStack.Common
    open ServicestackAspNetHost
    open System

    //[<assembly: WebActivator.PreApplicationStartMethod(typeof<ServicestackAspNetHost.App_Start.AppHost>, "Start")>]
    
    
    type AppHost() = 
        inherit AppHostBase("Hello F# Service", 
                                        typeof<HelloService>.Assembly)
        override this.Configure container = 
            ignore()

//        static member start() = 
//            let apphost = new AppHost()
//            apphost.Init() 
            
            

