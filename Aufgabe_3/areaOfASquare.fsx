open System

printfn "Enter the width of the square"
let width = float(Console.ReadLine())

printfn "Enter the height of the square"
let height = float(Console.ReadLine())

let area = width * height

printfn "The area of the square is %f" area