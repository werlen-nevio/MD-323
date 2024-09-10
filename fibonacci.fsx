open System

printfn "Enter a Number you want to get the fibonacci of: "
let Number = int(Console.ReadLine())

let rec fibonacci n =
    if n = 0 || n = 1 then n
    else fibonacci (n - 1) + fibonacci (n - 2)

let result = fibonacci Number

printfn "The fibonacci of %d is %d" Number result