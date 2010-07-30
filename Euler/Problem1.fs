module Problem1

let Solve =
    
    let divisibleByThreeOrFive x =
        (x % 3) = 0 || (x % 5) = 0

    let sum =
        [1..999]
        |> List.filter divisibleByThreeOrFive
        |> List.sum

    printfn "%d" sum