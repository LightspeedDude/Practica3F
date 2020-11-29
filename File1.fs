module File1

let word = "..- .-.. - .. -- .- / .--. .-. ..- . -.. .-"

let morse =
    Map.empty.
        Add(".-", 'a').
        Add("-...", 'b').
        Add("-.-.", 'c').
        Add("-..", 'd').
        Add(".", 'e').
        Add("..-.", 'f').
        Add("--.", 'g').
        Add("....", 'h').
        Add("..", 'i').
        Add(".---", 'j').
        Add("-.-", 'k').
        Add(".-..", 'l').
        Add("--", 'm').
        Add("-.", 'n').
        Add("---", 'o').
        Add(".--.", 'p').
        Add("--.-", 'q').
        Add(".-.", 'r').
        Add("...", 's').
        Add("-", 't').
        Add("..-", 'u').
        Add("...-", 'v').
        Add(".--", 'w').
        Add("-..-", 'x').
        Add("-.--", 'y').
        Add("--..", 'z').
        Add("/", ' ');;
let Code (word : string) =
    let words = word.Split '/'
    let list1 = []
    for w in words do
        let chars = w.Split ' '
        for i in chars do
            if i <> "" then
                let list2 = morse.[i] :: list1
                list2 |> List.toArray |> System.String |> printf "%s"
        if chars.Length <> 0 then printf " "