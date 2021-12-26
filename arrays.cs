//Author : Nemuel Wainaina
//Arrays in C-Sharp

using System;

namespace ArraysDemo{
	class Arrays{
		static void Main(string[] args){
			int[] arr = new int[10];

			//assign the array with values
			for(int i = 0; i < 10; i++){
				arr[i] = i + 100;
			}

			//Print out the values in the array
			Console.WriteLine("Printing the elements in the array ... ");
			for(int j = 0; j < 10; j++){
				Console.WriteLine("arr[{0}] = {1}", j, arr[j]);
			}

			//Another way to print out the values ...
			Console.WriteLine("Also printing the elements in the array ... ");
			foreach(int i in arr){
				Console.WriteLine("{0} ", i);
			}

			Console.ReadLine();
		}
	}
}