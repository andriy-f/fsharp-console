// For more information see https://aka.ms/fsharp-console-apps
let a = 1
let b = 2
let plus3 = fun x -> x + 3
let plus3Mul5 = fun x -> (x + 3) * 5
let mul2 = ( * ) 2
let mul2Plus3 = mul2 >> plus3

printfn "Hello from F#"
printfn "3 * 2 + 3 = %i" (mul2Plus3 3)
System.Console.WriteLine("Hello, {0}!", "World")
