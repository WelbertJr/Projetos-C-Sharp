using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IMC
{
    internal class Program
    {
        enum Menu { CalcularImc =1, Sair }
        static void Main(string[] args)

        {
            bool escolheusair = false;
            while (!escolheusair)
            {
                Console.WriteLine("Bem-vinda a calculadora de IMC!\n");
                Console.WriteLine("Atenção! Esta calculadora mede o IMC de pessoas acima de 18 anos.");
                Console.WriteLine("Escolha uma opção abaixo:");
                Console.WriteLine("1-Calcular o IMC de um paciente\n2-Sair");
                
                
                {
                    Menu opcao = (Menu)int.Parse(Console.ReadLine());
                    switch (opcao)
                    {
                        case Menu.CalcularImc:
                            Calculo();
                            break;                  
                        case Menu.Sair:
                            escolheusair = true;
                            break;
                        default:
                            Console.WriteLine("Essa opção não existe!\n");
                            Console.WriteLine("Aperte ENTER para voltar para o menu");
                            Console.ReadLine();
                            break;

                    }

                }
            Console.Clear();
            }
        }

        static void Calculo() 
        {
            Console.WriteLine("Digite o peso do paciente em KG: ");
            float a = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite a altura do paciente em metros: ");
            float b = float.Parse(Console.ReadLine());
            float resultado = a / (float)Math.Pow(b, 2);
            if (resultado <= 18.5)
            {
                Console.WriteLine("O IMC do paciente é: " + Math.Round(resultado, 1).ToString() + " e ele tem o peso abaixo do normal :(");
            }
            else if ((resultado > 18.5) && (resultado < 25))
            {
                Console.WriteLine("O IMC do paciente é: " + Math.Round(resultado, 1).ToString() + " e ele tem o peso ideal :)");
            }
            else if ((resultado >= 25) && (resultado < 30))
            {
                Console.WriteLine("O IMC do paciente é: " + Math.Round(resultado, 1).ToString() + " e ele está sobre o peso ideal :(");
            }
            else if ((resultado >= 30) && (resultado < 35))
            {
                Console.WriteLine("O IMC do paciente é: " + Math.Round(resultado, 1).ToString() + " e ele possui obesidade de grau I :(");
            }
            else if ((resultado >= 35) && (resultado < 40))
            {
                Console.WriteLine("O IMC do paciente é: " + Math.Round(resultado, 1).ToString() + " e ele possui obesidade de grau II! :(");
            }
            else if (resultado >= 40)
            {
                Console.WriteLine("O IMC do paciente é: " + Math.Round(resultado, 1).ToString() + " e ele possui obesidade de grau III! :(");
            }
            Console.WriteLine("Aperte ENTER para voltar para o menu");
            Console.ReadLine();

        }
      }
    }
