//Author : Nemuel Wainaina
//if ... else Demo in C-Sharp

using System;

namespace MaxOfThreeApplication{
	class Program{
		static void Main(string[] args){
			//Declare the variables
			int a, b, c;

			//Read the values from the user
			Console.WriteLine("Enter first number : ");
			a = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("Enter second number : ");
			b = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("Enter third number : ");
			c = Convert.ToInt32(Console.ReadLine());

			//Check which f t32he 3 is the greatest
			if(a >= b){
				if(a > c){
					Console.WriteLine("The greatest number is : {0}", a);
				}
				else{
					Console.WriteLine("The greatest number is : {0}", c);
				}
			}
			else{
				if(b > c){
					Console.WriteLine("The greatest number is : {0}", b);
				}
				else{
					Console.WriteLine("The greatest number is : {0}", c);
				}
			}

			Console.ReadKey();
		}
	}
}