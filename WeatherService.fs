namespace TodoWeatherApp.Services

open System.Net.Http
open System.Threading.Tasks
open System.Text.Json

module WeatherService =
    let getWeather () =
        task {
            let url = "https://api.open-meteo.com/v1/forecast?latitude=37.69&longitude=-97.14&current_weather=true"
            use client = new HttpClient()
            let! response = client.GetStringAsync(url)
            return response
        }
