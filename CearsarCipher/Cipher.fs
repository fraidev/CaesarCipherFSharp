module CearsarCipher.Cipher

let Alphabet = [ 'A' .. 'Z' ] |> Seq.toList

let AlphabetIndex input =
    Alphabet |> Seq.findIndex (fun x -> x = input)

let Modulus a b = (((a) % b + b) % b)
type TypeEncrypt =
    | Sum
    | Subtract

let Shift input shiftCount encrypt =
    let operation =
        match encrypt with
        | Sum -> (fun x -> x + shiftCount)
        | Subtract -> (fun x -> x - shiftCount)

    match input with
    | null -> ""
    | "" -> ""
    | _ -> Seq.toList ((input: string).ToUpper())
        |> Seq.map (fun letter -> Alphabet.Item(Modulus (operation (AlphabetIndex letter)) 26) |> string)
        |> Seq.reduce (+)
        |> string


let Encrypt input =
    Shift input 3 Subtract

let Decrypt input =
    Shift input 3 Sum
