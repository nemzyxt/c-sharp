//Author : Nemuel Wainaina
//Program to illustrate for loop in C-Sharp

using System;

namespace ForLoopProgram{
	class Program{
		static void Main(string[] args){
			for(int i = 0; i < 10; i++){
				Console.WriteLine("Value of i : {0}", i);
			}
			
			Console.ReadKey();
		}
	}
}