module Problem25

open System.Numerics

let Solve = 

    let limit = BigInteger.Pow(BigInteger 10, 999)

    let fibonacci =
        Seq.unfold
            (fun (current, next) -> Some(current, (next, current + next)))
            (BigInteger 0, BigInteger 1)

    let term =
        fibonacci
        |> Seq.takeWhile (fun n -> n < limit)
        |> Seq.length

    printfn "%d" term