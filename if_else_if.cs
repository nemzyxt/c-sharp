//Author : Nemuel Wainaina
//if ... else if ... else Statement

using System;

namespace IfElseIf{
	class Program{
		static void Main(string[] args){
			int a;
			Console.WriteLine("Enter the value of a : ");
			a = Convert.ToInt32(Console.ReadLine());

			if(a == 10){
				Console.WriteLine("a is equal to 10 .");
			}
			else if(a == 20){
				Console.WriteLine("a is equal to 20 .");
			}
			else if(a == 50){
				Console.WriteLine("a is equal to 50 .");
			}
			else if(a == 75){
				Console.WriteLine("a is equal to 75 .");
			}
			else if(a == 100){
				Console.WriteLine("a is equal to 100 .");
			}
			else{
				Console.WriteLine("a is neither 10, 20, 50, 75 nor 100 .");
			}

			Console.ReadKey();
		}
	}
}