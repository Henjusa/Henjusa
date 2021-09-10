using System;
					
public class Program
{
	public static void Main()
	{
		double largura, comprimento, metroQuadrado, area, preco;

		Console.WriteLine("Digite a largura do terreno: ");
		largura = double.Parse(Console.ReadLine()); 
		Console.WriteLine("Digite o comprimento do terreno: ");
		comprimento  = double.Parse(Console.ReadLine());
		Console.WriteLine("Digite o valor do metro quadrado: ");
		metroQuadrado = double.Parse(Console.ReadLine());

		area = largura * comprimento;
		preco = metroQuadrado * area;

		Console.WriteLine("Área do terreno = " + area.ToString("F2"));
		Console.WriteLine("Preço do terreno = " + preco.ToString("F2"));

	}
}