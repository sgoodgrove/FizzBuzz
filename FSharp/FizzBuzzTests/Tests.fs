
namespace FizzBuzzTests

open FizzBuzz
open FsUnit
open NUnit.Framework

[<TestFixture>]
type FizzBuzzTests () =
    let fizzer = new FizzBuzzService ()

    [<TestCase(1, "1")>]
    [<TestCase(2, "2")>]
    [<TestCase(4, "4")>]
    member this.``Should return number as string`` (n : int, str : string) =
        fizzer.FizzBuzzNum n |> should equal str

    [<TestCase(5)>]
    [<TestCase(10)>]
    [<TestCase(20)>]
    member this.``Should return Buzz`` (n) =
        fizzer.FizzBuzzNum n |> should equal "Buzz"

    [<TestCase(3)>]
    [<TestCase(6)>]
    [<TestCase(24)>]
    member this.``Should return Fizz`` (n) =
        fizzer.FizzBuzzNum n |> should equal "Fizz"

    [<TestCase(15)>]
    [<TestCase(30)>]
    [<TestCase(60)>]
    member this.``Should return FizzBuzz`` (n) =
        fizzer.FizzBuzzNum n |> should equal "FizzBuzz"