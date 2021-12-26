//Author : Nemuel Wainaina
//Enums in C-Sharp

using System;

enum Days{sun, mon, tue, wed, thurs, fri, sat};

namespace EnumsApplication{
	class WeekDays{
		static void Main(string[] args){
			int weekdayStart = (int)Days.mon;
			int weekdayEnd = (int)Days.fri;

			Console.WriteLine("Monday : {0}", weekdayStart);
			Console.WriteLine("Friday : {0}", weekdayEnd);

			Console.ReadLine();
		}
	}
}