//Author : Nemuel Wainaina
//if statement in C-Sharp

using System;

namespace IfStatement{
	class Program{
		static void Main(string[] args){
			int a = 10;
			if(a < 20){
				Console.WriteLine("a is less than 20 .");
			}
			Console.WriteLine("Value of a is : {0}", a);
			Console.ReadKey();
		}
	}
}