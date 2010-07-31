module Problem3

let Solve =

    let largestPrimeFactor = 
        Primes.factorize 600851475143L
        |> List.max

    printfn "%d" largestPrimeFactor