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
        
