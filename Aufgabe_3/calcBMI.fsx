open System

printfn "Enter your weight in kg"
let weight = float(Console.ReadLine())

printfn "Enter your height in meters"
let height = float(Console.ReadLine())

let calcBMI weight height =
    weight / (height * height)

let bmi = calcBMI weight height

printfn "Your BMI is %f" bmi