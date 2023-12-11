let rec binary_search (haystack: 'T array) needle high low =
    if high >= low then
        let mid = low + (high - low) / 2

        if haystack.[mid] = needle then
            Some mid
        else if haystack.[mid] > needle then
            binary_search haystack needle (mid - 1) low
        else
            binary_search haystack needle high (mid + 1)
    else
        None
        
[<EntryPoint>]
let main arg =
    let haystack = [| 3; 5; 10; 15; 16; 17; 19; 33; 34; 35 |]
    let needle = 34

    match binary_search haystack needle haystack.Length 0 with 
    | Some(result) -> printfn "Needle found at: %d" result
    | None -> printfn "Needle Not Found"
    0
