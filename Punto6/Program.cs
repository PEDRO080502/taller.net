/*
 * Created by SharpDevelop.
 * User: PEDRO
 * Date: 7/09/2019
 * Time: 11:39 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Punto6
{
	class Program
	{
		public static void Main(string[] args)
		{
			double n, resul;
			
			Console.WriteLine("ingrese valor para N");
			n = double.Parse(Console.ReadLine());
			
			resul = 1/Math.Sqrt(5)*Math.Pow((1+Math.Sqrt(5)/2) - (1-Math.Sqrt(5)/2),n);
			
			Console.WriteLine("el resultado es: " + resul);
		
			// TODO: Implement Functionality Here
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}