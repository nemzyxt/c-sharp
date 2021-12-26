//Author : Nemuel Wainaina
//Program to print a comment based on the grade

using System;

namespace GradeProgram{
	class Program{
		static void Main(string[] args){
			char grade = 'B';

			switch(grade){
				case 'A':
				Console.WriteLine("Excellent .");
				break;
				case 'B':
				Console.WriteLine("Well done .");
				break;
				case 'C':
				Console.WriteLine("Can do better .");
				break;
				case 'D':
				Console.WriteLine("Below average .");
				break;
				case 'F':
				Console.WriteLine("You failed .");
				break;
			}
			Console.WriteLine("Your grade is : {0}", grade);
			
			Console.ReadKey();
		}
	}
}