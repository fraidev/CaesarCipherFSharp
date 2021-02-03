open CearsarCipher

[<EntryPoint>]
let main argv =
    printf "%s \n" (Cipher.Encrypt "ABC")
    printf "%s \n" (Cipher.Encrypt "a")
    printf "%s \n" (Cipher.Encrypt "")
    printf "%s" (Cipher.Encrypt null)
    0 // return an integer exit code