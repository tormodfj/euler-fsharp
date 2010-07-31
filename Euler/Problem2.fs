module Problem2

let Solve =
    
    let isEven x =
        (x % 2) = 0

    let sum =
        Fibonacci.fibonacciSeq
        |> Seq.takeWhile (fun n -> n < 4000000)
        |> Seq.filter isEven
        |> Seq.sum

    printfn "%d" sum