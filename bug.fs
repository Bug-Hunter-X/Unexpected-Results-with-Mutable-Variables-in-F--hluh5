let mutable x = 10
let mutable y = 20

let add x y = 
    x + y

let mutable z = add x y

printf "%d\n" z

//This code will compile and run without errors but will not give the expected result if the user expects that  z will always be updated whenever x or y is changed. This is because z is only calculated once when the add function is called.  If x or y is changed later, z will not be updated automatically.

//To fix this, we should use a function that recalculates z whenever x or y is changed:
let add x y = x + y

let z = add x y

printf "%d\n" z

x <- 15
y <- 25

let z = add x y

printf "%d\n" z