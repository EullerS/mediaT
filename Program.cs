using System;

namespace projeto22
{
    class Program
    {
        static void Main(string[] args)
        {
         string entrarMenu = null;
         string sairMenu = ("bem vindo ao menu principal digite media ou tendencia ");
         Console.WriteLine("Bem vindo ao menu principal digite media ou tendencia ");   
         var repetirLoop = true;

         while (repetirLoop) 
         {
            
            entrarMenu = Console.ReadLine();

            {
                switch (entrarMenu) 
                {
                    case "ajuda":
                        Console.WriteLine("Digite media, Para calcula a media de 2 numeros");
                        Console.WriteLine("tendencia, Para calcula a tendencia entre 3 numeros ");
                        Console.WriteLine("ou sair Para sair para o menu principal");
                        break;		

                    case "media":
                        Console.WriteLine("digite a primeira nota");   
                        var nota1  = Console.ReadLine();
                        var nota1num = Convert.ToDecimal(nota1);
                        Console.WriteLine("digite a segunda nota");
                        var nota2 = Console.ReadLine();
                        var nota2num = Convert.ToDecimal(nota2);
                        var soma = (nota1num + nota2num);
                        var media = (soma / 2);
                        Console.WriteLine("Resultado e " + media);
                        Console.WriteLine("digite tendencia ou sair ");
                        break;

                    case "tendencia":
                        Console.WriteLine("tendencia digite o primeiro numero");
                        var numero = Console.ReadLine();
                        var numeronum = Convert.ToDecimal(numero);
                        Console.WriteLine("tendencia digite o segundo numero");
                        var numero1 = Console.ReadLine();
                        var numero1num = Convert.ToDecimal(numero1);
                        Console.WriteLine("tendencia digite o terceiro numero");
                        var numero2 = Console.ReadLine();
                        var numero2num = Convert.ToDecimal(numero2);

                        if (numeronum <= numero1num && numero1num < numero2num)     
                        
                            Console.WriteLine("tendencia de alta");

                        else if(numeronum >= numero1num && numero1num > numero2num)     
                    
                            Console.WriteLine("tendencia de baixa");
                        else 
                            Console.WriteLine("sem tendencia");
                        
                        Console.WriteLine("digite media ou sair");
                        break;

                    case "sair":
                        var sair = sairMenu;
                        Console.WriteLine(sairMenu);
                        break;
                    }
                }
            }
        }
    }
}