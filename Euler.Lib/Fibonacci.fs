module Fibonacci

let fibonacciSeq =
    Seq.unfold
        (fun (current, next) -> Some(current, (next, current + next)))
        (0, 1)