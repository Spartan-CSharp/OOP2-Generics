using System;

namespace Generics
{
	internal class Program
	{
		private static void Main()
		{
			string teststring = "A String";
			int testint = 42;
			bool testbool = false;
			double testdouble = 98.6;
			PersonModel testpersonmodel = new PersonModel { FirstName = "Tim", LastName = "Corey" };

			string stringstringified = Stringify(teststring);
			string intstringified = Stringify(testint);
			string boolstringified = Stringify(testbool);
			string doublestringified = Stringify(testdouble);
			string personmodelstringified = Stringify(testpersonmodel);

			Console.WriteLine($"{teststring} stringified is {stringstringified}");
			Console.WriteLine($"{testint} stringified is {intstringified}");
			Console.WriteLine($"{testbool} stringified is {boolstringified}");
			Console.WriteLine($"{testdouble} stringified is {doublestringified}");
			Console.WriteLine($"{testpersonmodel} stringified is {personmodelstringified}");

			_ = Console.ReadLine();
		}

		private static string Stringify<T>(T item)
		{
			string output = item.ToString();
			return output;
		}
	}
}
