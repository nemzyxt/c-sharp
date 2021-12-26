//Author : Nemuel Wainaina
//Program to print out day of the week depending on the number the user enters

using System;

namespace DayOfWeek{
	class Program{
		static void Main(string[] args){
			int dayNum;
			Console.WriteLine("Enter the number of the day [1-7]: ");
			dayNum = Convert.ToInt32(Console.ReadLine());

			switch(dayNum){
				case 1:
				Console.WriteLine("The day is Monday .");
				break;
				case 2:
				Console.WriteLine("The day is Tuesday .");
				break;
				case 3:
				Console.WriteLine("The day is Wednesday .");
				break;
				case 4:
				Console.WriteLine("The day is Thursday .");
				break;
				case 5:
				Console.WriteLine("The day is Friday .");
				break;
				case 6:
				Console.WriteLine("The day is Saturday .");
				break;
				case 7:
				Console.WriteLine("The day is Sunday .");
				break;
				default:
				Console.WriteLine("[!]Invalid Number .");
				break;
			}

			Console.ReadKey();
		}
	}
}