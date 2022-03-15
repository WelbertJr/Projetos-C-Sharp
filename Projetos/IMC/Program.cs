using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Spectre.Console;

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

                var table = new Table();
                var panel = new Panel(table);
                panel.Border = BoxBorder.Rounded;

                table.Centered();
                table.AddColumn(new TableColumn(new Markup("[slowblink #87005f]Bem-vinda a calculadora de IMC![/]\n")));
                table.Columns[0].Centered();
                table.AddRow("[yellow]Atenção! Esta calculadora mede o IMC de pessoas acima de 18 anos.[/]\n");
                table.AddRow("[#5f87ff]Escolha uma opção abaixo:[/]\n");
                table.AddRow("[#5f87ff]1-Calcular o IMC de um paciente[/]\n");
                table.AddRow("[#5f87ff]2-Sair[/]");


                AnsiConsole.Write(table);

            
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
                            Console.WriteLine("[red]Essa opção não existe![/]\n");
                            Console.WriteLine("[yellow]Aperte ENTER para voltar para o menu[/]");
                            Console.ReadLine();
                            break;

                    }

                }
            Console.Clear();
            }
        }

        static void Calculo() 
        {

            AnsiConsole.Markup("[yellow]Digite o peso do paciente em KG: [/]");
            float a = float.Parse(Console.ReadLine());
            AnsiConsole.Markup("[yellow]Digite a altura do paciente em metros: [/]");
            float b = float.Parse(Console.ReadLine());
            float resultado = a / (float)Math.Pow(b, 2);
            if (resultado <= 18.5)
            {
                AnsiConsole.Markup("\n[red]O IMC do paciente é: " + Math.Round(resultado, 1).ToString() + ", e ele tem o peso abaixo do normal :([/]\n\n");
            }
            else if ((resultado > 18.5) && (resultado < 25))
            {
                AnsiConsole.Markup("\n[green]O IMC do paciente é: " + Math.Round(resultado, 1).ToString() + ", e ele tem o peso ideal :)[/]\n\n");
            }
            else if ((resultado >= 25) && (resultado < 30))
            {
                AnsiConsole.Markup("\n[red]O IMC do paciente é: " + Math.Round(resultado, 1).ToString() + ", e ele está sobre o peso ideal :(\n\n[/]");
            }
            else if ((resultado >= 30) && (resultado < 35))
            {
                AnsiConsole.Markup("\n[red]O IMC do paciente é: " + Math.Round(resultado, 1).ToString() + ", e ele possui obesidade de grau I :(\n\n[/]");
            }
            else if ((resultado >= 35) && (resultado < 40))
            {
                AnsiConsole.Markup("\n[red]O IMC do paciente é: " + Math.Round(resultado, 1).ToString() + ", e ele possui obesidade de grau II! :(\n\n[/]");
            }
            else if (resultado >= 40)
            {
                AnsiConsole.Markup("\n[red]O IMC do paciente é: " + Math.Round(resultado, 1).ToString() + ", e ele possui obesidade de grau III! :(\n\n[/]");
            }
            AnsiConsole.Markup("[yellow]Aperte ENTER para voltar para o menu![/]");
            Console.ReadLine();

        }
      }
    }

           
