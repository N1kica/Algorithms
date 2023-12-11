let rec linear_search (haystack: 'T array) needle index =
    if index < haystack.Length then
        if haystack.[index] = needle then
            Some index
        else 
            linear_search haystack needle (index + 1)
    else
        None

[<EntryPoint>]
let main arg =
    let haystack = [| 5; 3; 15; 10; 16; 19; 17; 33; 35; 34 |]
    let needle = 34

    match linear_search haystack needle 0 with 
    | Some(result) -> printfn "Needle found at: %d" result
    | None -> printfn "Needle Not Found"
    0
