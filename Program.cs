using System;

namespace LeetSpeak
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("---------------------------------");
            Console.WriteLine("|Digite uma frase para conversão|");
            Console.WriteLine("---------------------------------");
            Console.ResetColor();
            Console.WriteLine();
            string TextoUsuario =  Console.ReadLine();
            string NovaFrase =  TextoUsuario.Replace("A","4").Replace("E","3").Replace("I","1").Replace("O","0").Replace("S","5").Replace("T","7").Replace("a","4").Replace("e","3").Replace("i","1").Replace("o","0").Replace("s","5").Replace("t","7");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Red;       
            Console.WriteLine(NovaFrase);
            Console.ResetColor();
            
        }
    }
}
