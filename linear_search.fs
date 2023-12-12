let rec linear_search (haystack: 'T array) needle index =
    if index < haystack.Length then
        if haystack.[index] = needle then
            Some index
        else 
            linear_search haystack needle (index + 1)
    else
        None
