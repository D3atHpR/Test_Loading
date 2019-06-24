using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Ferramentatest
{
    class Program
    {
       // string opcao = " ";
        static DateTime Date = DateTime.Now;
        static void Main(string[] args)
        {
            Console.Title = " RAsPDeSK";
            Console.ForegroundColor = ConsoleColor.DarkBlue;        
Console.WriteLine(" ________");
Console.WriteLine("< hello! >");
Console.WriteLine(" --------");
Console.WriteLine("        |   ^__^");
Console.WriteLine("         |  (oo)________");
Console.WriteLine("            (__)        )\\");
Console.WriteLine("                ||----w |");
Console.WriteLine("                ||     ||");
            /* ___
< hello! >
 --------
        \   ^__^
         \  (oo)\_______
            (__)\       )\/\
                ||----w |
                ||     ||
             */
Console.SetCursorPosition(10, 10);
Console.WriteLine("Bem vindo ao RAsPDeSK ");
//Console.WriteLine(Date);
//Console.SetCursorPosition(10, 1);

            Console.SetCursorPosition(10,11);
            Console.WriteLine("By D3x");



           Console.CursorVisible = false;
           //Console.SetCursorPosition(10, 13);
            for (int i = 0; i <= 100; i++)
            {
                for (int y = 0; y < i; y++)
                {
                    Console.Write("."); 
                }
                Console.Write(i + "/100");
                    Console.SetCursorPosition(1,14 );
                System.Threading.Thread.Sleep(100);
            }
            Console.WriteLine("Perfeito");




            Console.ReadKey();
        
 
        
        
        }

    }
}
