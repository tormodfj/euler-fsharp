module Numerics

let reverse n =
    let rec reverse n result =
        match n with
        | 0 -> result
        | _ -> reverse (n / 10) (result * 10 + n % 10)
    reverse n 0