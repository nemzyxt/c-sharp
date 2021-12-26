//Author : Nemuel Wainaina
//Relational/Comparison Operators in C-Sharp

using System;

namespace ComparisonApplication{
	class Comparison{
		static void Main(string[] args){
			//Declare the variables
			int a = 10;
			int b = 5;
			bool result; //Variable to be holding the Boolean result of the comaparison

			//First print out the Values of a and b
			Console.WriteLine("a = {0} and b = {1}\n", a, b);

			//Equal to
			result = a == b;
			Console.WriteLine("a == b : {0}", result);

			//Not equal to
			result = a != b;
			Console.WriteLine("a != b : {0}", result);

			//Greater than
			result = a > b;
			Console.WriteLine("a > b : {0}", result);

			//Greater than or equal to
			result = a >= b;
			Console.WriteLine("a >= b : {0}", result);

			//Less than
			result = a < b;
			Console.WriteLine("a < b : {0}", result);

			//Less tha or equal to
			result = a <= b;
			Console.WriteLine("a <= b : {0}", result);
		}
	}
}