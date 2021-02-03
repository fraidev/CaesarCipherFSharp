module CearsarCipher.Test

open FsUnit
open NUnit.Framework

[<SetUp>]
let Setup () =
    ()

[<Test>]
let CipherMustEncrypt () =
    (Cipher.Encrypt "DEF") |> should equal "ABC"
    (Cipher.Encrypt "ABC") |> should equal "XYZ"

[<Test>]
let CipherMustDecrypt () =
    (Cipher.Decrypt "ABC") |> should equal "DEF"
    (Cipher.Decrypt "XYZ") |> should equal "ABC"