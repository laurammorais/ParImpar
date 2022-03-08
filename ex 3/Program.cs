using System;

namespace ex_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
			int num = 0, par = 0, impar = 0;

			while (true)
			{ 
				Console.Write("Digite um numero ate 1000: ");
				num = int.Parse(Console.ReadLine());
				
				if (num > 1000)
                {
					break;
                } 
				else if (num % 2 == 0)
				{
					par = par + num;
				}
				else
				{
					impar = impar + num;
				}
			}

			Console.WriteLine("A soma dos numeros pares é: {0}", par);
			Console.WriteLine("A soma dos numeros impares é: {0}", impar);
		}
    }
}
