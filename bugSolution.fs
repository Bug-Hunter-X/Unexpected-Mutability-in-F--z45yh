let x = ref 10
let y = ref 20
let z = !x + !y
printf "%d\n" z
x := 30
printf "%d\n" !x
printf "%d\n" !y