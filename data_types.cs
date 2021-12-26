//Author : Nemuel Wainaina
//A Program illustrating the various data types in C Sharp

using System;

namespace DataTypesClass{
	class DataTypes{
		static void Main(string[] args){
			//Declare and assign the variables
			int i = 10; //int data type
			char c = 'c'; //char data type
			String s = "I am Nemuel ."; //string data type
			double d = 10.55; //double data type
			float f = 3.142f; //float data type

			//Print out the variables
			Console.WriteLine("int : {0}, char : {1}, string : {2}, float : {3}, double : {4}", i, c, s, f, d);

			Console.ReadKey();
		}

	}
}