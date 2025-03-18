namespace TodoWeatherApp.Services

open System.Collections.Generic

module TodoService =
    let todos = new List<string>()

    let getTodos () = todos
    let addTodo (task: string) = todos.Add(task)
    let removeTodo (task: string) = todos.Remove(task)
