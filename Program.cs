using System;

namespace tradutorLeet
{
    class Program
    {
        static void Main(string[] args)
        {

         string frase;
         string tecla="";

            do
              {
               Console.Clear();

               Console.WriteLine("       +-------------+");
               Console.WriteLine("       |TRADUTOR LEET|");
               Console.WriteLine("       +-------------+");

               Console.WriteLine("Qual a frase a ser traduzida?");
               frase = Console.ReadLine()
               .ToUpper()
               .Replace("A", "4")
               .Replace("T", "7")
               .Replace("O", "0")
               .Replace("S", "5")
               .Replace("I", "1")
               .Replace("L", "1");
               
               Console.WriteLine("\nSua frase em LEET fica:");
               Console.WriteLine(frase);
            
               Console.WriteLine("\n Sair? (S)");
               tecla = Console.ReadLine().ToUpper();
              }
            while(tecla != "S");
         Console.Clear();    

        }
    }
}
 
