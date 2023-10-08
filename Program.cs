//Elaborador por: Anderson Dallmann
//Curso: Balta.io - Fundamentos C#
//Data: 08/10/2023

using System;

namespace Proj005
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu()
        {
            Cls();
            ShowScreen("****************************");
            ShowScreen("*        CALCULADORA       *");
            ShowScreen("*                          *");
            ShowScreen("*Elaborador por: Anderson  *");
            ShowScreen("*Data: 08/10/2023          *");
            ShowScreen("*Balta.io                  *");
            ShowScreen("****************************");
            ShowScreen("* 1 - SOMAR                *");
            ShowScreen("* 2 - SUBTRAIR             *");
            ShowScreen("* 3 - MULTIPLICAR          *");
            ShowScreen("* 4 - DIVIDIR              *");
            ShowScreen("* 5 - SAIR                 *");
            ShowScreen("****************************");
            short option = short.Parse(Console.ReadLine());

            switch (option)
            {
                case 1: Somar(); break;
                case 2: Subtrair(); break;
                case 3: Multiplicar(); break;
                case 4: Dividir(); break;
                case 5: System.Environment.Exit(0); break;//sai do sistema
                default: ShowScreen("Opção Invalida"); break;
            }

        }
        static void Cls()
        {
            Console.Clear();
        }

        static void ShowScreenl(string msgl) //esse método recebe e exibe o parâmetro recebido e pula uma linha
        {
            Console.Write(msgl);
        }

        static void ShowScreen(string msg) //esse método recebe e exibe o parâmetro recebido e pula uma linha
        {
            Console.WriteLine(msg);
        }

        static void Somar()
        {
            Cls();
            ShowScreen("****************************");
            ShowScreen("*        CALCULADORA       *");
            ShowScreen("*********   Somar   ********");
            ShowScreenl("* Digite 1º valor....: ");
            decimal num1 = decimal.Parse(Console.ReadLine());
            ShowScreenl("* Digite 2º valor....: ");
            decimal num2 = decimal.Parse(Console.ReadLine());
            ShowScreen("");
            decimal resultado = num1 + num2;
            ShowScreen("Resultado: " + (resultado));
            Console.ReadKey();
            Menu();
        }

        static void Subtrair()
        {
            Cls();
            ShowScreen("****************************");
            ShowScreen("*        CALCULADORA       *");
            ShowScreen("********* Subtrair  ********");
            ShowScreenl("* Digite 1º valor....: ");
            decimal sub1 = decimal.Parse(Console.ReadLine());
            ShowScreenl("* Digite 2º valor....: ");
            decimal sub2 = decimal.Parse(Console.ReadLine());
            decimal resultado = sub1 - sub2;
            ShowScreen("Resultado: " + (resultado));
            Console.ReadKey();
            Menu();
        }

        static void Multiplicar()
        {
            Cls();
            ShowScreen("****************************");
            ShowScreen("*        CALCULADORA       *");
            ShowScreen("*******  Multiplicar *******");
            ShowScreenl("* Digite 1º valor....: ");
            decimal mult1 = decimal.Parse(Console.ReadLine());
            ShowScreenl("* Digite 2º valor....: ");
            decimal mult2 = decimal.Parse(Console.ReadLine());
            decimal resultado = mult1 - mult2;
            ShowScreen("Resultado: " + (resultado));
            Console.ReadKey();
            Menu();
        }

        static void Dividir()
        {
            Cls();
            ShowScreen("****************************");
            ShowScreen("*        CALCULADORA       *");
            ShowScreen("*******    Dividir  ********");
            ShowScreenl("* Digite 1º valor....: ");
            decimal div1 = decimal.Parse(Console.ReadLine());
            ShowScreenl("* Digite 2º valor....: ");
            decimal div2 = decimal.Parse(Console.ReadLine());
            decimal div = div1 / div2;
            if (div < 0)
            {
                ShowScreen("Repita a operação!Divisão invalida!");
                Dividir();
            }
            else
            {
                ShowScreen("Resultado: " + (div));
            }
            Console.ReadKey();
            Menu();
        }

    }
}

