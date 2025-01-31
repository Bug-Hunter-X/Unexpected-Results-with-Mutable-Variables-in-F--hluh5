let mutable x = 10
let mutable y = 20

let add x y = x + y

let z = add x y // calculate z initially
printf "%A\n" z // print initial value of z

x <- 15
y <- 25

let z = add x y // recalculate z with updated values of x and y
printf "%A\n" z // print updated value of z