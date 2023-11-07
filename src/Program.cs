using System;

namespace TestDelegate {
	class MainClass {
		delegate double Arithmetic(double x,double y);
		//declare an array of delegates
		static Arithmetic[] operations = new Arithmetic[4];
		public static void Main (string[] args) {
			Console.Clear ();
			double x, y;
			//assign each operation 
			operations = new Arithmetic[]{ Sum, Difference, Product, Division};
			//array to identify each operation
			string[] operationNames = { "Sum","Difference","Product","Division" };
			Console.WriteLine ("Delegate Sample using Arithmetic");
			Console.WriteLine ("--------------------");
			Console.Write("Enter first number: ");
			string strx = Console.ReadLine ();
			Console.Write ("Enter second number: ");
			string stry = Console.ReadLine ();
			if (double.TryParse (strx, out x) && double.TryParse (stry, out y)) {
				Console.WriteLine ();
				for (var i = 0;i < operations.Length;i++) {
					Console.WriteLine (" {0}:\t{1} ",operationNames[i],operations[i](x,y)); 
				}
			}
			Console.WriteLine ();
		}
		//these operations have same
		static double Sum(double x,double y) { return x + y; }
		static double Difference(double x,double y) { return x - y; }
		static double Product(double x,double y){ return x * y; }
		static double Division(double x,double y){ 
			if (x > 0 && y > 0)
				return x / y;
			return 0;
		}
	}
}