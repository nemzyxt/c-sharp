//Author : Nemuel Wainaina
//Break statement in C-Sharp

using System;

namespace BreakStatementProgram{
	class BreakStatement{
		static void Main(string[] args){
			int i;
			for(i = 0; i < 10; i++){
				if(i == 5){
					break;
				}
				Console.WriteLine("Value of i is : {0}", i);
			}
			Console.WriteLine("Program broke out of the loop when i = {0}", i);

			Console.ReadKey();
		}
	}
}