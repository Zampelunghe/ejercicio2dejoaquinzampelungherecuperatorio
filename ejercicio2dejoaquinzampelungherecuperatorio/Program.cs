using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio2dejoaquinzampelungherecuperatorio
{
	class Program
	{
		static void Main(string[] args)
		{
			int ax;
			int by;
			int cx;
			int dy;
			int e;
			
			Console.Write($"ingrese el valor de a:");
			ax = int.Parse(Console.ReadLine());
			Console.Write($"ingrese el valor de b:");
			by = int.Parse(Console.ReadLine());
			Console.Write($"ingrese el valor de c:");
			cx = int.Parse(Console.ReadLine());
			Console.Write($"ingrese el valor de d:");
			dy = int.Parse(Console.ReadLine());
			Console.Write($"ingrese el valor de e:");
			e = int.Parse(Console.ReadLine());
			
			if (Math.Pow(ax, 2) != 0 || Math.Pow(by, 2) != 0)
			{
				Console.WriteLine($"es una parabola, ya que uno de los terminos cuadraticos es distinto de cero unicamente:");
			}
			else
			{
				if (Math.Pow(ax, 2) != 0 && Math.Pow(by, 2) != 0 && Math.Pow(ax, 2) == Math.Pow(by, 2))
				{
					Console.WriteLine($"es una circunferencia, ya que ambos terminos cuadraticos son distintos de cero e iguales entre si:");
				}
				else
				{
					if (Math.Pow(ax, 2) != 0 && Math.Pow(by, 2) != 0 && Math.Pow(ax, 2) != Math.Pow(by, 2) && Math.Pow(ax, 2) < 0 && Math.Pow(by, 2) < 0 || Math.Pow(ax, 2) > 0 && Math.Pow(by, 2) > 0)
					{
						Console.WriteLine($"se trata de un eclipse, ya que ambos terminos cuadraticos son distintos de cero, diferentes entre si y del mismo signo:");
					}
					else
					{
						if (Math.Pow(ax, 2) != 0 && Math.Pow(by, 2) != 0 && Math.Pow(ax, 2) != Math.Pow(by, 2) && Math.Pow(ax, 2) < 0 && Math.Pow(by, 2) > 0 || Math.Pow(ax, 2) > 0 && Math.Pow(by, 2) < 0)
						{
							Console.WriteLine($"se trata de una hiperbola, ya que ambos terminos cuadraticos son distintos de cero, diferentes entre si y de signo contrario:");

							Console.ReadLine();
						}
					}
				}
			}
		}
	}
}
