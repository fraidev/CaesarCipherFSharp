module CearsarCipher.Cipher

let Alphabet = [ 'A' .. 'Z' ] |> Seq.toList

let AlphabetIndex input =
    Alphabet |> Seq.findIndex (fun x -> x = input)

let Modulus a b = (((a) % b + b) % b)

let shift = 3

let Encrypt input =
    Seq.toList (input: string)
    |> Seq.map (fun letter -> Alphabet.Item(Modulus ((AlphabetIndex letter) - shift) 26) |> string)
    |> Seq.reduce (+)
    |> string

let Decrypt input =
    Seq.toList (input: string)
    |> Seq.map (fun letter -> Alphabet.Item(Modulus ((AlphabetIndex letter) + shift) 26) |> string)
    |> Seq.reduce (+)
    |> string 