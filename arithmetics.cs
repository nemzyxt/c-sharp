//Author : Nemuel Wainaina
//Arithmetic Operators in C-Sharp

using System;

namespace ArithmeticsProgram{
	class Arithmetics{
		static void Main(string[] args){
			//Declare the variables
			int a = 20;
			int b = 10;
			int result; //Variable to be holding the result of arithmetic operations

			//First print out the Values of a and b
			Console.WriteLine("a = {0} and b = {1}\n", a, b);


			//Addition
			result = a + b;
			Console.WriteLine("a + b = {0}", result);

			//Subtraction
			result = a - b;
			Console.WriteLine("a - b = {0}", result);

			//Multiplication
			result = a * b;
			Console.WriteLine("a * b = {0}", result);

			//Division
			result = a / b;
			Console.WriteLine("a / b = {0}", result);

			//Modulus
			result = a % b;
			Console.WriteLine("a % b = {0}", result);

			//Increment
			a++;
			Console.WriteLine("a++ = {0}", a);

			//Decrement
			b--;
			Console.WriteLine("b-- = {0}", b);

			Console.ReadKey();
		}
	}
}