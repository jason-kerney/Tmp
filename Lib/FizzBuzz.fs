module FizzBuzz.Lib.FizzBuzzer

let convert = function
    | value when value % 5 = 0 -> "Buzz"
    | value when value % 3 = 0 -> "Fizz"
    | value -> $"%d{value}"