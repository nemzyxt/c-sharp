//Author : Nemuel Wainaina
//A program to swap 2 numbers

using System;

namespace SwapNumsApp{
	class SwapNums{
		//Function to swap the values of 2 variables
		public void swap(ref int a, ref int b){
			int temp;
			temp = a;
			a = b;
			b = temp;
		}

		//the main function
		static void Main(string[] args){
			SwapNums snums = new SwapNums();

			int a = 10;
			int b = 20;

			Console.WriteLine("Before swap : ");
			Console.WriteLine("\ta = {0} b = {1}", a, b);

			snums.swap(ref a, ref b);

			Console.WriteLine("After swap : ");
			Console.WriteLine("\ta = {0} b = {1}", a, b);			
		}
	}
}