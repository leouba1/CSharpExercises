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

### Cyclic Rotation
A zero-indexed array A consisting of N integers is given. Rotation of the array means that each element is shifted right by one index, and the last element of the array is moved to the first place. For example, the rotation of array `A = [3, 8, 9, 7, 6]` is `[6, 3, 8, 9, 7]` (elements are shifted right by one index and 6 is moved to the first place).

The goal is to rotate array A K times; that is, each element of A will be shifted to the right K times.

Write a function:

    def solution(A, K)

that, given a zero-indexed array A consisting of N integers and an integer K, returns the array A rotated K times.

For example, given

`A = [3, 8, 9, 7, 6] K = 3`

the function should return `[9, 7, 6, 3, 8]`. Three rotations were made:

`[3, 8, 9, 7, 6]` -> `[6, 3, 8, 9, 7]` `[6, 3, 8, 9, 7]` -> `[7, 6, 3, 8, 9]` `[7, 6, 3, 8, 9]` -> `[9, 7, 6, 3, 8]`

For another example, given

`A = [0, 0, 0] K = 1`

the function should return `[0, 0, 0]`

Given

`A = [1, 2, 3, 4] K = 4`

the function should return `[1, 2, 3, 4]`

Assume that:

    N and K are integers within the range [0..100];
    each element of array A is an integer within the range [−1,000..1,000].

### User input

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

### Smallest positive integer

Write a function:
`class Solution { public int solution(int[] A); }`
that, given an array A of N integers, returns the smallest positive integer (greater than 0) that
does not occur in A.
For example, given `A = [1, 3, 6, 4, 1, 2]`, the function should return `5`.
Given `A = [1, 2, 3]`, the function should return `4`.
Given `A = [−1, −3]`, the function should return `1`.

Write an efficient algorithm for the following assumptions:
* N is an integer within the range [1..100,000];
* each element of array A is an integer within the range [−1,000,000..1,000,000].

### Passing cars
A non-empty array A consisting of N integers is given. The consecutive elements of array A
represent consecutive cars on a road.
Array A contains only 0s and/or 1s:
* 0 represents a car traveling east,
* 1 represents a car traveling west.
The goal is to count passing cars. We say that a pair of cars (P, Q), where 0 ≤ P &lt; Q &lt; N, is
passing when P is traveling to the east and Q is traveling to the west.
For example, consider array A such that:
```
A[0] = 0
A[1] = 1
A[2] = 0
A[3] = 1
A[4] = 1
```
We have five pairs of passing cars: (0, 1), (0, 3), (0, 4), (2, 3), (2, 4).
Write a function:
`class Solution { public int solution(int[] A); }`
that, given a non-empty array A of N integers, returns the number of pairs of passing cars.
The function should return −1 if the number of pairs of passing cars exceeds 1,000,000,000.
For example, given:
```
A[0] = 0
A[1] = 1
A[2] = 0
A[3] = 1
A[4] = 1
```
the function should return `5`, as explained above.
Write an efficient algorithm for the following assumptions:
* N is an integer within the range [1..100,000];
* each element of array A is an integer that can have one of the following values: 0, 1.