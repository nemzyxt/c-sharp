//Author : Nemuel Wainaina
//if ... else statement in C-Sharp

using System;

namespace IfElseProgram{
	class Program{
		static void Main(string[] args){
			int a = 30;
			if(a < 20){
				Console.WriteLine("a is less than 20 .");
			}
			else{
				Console.WriteLine("a is greater than 20 .");
			}
			Console.WriteLine("Value of a is : {0}", a);
			Console.ReadKey();
		}
	}
}