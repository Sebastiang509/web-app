namespace TodoWeatherApp.Services

open System
open System.Threading
open System.Threading.Tasks

module Scheduler =
    let startScheduler () =
        let sendTime = "06:00:00"
        while true do
            let currentTime = DateTime.UtcNow.ToString("HH:mm:ss")
            if currentTime = sendTime then
                let subject = "Daily Todo, Weather, and Image Report"
                let body = "Your todos, weather data, and image for the day."
                task {
                    do! EmailService.sendEmail subject body
                } |> ignore
            Thread.Sleep(60000) // Check every minute
