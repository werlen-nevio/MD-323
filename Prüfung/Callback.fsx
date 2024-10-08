let addNumberswCallback (a: int, b: int, callback: int -> unit) =
    callback (a + b)

let callBackFunc (x: int) =
    printfn "%d" x

addNumberswCallback (1, 2, callBackFunc)