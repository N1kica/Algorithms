use std::fs;

fn evaluate(c: &char) -> i32 {
    match c {
        '(' => 1,
        _ => -1,
    }
}

fn main() {
    let file = fs::read_to_string("input.txt").expect("Something went wrong reading the file");

    let result: i32 = file.chars().fold(0, |acc, c| {
        acc + evaluate(&c)
    });

    println!("Result: {}", result);
}

// fn print_string(s: &str) {
//     println!("{}", s.to_owned() + "asd");
// }

// fn main() {
//     let my_string = "MAZDA"; // This is &'static str (string literal)
//     print_string(&my_string); // `&` creates a `&str` reference

//     println!("{}", my_string);
// }

// let contents: Vec<Vec<char>>  = fs::read_to_string("input.txt")
//     .expect("Should have been able to read the file")
//     .lines()
//     .map(|line| line.chars().collect())
//     .collect();

// println!("{:?}", contents);
