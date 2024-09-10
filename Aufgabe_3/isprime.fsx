open System

printfn "Enter the Number to check if it is prime or not"
let Number = int(Console.ReadLine())

let isPrime n =
    let rec check i =
        match n with
        | _ when n <= 1 -> false
        | _ when i * i > n -> true
        | _ when n % i = 0 -> false
        | _ -> check (i + 1)
    check 2

printfn "%A" (isPrime Number)