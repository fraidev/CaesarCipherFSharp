open CearsarCipher

[<EntryPoint>]
let main argv =
    printf "%s \n" (Cipher.Encrypt "DEF")
    printf "%s" (Cipher.Encrypt "ABC")
    0 // return an integer exit code