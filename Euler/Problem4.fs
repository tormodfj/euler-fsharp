module Problem4

open Combinatorics
open Numerics

let Solve =

    let input = cartesianProduct [100..999] [100..999]

    let largestPalindrome = 
        input
        |> Seq.map (fun (a, b) -> a * b)
        |> Seq.filter (fun n -> n = reverse n)
        |> Seq.max

    printfn "%d" largestPalindrome;