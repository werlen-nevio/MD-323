open System

printfn "Enter a Number: "
let number = int(Console.ReadLine())

let rec digitsum n =
    if n = 0 then 0
    else (n % 10) + digitsum (n / 10)

printfn "The digit sum of %d is %d" number (digitsum number)