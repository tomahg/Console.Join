# Console.Join

`Join` is a simple console application that receives multi-line text from standard input and returns it as single-line text to standard output. Pipe in, pipe out!

Example with the file `input.txt`
```
one
two
three
```
## Without delimiter
Usage
```bash
type input.txt | join
```

Output
```
onetwothree 
```

## Specified delimiter
Usage
```bash
type input.txt | join ", "
```

Output
```
one, two, three 
```

## Trim
If the input contains leading/trailing whitespace, like this.
```
 one
         two    
  three
```

Every line will be trimmed before joining them.
```
onetwothree 
```