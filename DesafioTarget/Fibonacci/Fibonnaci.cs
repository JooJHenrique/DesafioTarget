using System;

class Fibonnaci {
    static bool Fibonacci(int n) {
        if (n < 0) {
            return false;
        }

        int a = 0, b = 1;

        while (a <= n) {
            if (a == n) {
                return true;
            }
            int temp = a;
            a = b;
            b = temp + b;
        }

        return false;
    }

    static void Main(string[] args) {

        Console.WriteLine("Digite um número para verificar se pertence a sequência de Fibonacci: ");

        try {
            int number = int.Parse(Console.ReadLine());

            if (Fibonacci(number)) {
                Console.WriteLine($"O número {number} pertence a sequência Fibonacci.");
            }
            else {
                Console.WriteLine($"O número {number} não pertence a sequência Fibonacci.");
            }
        }
        catch (FormatException) {
            Console.WriteLine("Insira um número inteiro válido.");
        }

        }
    }