module Fibonacci

open System.Numerics

let fibonacciSeq =
    Seq.unfold
        (fun (current, next) -> Some(current, (next, current + next)))
        (0, 1)

let fibonacciSeqOfBigInts =
    Seq.unfold
        (fun (current, next) -> Some(current, (next, current + next)))
        (BigInteger 0, BigInteger 1)
