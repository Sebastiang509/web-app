namespace TodoWeatherApp.Routes

open Giraffe
open TodoWeatherApp.Services

let indexHandler (next: HttpFunc) (ctx: HttpContext) =
    task {
        return! text "Welcome to TodoWeatherApp!" next ctx
    }

let routes =
    choose [
        route "/" >=> indexHandler
        route "/todos" >=> todoHandler
        route "/weather" >=> weatherHandler
        route "/image" >=> imageHandler
        route "/send-email" >=> sendEmailHandler
    ]
