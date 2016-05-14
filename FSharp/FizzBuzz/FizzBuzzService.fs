namespace FizzBuzz

type public FizzBuzzService () =
    member public this.FizzBuzzNum n =
        let div3 = n % 3 = 0
        let div5 = n % 5 = 0

        match n with
            | _ when div3 && div5 -> "FizzBuzz"
            | _ when div3 -> "Fizz"
            | _ when div5 -> "Buzz"
            | x -> x.ToString ()
