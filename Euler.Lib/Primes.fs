module Primes

let isPrime n =
    let rec check i =
        i > (n / 2) || (n % i <> 0 && check (i + 1))
    check 2

let factorize n =
    let rec factorize n j factors =
        match n with
        | 1L -> factors
        | x when (n % j) = 0L -> factorize (n/j) j (j::factors)
        | x -> factorize n (j + 1L) (factors)
    factorize n 2L []