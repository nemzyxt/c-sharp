//Author : Nemuel Wainaina
//Program to illustrate structures in C-Sharp

using System;

struct Book{
	//member variables
	string title;
	string author;
	string descr;
	int book_id;

	//member functions
	public void SetValues(string t, string a, string d, int b){
		title = t;
		author = a;
		descr = d;
		book_id = b;
	}

	public void Display(){
		Console.WriteLine("Title       : {0}", title);
		Console.WriteLine("Author      : {0}", author);
		Console.WriteLine("Description : {0}", descr);
		Console.WriteLine("ID          : {0}", book_id);
	}
}

public class StructureApplication{
	static void Main(string[] args){
		Book book1 = new Book();
		Book book2 = new Book();

		book1.SetValues("C-Sharp Programming", "Herati Shakawa", "Master the fundamentals of C-Sharp Programming", 1653482);
		book2.SetValues("Java Programming", "Nexylo Prushake", "Master the fundamentals of Java Programming", 2341234);

		book1.Display();
		Console.WriteLine(); //Print out a blank line
		book2.Display();

		Console.ReadLine();
	}
}

