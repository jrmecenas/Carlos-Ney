﻿using System;

namespace Atividade_de_Nota
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");
            /*  Programe...
                Exercícios valendo pontuação!
                1.Faça um Programa que peça dois números e imprima o maior deles.
                2.Faça um Programa que peça um valor e mostre na tela se o valor é positivo ou negativo.
                3.Faça um Programa que verifique se uma letra digitada é "F" ou "M".Conforme a letra escrever: F - Feminino, M - Masculino, Sexo Inválido.
                4.Faça um Programa que verifique se uma letra digitada é vogal ou consoante.
                5.Faça um Programa que leia três números e mostre o maior deles. */


            //Resolução da 1° questão.
            /*   int x1, x2;
               Console.Write("Digite aqui: ");
               x1 = int.Parse(Console.ReadLine());
               Console.Write("Digite aqui: ");
               x2 = int.Parse(Console.ReadLine());

               if (x1 > x2)
                   Console.WriteLine("O primeiro número é maior! "+x1);
               else
                   Console.WriteLine("O segundo número é maior! " + x2); */


            //Resolução da 2° questão.

            /* int x1;
             Console.Write("Digite aqui: ");
             x1 = int.Parse(Console.ReadLine());

             if(x1>=0)
                 Console.WriteLine("O Número digitado é positivo: "+x1);
             else
                 Console.WriteLine("O Número digitado não é positivo:" + x1); */

            //Resolução da 3° questão.

            /* string n1,n2;
             Console.Write("Digite F ou M: ");
             n1 = Console.ReadLine();
             n2 = n1.ToUpper();
             switch (n2)
             {
                 case "F": Console.WriteLine("É feminino: "); break;
                 case "M": Console.WriteLine("É Masculino: "); break;
                 default: Console.WriteLine("Letra Inválida "); break;
             }
             */

            //Resolução da 4° questão.

            /* string x1, x2;
             Console.Write("Digite aqui: ");
             x1 = Console.ReadLine();
             x2 = x1.ToUpper();

             if (x2 == "A" || x2 == "E" || x2 == "I" || x2== "O"||x2 == "U")
                 Console.WriteLine("É vogal: "+x2);
             else
                 Console.WriteLine("Não é vogal: " +x2); */


            //Resolução da 5° questão.

            /*int x1, x2, x3;
            Console.Write("Digite aqui: ");
            x1 = int.Parse(Console.ReadLine());
            Console.Write("Digite aqui: ");
            x2 = int.Parse(Console.ReadLine());
            Console.Write("Digite aqui: ");
            x3 = int.Parse(Console.ReadLine());

            if (x1 > x2 && x1 > x3)
                Console.WriteLine("O primeiro é maior: " + x1);
            if(x2>x1 && x2>x3)
                Console.WriteLine("O segundo é maior: "+x2);
            if(x3>x1 && x3>x2)
                Console.WriteLine("O terceiro é maior: "+x3);
            if(x1 > x2 && x2 == x3)
                Console.WriteLine("O primeiro é maior: " + x1 );
            if (x2 > x1 && x1 == x3)
                Console.WriteLine("O segundo é maior: " + x2);
            if (x3 > x1 && x1 == x2)
                Console.WriteLine("O Terceiro é maior: " + x3);
            else
                Console.WriteLine("Números iguais: ");  */

            //Resolução da 6°
             double x1, x2, media;
             Console.Write("Entre com a primera Nota: ");
             x1 = double.Parse(Console.ReadLine());
             Console.Write("Entre com a Segunda Nota: ");
             x2 = double.Parse(Console.ReadLine());
             media = (x1 + x2) / 2;

             if(media > 6 && media <= 9.99)
                 Console.WriteLine("Voçê foi Aprovado com média: "+media);
             else if(media == 10)
                 Console.WriteLine("Voçê foi Aprovado com Distinção: " + media ); 
              else
                 Console.WriteLine("Voçê foi Reprovado com media: " + media );    
             

            //Resolução da 7°

            /*  string n1, n2;
              Console.Write("Digite M-mautino V-vespertino e  N-noturno: ");
              n1 = Console.ReadLine();
              n2 = n1.ToUpper();
              switch (n2) {
                  case "M": Console.WriteLine("Bom Dia!"); break;
                  case "V": Console.WriteLine("Boa Tarde!");break;
                  case "N": Console.WriteLine("Boa Noite!");break;
                  default: Console.WriteLine("Letra Inválida!");break;

                 }*/

            // Resolução da 8°

            /* int ano;
             Console.Write("Digite aqui: ");
             ano = int.Parse(Console.ReadLine());
             if (ano % 4 == 0 && ano % 100 != 0)
                 Console.WriteLine("O ano é Bissexto: "+ano);
             else
                 Console.WriteLine("O ano não é Bissexto: " + ano); */

            // Resolução da 9°
           /* int x1;
            Console.Write("Digite Aqui: "  );
            x1 = int.Parse(Console.ReadLine());

            if(x1%2 ==0)
                Console.WriteLine("O Número é Par: "+x1);
            else
                Console.WriteLine("O Número é Ímpar: "+x1); */







        }

    }

    }