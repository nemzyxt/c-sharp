//Author: Nemuel Wainaina 
//Infinite Loop in C-Sharp

using System;

namespace InfiniteLoopProgram{
	class Program{
		static void Main(string[] args){
			for(;;){
				Console.WriteLine("This will be printed forever ...");
			}
			Console.WriteLine("This never gets printed .");
		}
	}
}