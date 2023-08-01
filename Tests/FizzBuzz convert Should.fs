module FizzBuzz.Tests.``FizzBuzzer convert Should``

open Archer
open Archer.Arrows
open FizzBuzz.Lib

let private feature = Arrow.NewFeature ()

let ``convert 1 to "1"`` =
    feature.Test (fun _ ->
        1
        |> FizzBuzzer.convert
        |> Should.BeEqualTo "1"
    )
    
let ``convert 2 to "2"`` =
    feature.Test (fun _ ->
        2
        |> FizzBuzzer.convert
        |> Should.BeEqualTo "2"
    )
    
let ``convert 3 to "Fizz"`` =
    feature.Test (fun _ ->
        3
        |> FizzBuzzer.convert
        |> Should.BeEqualTo "Fizz"
    )
    
let ``convert 6 to "Fizz"`` =
    feature.Test (fun _ ->
        6
        |> FizzBuzzer.convert
        |> Should.BeEqualTo "Fizz"
    )
    
let ``convert 5 to "Buzz"`` =
    feature.Test (fun _ ->
        5
        |> FizzBuzzer.convert
        |> Should.BeEqualTo "Buzz"
    )
    
let ``convert 10 to "Buzz"`` =
    feature.Test (fun _ ->
        10
        |> FizzBuzzer.convert
        |> Should.BeEqualTo "Buzz"
    )
    
let ``convert 15 to "FizzBuzz"`` =
    feature.Test (fun _ ->
        15
        |> FizzBuzzer.convert
        |> Should.BeEqualTo "FizzBuzz"
    )
    
let ``convert 30 to "FizzBuzz`` =
    feature.Ignore (fun _ ->
        30
        |> FizzBuzzer.convert
        |> Should.BeEqualTo "FizzBuzz"
    )
    
    
// Not yet picked up by the dotnet command, but its coming
let ``convert all numbers 1 to 100`` =
    feature.Test (
        Data (seq {
            for n in 1..100 do
                let expected =
                    if n % 15 = 0 then "FizzBuzz"
                    elif n % 5 = 0 then "Buzz"
                    elif n % 3 = 0 then "Fizz"
                    else $"{n}"
                    
                yield n, expected
        }),
        TestBody (fun (value, result) ->
            value
            |> FizzBuzzer.convert
            |> Should.BeEqualTo result
        )
    )