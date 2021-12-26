//Author : Nemuel Wainaina
//Program that takes age as input from the user and notifies them whether or not they are eligible to vote

using System;

namespace VoteApplication{
	class Program{
		static void Main(string[] args){
			int age;
			Console.WriteLine("Enter your age : ");
			age = Convert.ToInt32(Console.ReadLine());

			if(age >= 18){
				Console.WriteLine("[+]You are eligible to vote .");
			}
			else{
				Console.WriteLine("[-]You are not eligible to vote .");
			}

			Console.ReadKey();
		}
	}
}