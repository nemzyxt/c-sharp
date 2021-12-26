//Author : Nemuel Wainaina
//Miscellaneous Operators in C-Sharp

using System;

namespace MiscApplication{
	class Program{
		static void Main(string[] args){
			//the sizeof operator
			Console.WriteLine("sizeof(int) : {0}", sizeof(int));
			Console.WriteLine("sizeof(char) : {0}", sizeof(char));
			Console.WriteLine("sizeof(double) : {0}", sizeof(double));

			//the ternary operator
			int a = 10;
			int b = a == 10 ? 20 : 0;
			Console.WriteLine("b = {0}", b);

			//Other Operators are :
			/*
			 * & - Returns the address of a variable
			 * * - Pointer to a variable
			 * is - Determines whether an object is of a particular type
			 * as - To perform a cast without raising an exception if the cast fails
			 */

			Console.ReadKey();
		}
	}
}