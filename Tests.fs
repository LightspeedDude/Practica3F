module Tests

open System
open Xunit
open File1

[<Fact>]
let ``Tercera Prueba de Codigo Morse`` () =
    let expected = printf "ultima prueda"
    let actual = Code "..- .-.. - .. -- .- / .--. .-. ..- . -.. .-"
    Assert.Equal(expected, actual)
