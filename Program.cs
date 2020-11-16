using System;

namespace Swicth_Case
{
    class Program
    {
        static void Main(string[] args)
        {   
            Console.WriteLine("Digite o tipo de operação");
            string operaçao = Console.ReadLine();
            
            Console.WriteLine("Digite o 1° número");
            float num1 =float.Parse(Console.ReadLine());
            
            Console.WriteLine("Digite o 2° número");
            float num2 =float.Parse(Console.ReadLine());

            float resultado =0;

           switch(operaçao){
            
            case "Soma":
            resultado = num1+num2;
            break;
            
            case "Subtração":
            resultado = num1-num2;
            break;
            
            case "Multiplicação":
            resultado = num1*num2;
            break;
            
            case "Divisão":
            resultado = num1/num2;
            break;

            default:
            Console.WriteLine("Operação inválida");
            break;
            }

            

        }
    }
}
