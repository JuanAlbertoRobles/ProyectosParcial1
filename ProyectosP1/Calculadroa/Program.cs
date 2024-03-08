using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //se definen  las variables 
            char operador;
            double num1, num2, resultado = 0;

            //se pide y se lee lo ingresado por el usuario
            Console.WriteLine("Ingrese la operacion a realizar: ");
            Console.WriteLine("<+> Suma");
            Console.WriteLine("<-> Resta");
            Console.WriteLine("<*> Multiplicacion");
            Console.WriteLine("</> Division");
            Console.Write("Operacion seleccionada: ");
            operador = Convert.ToChar(Console.ReadLine());

            //evalua los patrones
            switch (operador)
            {
                //devulve el valor de +
                case '+':
                        try
                    {
                        // se pide y se lee lo ingresado por el usuario
                        Console.Write("Ingrese el primer numero: ");
                        num1 = double.Parse(Console.ReadLine());
                        Console.Write("Ingrese el segundo numero: ");
                        num2 = double.Parse(Console.ReadLine());
                        //se suman los dos numeros ingresados por el usuario
                        resultado = num1 + num2;


                    }
                    catch
                    {
                        // se pide que se ingrese un valor valido
                        Console.WriteLine("Ingrese un valor valido:");
                        // regresa al case de +
                        goto case '+';

                    }
                    //rompe el ciclo
                    break;;

                case '-':
                    try
                    {
                        // se pide y se lee lo ingresado por el usuario
                        Console.Write("Ingrese el primer numero: ");
                        num1 = double.Parse(Console.ReadLine());
                        Console.Write("Ingrese el segundo numero: ");
                        num2 = double.Parse(Console.ReadLine());
                        //se realiza la resta de los numeros ingresadops 
                        resultado = num1 - num2;


                    }
                    catch
                    {
                        // se pide que se ingrese un valor valido
                        Console.WriteLine("Ingrese un valor valido:");
                        goto case '-';

                    }
                    break;

                case '*':
                    try
                    {
                        // se pide y se lee lo ingresado por el usuario
                        Console.Write("Ingrese el primer numero: ");
                        num1 = double.Parse(Console.ReadLine());
                        Console.Write("Ingrese el segundo numero: ");
                        num2 = double.Parse(Console.ReadLine());
                        //se realiza la multiplicaion de los numeros ingresadops
                        resultado = num1 * num2;


                    }
                    catch
                    {
                        // se pide que se ingrese un valor valido
                        Console.WriteLine("Ingrese un valor valido:");
                        goto case '*';

                    }
                    break;

                case '/':
                    try
                    {
                        // se pide y se lee lo ingresado por el usuario
                        Console.Write("Ingrese el primer numero: ");
                        num1 = double.Parse(Console.ReadLine());
                        Console.Write("Ingrese el segundo numero: ");
                        num2 = double.Parse(Console.ReadLine());
                        //si el numero 2 es diferente a 0 se realiza la divicion de los numeros ingresadops
                        if (num2 != 0)
                        {
                            resultado = num1 / num2;
                        }
                        else
                        {
                            // se pide que se ingrese un valor valido
                            Console.WriteLine("Ingrese un valor valido:");
                            goto case '/';
                        }


                    }
                    catch
                    {
                        // se pide que se ingrese un valor valido
                        Console.WriteLine("Ingrese un valor valido:");
                        goto case '/';

                    }
                    break;
            }

            
            //se imprime el resuktado de la operacion
            Console.WriteLine(" El resultado es " + resultado);
            Console.ReadLine();

        }
    }
}