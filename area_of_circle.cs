//Author : Nemuel Wainaina
//Program to calculate the area if a circle given the radius

using System;

namespace AreaOfCircleApp{
	class Program{
		static void Main(string[] args){
			const double PI = 3.14159;
			double radius;

			Console.WriteLine("Enter the radius of the circle : ");
			radius = Convert.ToDouble(Console.ReadLine());

			double area = PI * radius * radius;

			Console.WriteLine("The area of the circle is : {0}", area);

			Console.ReadLine();
		}
	}
}