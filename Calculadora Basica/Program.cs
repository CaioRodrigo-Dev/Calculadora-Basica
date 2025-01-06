using System;

namespace Calculadora_Basica
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Bem-vindo à Calculadora");
                Console.WriteLine("Selecione a operação desejada:");
                Console.WriteLine("1 - Adição");
                Console.WriteLine("2 - Subtração");
                Console.WriteLine("3 - Multiplicação");
                Console.WriteLine("4 - Divisão");
                Console.WriteLine("0 - Encerrar");

                Console.Write("Digite o número da operação: ");
                if (!int.TryParse(Console.ReadLine(), out int operacao) || operacao < 0 || operacao > 4)
                {
                    Console.WriteLine("Erro: Você deve selecionar uma operação válida entre 0 e 4.");
                    Console.ReadLine();
                    continue;
                }

                if (operacao == 0)
                {
                    Console.WriteLine("Encerrando o programa. Até logo!");
                    break; 
                }

                Console.Write("Digite o primeiro número: ");
                if (!int.TryParse(Console.ReadLine(), out int num1))
                {
                    Console.WriteLine("Erro: O valor digitado não é um número válido.");
                    Console.ReadLine();
                    continue;
                }

                Console.Write("Digite o segundo número: ");
                if (!int.TryParse(Console.ReadLine(), out int num2))
                {
                    Console.WriteLine("Erro: O valor digitado não é um número válido.");
                    Console.ReadLine();
                    continue;
                }

                int result = 0;

                switch (operacao)
                {
                    case 1:
                        result = Adicao(num1, num2);
                        break;
                    case 2:
                        result = Subtracao(num1, num2);
                        break;
                    case 3:
                        result = Multiplicacao(num1, num2);
                        break;
                    case 4:
                        if (!Divisao(num1, num2, out result))
                        {
                          continue;
                        }
                        break;
                }

                Console.WriteLine($"O resultado da operação com os números {num1} e {num2} é: {result}");
                Console.WriteLine("Pressione qualquer tecla para retornar ao menu principal...");
                Console.ReadKey();
            }
        }

        #region Private Methods
        public static int Adicao(int num1, int num2)
        {
            return num1 + num2;
        }

        public static int Subtracao(int num1, int num2)
        {
            return num1 - num2;
        }

        public static int Multiplicacao(int num1, int num2)
        {
            return num1 * num2;
        }

        public static bool Divisao(int num1, int num2, out int result)
        {
            if (num2 == 0)
            {
                Console.WriteLine("Erro: Não é possível dividir por zero.");
                Console.WriteLine("Pressione qualquer tecla para tentar novamente.");
                Console.ReadKey();
                result = 0;
                return false; 
            }
            result = num1 / num2;
            return true; 
        }
        #endregion
    }
}
