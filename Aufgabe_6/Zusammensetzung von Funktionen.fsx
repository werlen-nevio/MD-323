// Funktion, die eine Zahl verdoppelt
let double x = x * 2

// Funktion, die eine Zahl um 5 erhöht
let addFive x = x + 5

// Komponieren der beiden Funktionen mit dem Operator >>
let composedFunction = double >> addFive

// Testen der zusammengesetzten Funktion
printfn "Zusammengesetztes Ergebnis: %d" (composedFunction 3)  // 3 * 2 + 5 = 11
printfn "Zusammengesetztes Ergebnis: %d" (composedFunction 10) // 10 * 2 + 5 = 25
