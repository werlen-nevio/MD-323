let applyFunctionToList func list =
    List.map func list

let identity x = x

let square x = x * x

let numbers = [1; 2; 3; 4; 5]

let identityResult = applyFunctionToList identity numbers
printfn "Identitätsfunktion: %A" identityResult

let squareResult = applyFunctionToList square numbers
printfn "Quadratfunktion: %A" squareResult
