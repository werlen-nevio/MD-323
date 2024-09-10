open System

printfn "Enter a Number: "

let number = int(Console.ReadLine())

let createCounter initialValue =
    let mutable count = initialValue
    (fun () ->
        count <- count + 1
        count)

let counter = createCounter number

// Aufrufen des Counters
printfn "Counter 1: %d" (counter())
printfn "Counter 2: %d" (counter())
