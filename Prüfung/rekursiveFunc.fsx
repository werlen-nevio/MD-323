let rec getPotenz(x:int, n:int) =
    if n = 0 then 1
    else x * getPotenz(x, (n-1))

let result = getPotenz(3, 3)

printfn "%d" result