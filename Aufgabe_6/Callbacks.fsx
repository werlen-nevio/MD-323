open System

printfn "Enter a Number: "

let number = int(Console.ReadLine())

printfn "Enter a second Number: "

let secondNumber = int(Console.ReadLine())
let addWithCallback x y callback =
    let result = x + y
    callback result

let printResult result =
    printfn "Das Ergebnis ist: %d" result

addWithCallback number secondNumber printResult

let doubleResult result =
    printfn "Das verdoppelte Ergebnis ist: %d" (result * 2)

addWithCallback number secondNumber doubleResult
