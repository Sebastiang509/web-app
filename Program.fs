open Microsoft.AspNetCore.Builder
open Microsoft.Extensions.DependencyInjection
open Giraffe
open TodoWeatherApp.Routes

let builder = WebApplication.CreateBuilder()
builder.Services.AddGiraffe()

let app = builder.Build()
app.UseGiraffe(routes)
app.Run()
