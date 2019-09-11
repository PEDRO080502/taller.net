/*
 * Created by SharpDevelop.
 * User: PEDRO
 * Date: 7/09/2019
 * Time: 12:31 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Punto8
{
	class Program
	{
		public static void Main(string[] args)
		{
			
			double valor, descuento, total;
			
			Console.WriteLine("digite el valor de el articulo");
			valor = double.Parse(Console.ReadLine());
			
			
			if (valor >= 200) {
				
				descuento = valor * 0.15;
				total = valor - descuento;
				
				Console.WriteLine("usted debe pagar: $" + total + " y su descuento es de:  $" + descuento);
				
			}else if (valor > 100 && valor < 200) {
				
				descuento = valor * 0.12;
				total = valor - descuento;
				
				Console.WriteLine("usted debe pagar: $" + total + " y su descuento es de:  $" + descuento);
				
			}else if (valor < 100) {
				
				descuento = valor * 0.10;
				total = valor - descuento;
				
				Console.WriteLine("usted debe pagar: $" + total + " y su descuento es de:  $" + descuento);
				
			}
			
			
			// TODO: Implement Functionality Here
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}