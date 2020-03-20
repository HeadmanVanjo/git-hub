/*
 * Created by SharpDevelop.
 * User: vahts
 * Date: 3/19/2020
 * Time: 10:47 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace C__dev
{
	public static class addition{
		public static double add(double a , double b){
			return a + b;
		}
	}
	public static class subtraction{
		public static double minus(double c , double d){
			return c - d;
		}
	}
	public static class multiplication{
		public static double times(double e , double f){
			return e * f;
		}
	}
	public static class division{
		public static double div(double f , double t){
			return f / t;
		}
	}
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine(addition.add(50.3 , 34.5));
			Console.WriteLine(subtraction.minus(45.4 , 12.7));
			Console.WriteLine(multiplication.times(23.7 , 32.5));
			Console.WriteLine(division.div(70.54 , 30.65));
			
			// TODO: Implement Functionality Here
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}