let mutable x = 10
let mutable y = 20
let z = x + y
printf "%d\n" z
x <- 30
printf "%d\n" x
// y is not updated here
printf "%d\n" y