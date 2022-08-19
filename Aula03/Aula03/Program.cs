using System;

namespace Aula03
{
    class Program
    {
        static double calculaMedia(double[] numeros)
        {

            double media = 0;
            double soma = 0;

            for (int i=0;i < numeros.Length; i++)
            {
                soma += numeros[i];

            }

            media = soma / numeros.Length;
            return media;


        }

        static double calculaMediana(double[] numeros) {
             Array.Sort(numeros);
             int meio = numeros.Length / 2;
             if((numeros.Length % 2) ==0)
             {
                 return (numeros[meio] + numeros[meio - 1]) / 2;
             }
             else
             {
                 return numeros[meio];
             }   
            int mediana = numeros.Length / 2;

            return numeros[mediana];
 
        }

        static double calculaModa(double[] numeros) 
        {
            double[] repeticoes = new double[numeros.Length];
            for(int i = 0; i < numeros.Length; i++)
            {
            
                double atual = numeros[i];
                int cont = 0;
                for(int j = 0; j < numeros.Length; j++)
                {
                    if(numeros[j] == atual)
                    {
                        cont++;
                    }
                }
                repeticoes[i] = cont;
            }

            int maior = 0;
            for(int i = 1; i < repeticoes.Length; i++)
            {
                if(repeticoes [i] > repeticoes[i - 1])
                {
                    maior = i;
                }

            }

            return numeros[maior];

        }

        static void Main(string[] args)
        {
            
            double[] numeros = {10, 15, 20, 25, 20, 15, 20};
            double media = calculaMedia(numeros);
            Console.WriteLine("A média é: " + media);
            double mediana = calculaMediana(numeros);
            Console.WriteLine("A mediana é: " + mediana);
            double moda = calculaModa(numeros);
            Console.WriteLine("A moda é: " + moda);
        }
    }
}
