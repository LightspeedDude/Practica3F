module Tests

open Xunit
open File1
open System

[<Fact>]
    let ``Segunda Prueba de Codigo Morse`` () =
        let expected = printf "profesor julio pereyra"
        let actual = Codemorse ".--. .-. --- ..-. . ... --- .-. / .--- ..- .-.. .. --- / .--. . .-. . -.-- .-. .-"
        Assert.Equal(expected, actual)
