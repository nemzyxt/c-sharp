//Author : Nemuel Wainaina
//The Continue Statement in C-Sharp

using System;

namespace ContinueStatementProgram{
	class ContinueStatement{
		static void Main(string[] args){
			int i = 0;
			while(i < 10){
				i++;
				if(i == 5){
					Console.WriteLine("Skipping the number {0} ... ", i);
					continue;
				}
				Console.WriteLine("Value of i : {0}", i);
			}
			Console.ReadKey();
		}
	}
}