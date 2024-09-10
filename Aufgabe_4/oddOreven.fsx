open System

printfn "Enter a Number: "
let number = int(Console.ReadLine())

// ================================================
//   Function to check if a number is even or odd
// ================================================

let even n = n % 2 = 0
let odd n = n % 2 <> 0

// ==========================================================
//   Recursive function to check if a number is even or odd
// ==========================================================

let rec evenRec n =
    if n = 0 then true
    elif n = 1 then false
    else evenRec (n - 2)

let rec oddRec n =
    if n = 0 then false
    elif n = 1 then true
    else oddRec (n - 2)


printfn "Is the number even? %b" (even number)
printfn "Is the number even (recursive)? %b" (evenRec number)
printfn "Is the number odd? %b" (odd number)
printfn "Is the number odd (recursive)? %b" (oddRec number)