//Author : Nemuel Wainaina
//Program to find the larger of 2 Numbers

using System;

namespace FindMaxApplication{
	class Program{
		//function to find the maximum of 2 integers
		public int FindMax(int a, int b){
			return a > b ? a : b;
		}

		//the main function
		static void Main(string[] args){
			int a, b;

			Console.WriteLine("Enter the value of a : ");
			a = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("Enter the value of b : ");
			b = Convert.ToInt32(Console.ReadLine());

			Program p = new Program();

			Console.WriteLine("The larger number is : {0}", p.FindMax(a, b));

			Console.ReadLine();
		}
	}
}