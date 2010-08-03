module Problem25

open System.Numerics
open Fibonacci

let Solve = 

    let limit = BigInteger.Pow(BigInteger 10, 999)

    let term =
        fibonacciSeqOfBigInts
        |> Seq.takeWhile (fun n -> n < limit)
        |> Seq.length

    printfn "%d" term