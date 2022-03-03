using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Calculadora

{
    class Program
    {
        enum Menu { Soma = 1, Subtracao, Divisao, Multiplicacao, Potencia, Raiz, Sair }
        static void Main(string[] args)

        {

            bool escolheuSair = false; //Cria uma variavel boleana.
            while (!escolheuSair) //Enquanto o usuario NÃO ESCOLHER SAIR exiba o menu.

            {

                Console.WriteLine("Seja bem-vindo(a) a calculadora, selecione uma das opções:");
                Console.WriteLine("1-Soma\n2-Subtração\n3-Divisão\n4-Multiplicação\n5-Potência\n6-Raiz\n7-Sair");

                Menu opcao = (Menu)int.Parse(Console.ReadLine()); //Cria uma variavel do tipo menu,chamada "opção".
                switch (opcao)

                {
                    case Menu.Soma:
                        Soma();
                        break;
                    case Menu.Subtracao:
                        Sub();
                        break;
                    case Menu.Divisao:
                        Div();
                        break;
                    case Menu.Multiplicacao:
                        Mult();
                        break;
                    case Menu.Potencia:
                        Pot();
                        break;
                    case Menu.Raiz:
                        Raiz();
                        break;
                    case Menu.Sair:
                        escolheuSair = true;
                        break;

                }

                Console.Clear(); //Limpa as informações do console quando chegar ao final do programa.

            }

        }
        static void Soma() //Cria a função Soma.
        {
            Console.WriteLine("Soma de dois números: ");
            Console.WriteLine("Digite o primeiro número: ");
            int a = int.Parse(Console.ReadLine()); //Cria a variavel "a", referente ao primeiro número.
            Console.WriteLine("Digite o segundo número: ");
            int b = int.Parse(Console.ReadLine()); //Cria a variavel "b", referente ao segundo número.
            int resultado = a + b;
            Console.WriteLine("O resultado é: " + resultado);
            Console.WriteLine("Aperte ENTER para voltar para o menu");
            Console.ReadLine();

        }
        static void Sub() //Cria a função Subtração.
        {
            Console.WriteLine("Subtração de dois números: ");
            Console.WriteLine("Digite o primeiro número: ");
            int a = int.Parse(Console.ReadLine()); //Cria a variavel "a", referente ao primeiro número.
            Console.WriteLine("Digite o segundo número: ");
            int b = int.Parse(Console.ReadLine()); //Cria a variavel "b", referente ao segundo número.
            int resultado = a - b;
            Console.WriteLine("O resultado é: " + resultado);
            Console.WriteLine("Aperte ENTER para voltar para o menu");
            Console.ReadLine();

        }
        static void Div() //Cria a função Divisão.
        {
            Console.WriteLine("Divisão de dois números: ");
            Console.WriteLine("Digite o primeiro número: ");
            int a = int.Parse(Console.ReadLine()); //Cria a variavel "a", referente ao primeiro número.
            Console.WriteLine("Digite o segundo número: ");
            int b = int.Parse(Console.ReadLine()); //Cria a variavel "b", referente ao segundo número.
            float resultado = (float)a/(float)b;
            Console.WriteLine("O resultado é: " + resultado);
            Console.WriteLine("Aperte ENTER para voltar para o menu");
            Console.ReadLine();

        }

        static void Mult() //Cria a função Multiplicação.
        {
            Console.WriteLine("Multiplicação de dois números: ");
            Console.WriteLine("Digite o primeiro número: ");
            int a = int.Parse(Console.ReadLine()); //Cria a variavel "a", referente ao primeiro número.
            Console.WriteLine("Digite o segundo número: ");
            int b = int.Parse(Console.ReadLine()); //Cria a variavel "b", referente ao segundo número.
            int resultado = a * b;
            Console.WriteLine("O resultado é: " + resultado);
            Console.WriteLine("Aperte ENTER para voltar para o menu");
            Console.ReadLine();

        }

        static void Pot() //Cria a função Potência.
        {
            Console.WriteLine("Potência de um número: ");
            Console.WriteLine("Digite a base: ");
            int baseNum = int.Parse(Console.ReadLine()); //Cria a variavel "baseNum", referente a base númerica.
            Console.WriteLine("Digite o expoente: ");
            int expo = int.Parse(Console.ReadLine()); //Cria a variavel "expo", referente ao expoente.
            int resultado = (int)Math.Pow(baseNum, expo);
            Console.WriteLine("O resultado é: " + resultado);
            Console.WriteLine("Aperte ENTER para voltar para o menu");
            Console.ReadLine();

        }

        static void Raiz() //Cria a função Raiz.
        {
            Console.WriteLine("Raiz de um número: ");
            Console.WriteLine("Digite o número: ");
            int a = int.Parse(Console.ReadLine()); //Cria a variavel "a", referente ao número em que se deseja saber a raiz.
            double resultado = Math.Sqrt(a);
            Console.WriteLine("O resultado é: " + resultado);
            Console.WriteLine("Aperte ENTER para voltar para o menu");
            Console.ReadLine();

        }
    }
}
