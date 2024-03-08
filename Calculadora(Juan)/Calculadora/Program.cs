using System;

class Program
{
    static void Main()
    {
        char operador;
        double num1, num2, resultado=0;

        //Ingresa los valores numericos y el operador
        Console.WriteLine("Ingrese el primer Numero");
        num1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Ingresa la operacion (+,-,*,/)");
        operador = Convert.ToChar(Console.ReadLine());

        Console.WriteLine("Ingrese el Segundo Numero");
        num2 = Convert.ToDouble(Console.ReadLine());

        //Switch case para ejecutar una operacion
        switch (operador)
        {
            case '+':
                resultado = num1 + num2;
                break;
            case '-':
                resultado = num1 - num2;
                break;
            case '*':
                resultado = num1 * num2;
                break;
            case '/':
                if (num2 != 0)
                {
                    resultado = num1 / num2;
                }
                else
                {
                    //Evita que divida entre 0
                    Console.WriteLine("Error: Division de 0 no permitida");
                    Console.ReadLine();
                    return;
                }
                break;
            default:
                //Si el operador no esta permitido imprime eso
                Console.WriteLine("Operacion no definida, Pruebe de nuevo con otra Operacion permitida");
                Console.ReadLine();
                Main();
                return;
        }
        //Imprime operacion y resultado
        Console.WriteLine("Operacion:" + num1 + operador + num2);
        Console.WriteLine("Resultado:" + resultado);
        Console.ReadLine();
        Main();
    }
}
