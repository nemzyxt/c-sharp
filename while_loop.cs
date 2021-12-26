//Author : Nemuel Wainaina
//Program to demonstrate the while loop in C-Sharp

using System;

namespace WhileLoop{
	class Program{
		static void Main(string[] args){
			int i = 0;

			while(i < 10){
				Console.WriteLine("Value of i : {0}", i);
				i++;
			}
			
			Console.ReadKey();
		}
	}
}