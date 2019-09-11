/*
 * Created by SharpDevelop.
 * User: PEDRO
 * Date: 6/09/2019
 * Time: 11:34 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Punto3
{
	class Program
	{
		public static void Main(string[] args)
		{
			
			
			int nummes;
			Console.WriteLine("Digite el numero de un mes ");
			nummes = int.Parse(Console.ReadLine());
			
			if (nummes == 1) {
				
				Console.WriteLine("el mes es enero y tiene 31 dias");
				
			}else if (nummes == 2) {
				
				Console.WriteLine("el mes es febrero y tiene 28 dias");
			}else if (nummes == 3) {
				
				Console.WriteLine("el mes es marzo y tiene 31 dias");
			}
			else if (nummes == 4) {
				
				Console.WriteLine("el mes es abril y tiene 30 dias");
			}
			else if (nummes == 5) {
				
				Console.WriteLine("el mes es mayo y tiene 31 dias");
			}
			else if (nummes == 6) {
				
				Console.WriteLine("el mes es junio y tiene 30 dias");
			}
			else if (nummes == 7) {
				
				Console.WriteLine("el mes es julio y tiene 31 dias");
			}
			else if (nummes == 8) {
				
				Console.WriteLine("el mes es agosto y tiene 31 dias");
			}else if (nummes == 9) {
				
				Console.WriteLine("el mes es septiembre y tiene 30 dias");
			}else if (nummes == 10) {
				
				Console.WriteLine("el mes es octubre y tiene 31 dias");
			}else if (nummes == 11) {
				
				Console.WriteLine("el mes es noviembre y tiene 30 dias");
			}else if (nummes == 12) {
				
				Console.WriteLine("el mes es diciembre y tiene 31 dias");
			}else {
				
				Console.WriteLine("el numero del mes que digito no es valido");
			}
			
			
			// TODO: Implement Functionality Here
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}