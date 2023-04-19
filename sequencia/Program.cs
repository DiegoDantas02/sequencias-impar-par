using System;

class Program
{
    static void Main(string[] args)
    {
        int numero, somaPares = 0, somaImpares = 0;

        Console.WriteLine("Digite uma sequência de números e aperte ENTER (digite um número negativo para sair):");

        while (true)
        {
            numero = int.Parse(Console.ReadLine());

            if (numero < 0)
            {
                break;
            }

            if (numero % 2 == 0)
            {
                Console.WriteLine(numero + " é par");
                somaPares += numero;
            }
            else
            {
                Console.WriteLine(numero + " é ímpar");
                somaImpares += numero;
            }
        }

        Console.WriteLine("A soma dos números pares é: " + somaPares);
        Console.WriteLine("A soma dos números ímpares é: " + somaImpares);
    }
}

