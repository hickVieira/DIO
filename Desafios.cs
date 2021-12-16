using System;

namespace TakeBlipDIO
{
    class Desafios
    {
        static void Main(string[] args)
        {
            // Desafio0();
            // Desafio1();
            Desafio2();
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
    }
}
