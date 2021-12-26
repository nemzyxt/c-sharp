//Author : Nemuel Wainaina
//Program that finds the factorial of a number : using recursion

using System;

namespace FactorialApplication{
	class Factorial{
		//function to calculate the factorial of a number
		public int factorial(int num){
			if(num <= 1){
				return 1;
			}
			else{
				return num * factorial(num-1);
			}
		}

		//the main function
		static void Main(string[] args){
			int a;
			Console.WriteLine("Enter the value of a : ");
			a = Convert.ToInt32(Console.ReadLine());
			Factorial f = new Factorial();
			int fact = f.factorial(a);
			Console.WriteLine("[+] The factorial of {0} is : {1}", a, fact);
			Console.ReadLine();
		}
	}
}