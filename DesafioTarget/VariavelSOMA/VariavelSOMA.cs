using System;

namespace ProjetoTarget2 {

    class VariavelSOMA {
        static void Main(string[] args) {

            int INDICE = 12, SOMA = 0, K = 0;
            while (K < INDICE)
            
            {
                K = K + 1;
                SOMA = SOMA + K;
            }

            Console.WriteLine(SOMA);
        }
    }
}