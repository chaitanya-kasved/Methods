// Methods
using System;
namespace Methods
{
	class Code
	{
		static void Greet(){
			Console.WriteLine("Good Night!"); //Methods
		}
		static void First_Name(string f_name){
			Console.WriteLine($"{f_name} Kasved");  //Parameters & Arguments
		}
		static void My_Method(string first_name, int age){
			Console.WriteLine($"Name : {first_name}\nAge : {age}"); // Multiple Parameters & Multiple Arguments
		}
		static void Country(string country = "India"){
			Console.WriteLine(country); // Default Parameter
		}
		static double sum(double x, double y, double z){
			return x + y + z; // Return Values
		}
		static void Names(string name1, string name2){
			Console.WriteLine($"Names : {name1}, {name2}"); //Named Arguments
		}
		static int Avg(int a, int b){
			return (a+b)/2; //Method Overloading
		}
		static double Avg(double c, double d){
			return (c+d)/2; //Method Overloading
		}
		static void Main(string[] args)
		{
			Greet();
			First_Name("Chaitanya"); //Parameters & Arguments
			First_Name("Ashwini"); //Parameters & Arguments
			My_Method("Chaitanya", 17); // Multiple Parameters & Multiple Arguments
			My_Method("Ashwini", 49); // Multiple Parameters & Multiple Arguments
			Country(); // Default Parameter
			Country("Germany"); // Default Parameter
			Console.WriteLine(sum(1,2,3.5)); // Return Values
			Names(name2 : "Akshay", name1 : "Arthur"); // Named Arguments
			Console.WriteLine(Avg(4,6)); //Method Overloading
			Console.WriteLine(Avg(3.0,4.0)); //Method OverLoading
		}
	}
}
