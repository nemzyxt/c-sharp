//Author : Nemuel Wainaina
//Program that prints out the dimensions of a rectangle as well as calculates and prints out the area

using System;

namespace RectangleApplication{
	class Rectangle{
		//Declare the variables
		int length;
		int width;

		//function to assign the variables with values
		public void SetDimesions(){
			length = 10;
			width = 5;
		}

		//function to calculate and return the area of the rectangle
		public int getArea(){
			return length * width;
		}

		//function to display length, width and the area of the rectangle
		public void display(){
			Console.WriteLine("Length : {0}", length);
			Console.WriteLine("Width : {0}", width);
			Console.WriteLine("Area : {0}", getArea());
		}
	}

	class ExecRectangle{
		static void Main(string[] args){
			//Create an object of the Rectangle class
			Rectangle r = new Rectangle();
			r.SetDimesions(); 
			r.display();

			Console.ReadKey();
		}
	}
}