let numbers = [1; 2; 3; 4; 5]

let rec product lst =
    match lst with
    | [] -> 1
    | head :: tail -> head * product tail

printfn "The product of the list is %d" (product numbers)

let rec maximum lst =
    match lst with
    | [] -> failwith "The list is empty"
    | [x] -> x
    | head :: tail -> 
        let maxTail = maximum tail
        if head > maxTail then head else maxTail

printfn "The maximum of the list is %d" (maximum numbers)

let rec contains x lst =
    match lst with
    | [] -> false
    | head :: tail -> 
        if head = x then true
        else contains x tail

printfn "The list contains 3: %b" (contains 3 numbers)
printfn "The list contains 33: %b" (contains 33 numbers)