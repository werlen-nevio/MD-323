open System

let calculateVisitors (price: float) =
    let basePrice = 8.0
    let baseVisitors = 120
    let additionalVisitors = 15
    let priceDifference = basePrice - price
    baseVisitors + (int (priceDifference / 0.50) * additionalVisitors)

let calculateProfit (price: float) =
    let fixedCosts = 250.0
    let variableCostPerVisitor = 0.75
    let visitors = calculateVisitors price
    let revenue = float visitors * price
    let totalVariableCosts = float visitors * variableCostPerVisitor
    let totalCosts = fixedCosts + totalVariableCosts
    revenue - totalCosts

printf "Enter your Ticket Price: "
let price = float(Console.ReadLine())

let profit = calculateProfit price

printfn "The Profit at a ticket price of CHF %.2f is CHF %.2f" price profit
