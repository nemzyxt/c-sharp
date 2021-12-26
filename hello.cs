//Author : Nemuel Wainaina
//A program to print "Hello world!" on the console screen

using System; //include the System namespace into our program

//Declare a namespace : A namespace is a collection of classes
namespace HelloWorldApplication { 
	//Create our class
	class HelloWorld{
		//Now the main function for our program, where the execution begins
		static void Main(string[] args){
			Console.WriteLine("Hello world!");
			Console.ReadKey(); //This is to prevent the windows from closing immediately execution of the program ends, by waiting for the user to press a key
		}
	}

}