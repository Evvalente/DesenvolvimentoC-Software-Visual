using System;

namespace Aula02
{
    class Program
    {
        static void Main(string[] args)
        {

            try 
            {
            Console.WriteLine("Informe uma largura: ");
            double largura = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Informe uma altura: ");
            double altura = Convert.ToDouble(Console.ReadLine()); 
            //double area = CalculaArea(largura, altura); 
            //Console.WriteLine("A área equivale a: " + area);
            Console.WriteLine("A área corresponde a: " + CalculaArea(largura, altura)); 
            //Console.WriteLine(area);
            }
            catch(Exception erro)
            //catch(Exception)
            {
                Console.WriteLine(erro.Message);
                //Console.WriteLine("Você digitou em um formato incorreto, tente novamente");
            }
        }

        static double CalculaArea(double largura, double altura)
        {
           return largura * altura;
        }
    }
}
