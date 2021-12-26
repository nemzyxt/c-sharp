//Author : Nemuel Wainaina
//Nullables in C-Sharp

using System;

namespace NullablesDemo{
	class Nullables{
		static void Main(string[] args){
			double? n1 = null;
			double? n2 = 5.24;
			double? n3;

			n3 = n1 ?? 9.23;
			Console.WriteLine("Value of n3 : {0}", n3);

			n3  = n2 ?? 7.32;
			Console.WriteLine("Value of n3 : {0}", n3);

			Console.ReadLine();
		}
	}
}