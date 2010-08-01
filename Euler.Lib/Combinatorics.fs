module Combinatorics

let cartesianProduct a b =
    seq {
        for x in a do
            for y in b do
                yield (x,y)
        }