module FibonacciTest

open NUnit.Framework

[<SetUp>]
let Setup () =
    ()

[<Test>]
let Canary () =
    Assert.Pass()

let TestSetForFibonacci fibonacci = 
    let TestCases =  [| 
        (0, [1])
        (1, [1; 1])
        (2, [1; 1; 2;])
        (3, [1; 1; 2; 3])
        (4, [1; 1; 2; 3; 5])
        (5, [1; 1; 2; 3; 5; 8])
        (6, [1; 1; 2; 3; 5; 8; 13])
        (7, [1; 1; 2; 3; 5; 8; 13; 21])
        (8, [1; 1; 2; 3; 5; 8; 13; 21; 34])
        (9, [1; 1; 2; 3; 5; 8; 13; 21; 34; 55])
        (10, [1; 1; 2; 3; 5; 8; 13; 21; 34; 55; 89])
        |]
    for (input, expected) in TestCases do
        let actual = fibonacci input
        Assert.AreEqual(expected, actual)

[<Test>]
let FibonacciIterativeTest () =
    TestSetForFibonacci Fibonacci.FibonacciIterative

[<Test>]
let FibonacciRecursiveTest () =
    TestSetForFibonacci Fibonacci.FibonacciRecursive

[<Test>]
let FibonacciTailRecursiveTest () =
    TestSetForFibonacci Fibonacci.FibonacciTailRecursive

 