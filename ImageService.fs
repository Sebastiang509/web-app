namespace TodoWeatherApp.Services

open System.Net.Http
open System.Threading.Tasks

module ImageService =
    let getRandomImage () =
        task {
            let apiKey = "your-unsplash-api-key"
            let url = sprintf "https://api.unsplash.com/photos/random?client_id=%s" apiKey
            use client = new HttpClient()
            let! response = client.GetStringAsync(url)
            return response
        }
