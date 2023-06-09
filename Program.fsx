﻿// For more information see https://aka.ms/fsharp-console-apps
// fsharp tutorial is through microsoft https://learn.microsoft.com/en-us/dotnet/fsharp/get-started/get-started-vscode

let toPigLatin (word: string) =
    let isVowel (c: char) =
        match c with
        | 'a' | 'e' | 'i' |'o' |'u'
        | 'A' | 'E' | 'I' | 'O' | 'U' -> true
        |_ -> false
    
    if isVowel word[0] then
        word + "yay"
    else
        word[1..] + string(word[0]) + "ay"
