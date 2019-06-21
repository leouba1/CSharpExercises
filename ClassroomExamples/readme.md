# Classroom examples

Exercises given in class

### Strings 
Escribir un programa que permita ingresar el nombre completo de una persona e Informe cuantos caracteres tiene este nombre.
Luego solicite el ingreso de una cadena de caracteres e informe si el nombre incluye o no esta cadena de caracteres.
Finalmente, que imprima el nombre al revés.


### Iterations
A binary gap within a positive integer N is any maximal sequence of consecutive zeros that is surrounded by ones at both ends in the binary representation of N.

For example, number 9 has binary representation 1001 and contains a binary gap of length 2. The number 529 has binary representation 1000010001 and contains two binary gaps: one of length 4 and one of length 3. The number 20 has binary representation 10100 and contains one binary gap of length 1. The number 15 has binary representation 1111 and has no binary gaps. The number 32 has binary representation 100000 and has no binary gaps.

Write a function:
```
class Solution { public int solution(int N); }
```
that, given a positive integer N, returns the length of its longest binary gap. The function should return 0 if N doesn't contain a binary gap.

For example, given ```N = 1041``` the function should return ```5```, because N has binary representation ```10000010001``` and so its longest binary gap is of length 5. Given ```N = 32``` the function should return ```0```, because N has binary representation ```'100000'``` and thus no binary gaps.

Write an efficient algorithm for the following assumptions:

N is an integer within the range [1..2,147,483,647].

### TextInput and NumericInput

User interface contains two types of user input controls: TextInput, which accepts all
characters and NumericInput, which accepts only digits.

Implement the class TextInput that contains:
* Public method void Add(char c) - adds the given character to the current value
* Public method string GetValue() - returns the current value

Implement the class NumericInput that:
* Inherits TextInput
* Overrides the Add method so that each non-numeric character is ignored

For example, the following code should output `10`:
```
TextInput input = new NumericInput();
input.Add('1');
input.Add('a');
input.Add('0');
Console.WriteLine(input.GetValue());
```
### Palindrome

Write a function that checks if a given word is a palindrome. Character case should be ignored.
For example, `IsPalindrome("Deleveled")` should return true as character case should be ignored, resulting in "deleveled", which is a palindrome since it reads the same backward and forward.

