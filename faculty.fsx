open System

printfn "Enter a Number you want to get the faculty of: "
let Number = int(Console.ReadLine())

let rec faculty n =
    if n = 0 || n = 1 then n
    else n * faculty (n - 1)

let result = faculty Number
printfn "The faculty of %d is %d" Number result

// =======================================
//   The same function without recursion
// =======================================

let facultyNoRec n =
    let mutable result = 1
    for i in 1..n do
        result <- result * i
    result

let resultNoRec = facultyNoRec Number
printfn "The faculty of %d is %d" Number resultNoRec