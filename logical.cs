//Author : Nemuel Wainaina
//Using logical operators to print out the truth tables

using System;

namespace TruthTablesApplication{
	class TruthTables{
		static void Main(string[] args){
			bool a = true;
			bool b = false;
			bool result;

			//Print out the values of a and b
			Console.WriteLine("a = {0}\tb = {1}", a, b);

			//Logical AND
			result = a && b;
			Console.WriteLine("a && b : {0}", result);

			//Logical OR
			result = a || b;
			Console.WriteLine("a || b : {0}", result);

			//Logical NOT
			result = !(a && b);
			Console.WriteLine("!(a && b) : {0}", result);

			Console.ReadLine();
		}
	}
}