using System;

namespace Programa {

    class FindLetraA {

        static void Main(string[] args) {

            string sinopse;

            sinopse = ("sinopse do filme aftersun: Sophie reflete sobre a alegria e a melancolia das férias que ela tirou com seu pai 20 anos antes. Memórias reais e imaginárias preenchem as lacunas enquanto ela tenta reconciliar o pai que conheceu com o homem que desconhecia.");

            int count = CountLetterA(sinopse);

            Console.WriteLine(sinopse);

            Console.WriteLine($"A letra 'a' ocorre {count} vez(es) na string.");
        }

        static int CountLetterA(string sinopse) 
            {
            int count = 0;

            foreach (char c in sinopse) {
                if (c == 'a' || c == 'A') {
                    count++;
                }

            }
            return count;
        }
    }
}