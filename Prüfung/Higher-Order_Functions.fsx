// Siehe v2 Functions


// OLD FUNCTIONSE
let rec increaseMultipleTimes(x,n) =
    if n = 0
    then x
    else 1 + increaseMultipleTimes(x, n-1)

let rec decreaseMultipleTimes(x,n) =
    if n = 0
    then x
    else decreaseMultipleTimes(x, n-1) - 1

let rec doubleMultipleTimes(x,n) =
    if n = 0
    then x
    else 2 * doubleMultipleTimes(x, n-1)

let rec appendWhitespaceMultipleTimes(x,n) =
    if n = 0
    then x
    else appendWhitespaceMultipleTimes(x, n-1) + " "

let a = increaseMultipleTimes(2,5)
let b = decreaseMultipleTimes(7,3)
let c = doubleMultipleTimes(4,3)
let d = appendWhitespaceMultipleTimes("Hello World",3)
printfn "%s" d



// NEW FUNCTIONS

let increaseMultipleTimesv2(x,n) =
    let mutable v = x
    
    for i in 1..n do
        v <- v + 1

    v

let decreaseMultipleTimesv2(x,n) =
    let mutable v = x
    
    for i in 1..n do
        v <- v - 1

    v

let doubleMultipleTimesv2(x,n) =
    let mutable v = x
    
    for i in 1..n do
        v <- v * 2

    v

let appendWhitespaceMultipleTimesv2(x,n) =
    let mutable v = x
    for i in 1..n do
        v <- v + " " + x

    v

let a2 = increaseMultipleTimesv2(2,5)
let b2 = decreaseMultipleTimesv2(7,3)
let c2 = doubleMultipleTimesv2(4,3)
let d2 = appendWhitespaceMultipleTimesv2("Hello World",3)