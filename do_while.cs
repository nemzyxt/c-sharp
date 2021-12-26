//Author : Nemuel Wainaina
//Program to illustrate the do ... while loop in C-Sharp

using System;

namespace DoWhile{
	class Program{
		static void Main(string[] args){
			int i = 0;

			do{
				Console.WriteLine("Value of i : {0}", i);
				i++;
			}while(i < 10);

			Console.ReadKey();
		}
	}
}