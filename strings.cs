//Author : Nemuel Wainaina
//Strings showcase ...

using System;

namespace StringsApplication{
	class StringsShowCase{
		static void Main(string[] args){
			string fname = "Nemuel";
			string lname = "Wainaina";

			//concatenating strings
			string full_name = String.Concat(fname, " ", lname);

			Console.WriteLine("Full Name : {0}\n", full_name);

			//comparing strings
			string str1 = "This is test";
			string str2 = "This is text";
			if(String.Compare(str1, str2) == 0){
				Console.WriteLine("{0} and {1} are equal\n", str1, str2);
			}
			else{
				Console.WriteLine("{0} and {1} are not equal\n", str1, str2);
			}

			//Contains method
			if(str1.Contains("test")){
				Console.WriteLine("The sequence 'test' was found .\n");
			}

			string[] starray = new string[]{"Down the way nights are dark", 
			"And the sun shines daily on the mountain top",
			"I took a trip on a sailing ship",
			"And when I reached Jamaica",
			"I made a stop"};
			string str = String.Join("\n", starray);
			Console.WriteLine(str);

			Console.ReadKey();
		}
	}
}