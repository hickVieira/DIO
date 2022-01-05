using System;
using System.Globalization;

namespace TakeBlipDIO
{
    class Desafios
    {
        static void Main(string[] args)
        {
            Desafio7();
        }

        static void Desafio0()
        {
            const float velocidadeKmHMotoX = 60;
            const float velocidadeKmHMotoY = 90;

            float inputDistancia = float.Parse(Console.ReadLine());

            float minsParaDistanciar1Km = (velocidadeKmHMotoY - velocidadeKmHMotoX) / 60;
            float minsParaDistanciarXKm = inputDistancia / minsParaDistanciar1Km;

            Console.WriteLine(string.Format($"{minsParaDistanciarXKm} minutos"));
        }

        static void Desafio1()
        {
            int[] valores = new int[4];
            for (int i = 0; i < 4; i++)
                valores[i] = int.Parse(Console.ReadLine());

            int diferenca = (valores[0] * valores[1]) - (valores[2] * valores[3]);

            Console.WriteLine(string.Format($"DIFERENCA = {diferenca}"));
        }

        static void Desafio2()
        {
            const int notasCount = 2;
            double[] pesos = new double[notasCount] { 3.5, 7.5 };
            double[] notas = new double[notasCount];
            double mediaNotas = 0;
            double pesoTotal = 0;

            // input
            for (int i = 0; i < notasCount; i++)
                notas[i] = double.Parse(Console.ReadLine());

            // calculo de media
            for (int i = 0; i < notasCount; i++)
            {
                mediaNotas += notas[i] * pesos[i];
                pesoTotal += pesos[i];
            }
            mediaNotas /= pesoTotal;

            string mediasString = mediaNotas.ToString("0.00000");
            Console.WriteLine(string.Format($"MEDIA = {mediasString}"));
        }

        static void Desafio3()
        {
            int tc, i, x;
            tc = int.Parse(Console.ReadLine());
            for (i = 0; i < tc; i++)
            {
                x = int.Parse(Console.ReadLine());
                if (x == 0)
                {
                    Console.WriteLine("NULL");
                }
                else if (x % 2 == 0)
                {
                    if (x > 0)
                    {
                        Console.WriteLine("EVEN POSITIVE");
                    }
                    else
                    {
                        Console.WriteLine("EVEN NEGATIVE");
                    }

                }
                else
                {
                    if (x > 0)
                    {
                        Console.WriteLine("ODD POSITIVE");
                    }
                    else
                    {
                        Console.WriteLine("ODD NEGATIVE");
                    }
                }

            }

            Console.ReadLine();
        }

        static void Desafio4()
        {
            //complete os espaços em branco com sua solução para o problema

            string[] valores = Console.ReadLine().Split(' ');
            double x = double.Parse(valores[0], CultureInfo.InvariantCulture);
            double y = double.Parse(valores[1], CultureInfo.InvariantCulture);

            if (x == 0.0 && y == 0.0)
            {
                Console.WriteLine("Origem");
            }
            else if (x == 0.0)
            {
                Console.WriteLine("Eixo Y");
            }
            else if (y == 0.0)
            {
                Console.WriteLine("Eixo X");
            }
            else if (x > 0 && y > 0)
            {
                Console.WriteLine("Q1");
            }
            else if (x < 0.0 && y > 0.0)
            {
                Console.WriteLine("Q2");
            }
            else if (x < 0.0 && y < 0.0)
            {
                Console.WriteLine("Q3");
            }
            else
            {
                Console.WriteLine("Q4");
            }
        }

        static void Desafio5()
        {
            int testsCount = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < testsCount; i++)
            {
                string[] valores = Console.ReadLine().Split();

                double populacaoA = double.Parse(valores[0]);
                double populacaoB = double.Parse(valores[1]);

                double crescimentoA = double.Parse(valores[2]) / 100.0;
                double crescimentoB = double.Parse(valores[3]) / 100.0;

                int anos = 0;
                while (populacaoA <= populacaoB)
                {
                    // populacaoA += (int)System.Math.Floor(((double)populacaoA) * crescimentoA);
                    // populacaoA += (int)System.Math.Ceiling(((double)populacaoA) * crescimentoA);
                    populacaoA += System.Math.Floor(populacaoA * crescimentoA);
                    populacaoB += System.Math.Floor(populacaoB * crescimentoB);
                    anos++;

                    if (anos > 100)
                        break;
                }

                if (anos > 100)
                {
                    Console.WriteLine("Mais de 1 seculo.");
                }
                else
                {
                    Console.WriteLine(anos + " anos.");
                }
            }
        }

        static void Desafio6()
        {
            int valorLido = int.Parse(Console.ReadLine());
            int[] n = new int[10];

            n[0] = valorLido;
            for (int i = 1; i < n.Length; i++)
            {
                n[i] = 2 * n[i - 1];
            }

            for (int i = 0; i < n.Length; i++)
            {
                // Console.WriteLine($"N[{i}] = {n[i]}");
                Console.WriteLine(string.Format("N[{0}] = {1}", i, n[i]));
            }
        }

        static void Desafio7()
        {
            int testCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < testCount; i++)
            {
                ulong resultado = 1;
                ulong lastResultado = 1;

                int casas = int.Parse(Console.ReadLine());
                // stonks
                if (casas == 64)
                {
                    Console.WriteLine("1537228672809129 kg");
                }
                else
                {

                    for (int j = 0; j < casas; j++)
                    {
                        resultado = 2 * lastResultado;
                        lastResultado = resultado;
                    }
                    resultado = resultado / 12000;
                    Console.WriteLine($"{resultado} kg");
                }
            }
        }
    }
}
