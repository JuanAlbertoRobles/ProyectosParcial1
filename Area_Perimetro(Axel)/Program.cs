using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Figuras
{
    class Program
    {
        static void Main(string[] args)
        {
            //se definen las variables
            char operador, procedimineto;
            double num1=0, num2=0,num3, resultado = 0;

            // Se piede y guarda lo escrito por el usuario
            Console.WriteLine("Seleccione la figura ");
            Console.WriteLine("<C> Cuadrado ");
            Console.WriteLine("<R> Reactangulo ");
            Console.WriteLine("<T> Triangulo ");
            Console.WriteLine("<E> Circulo ");
            Console.Write("Figura seleccionada: ");
            operador = Convert.ToChar(Console.ReadLine());

            // Se evalua los ingresado
            switch (operador)
            {
                // Si es C se ejecuta
                case 'C':
                    // Se pide y guarda lo ungresado por el usuario
                    Console.WriteLine("Que desea obtener: ");
                    Console.WriteLine("<A> Area ");
                    Console.WriteLine("<P> Perimetro ");
                    Console.Write("Se obtendra: ");
                    procedimineto = Convert.ToChar(Console.ReadLine());
                    // Se evalua los ingresado
                    switch (procedimineto)
                    {
                        // Si es a se ejcuta
                        case 'A':
                            try
                            {
                                // se guarda lo ingresado por el usuario
                                Console.Write("Ingrese el lado del cuadrado: ");
                                num1 = double.Parse(Console.ReadLine());
                                // Se realiza una operacion para sacar el resultado
                                resultado = num1 * num1;
                            }
                            catch
                            {
                                //se piede que ingrese un valor valio en caso de no ser un numero
                                Console.WriteLine("Ingrese un valor valido");
                                goto case 'A';
                            }
                        break;
                               
                        case 'P':
                            try
                            {
                                //guarda lo ingresado por el usuario
                                Console.Write("Ingrese el lado del cuadrado: ");
                                num1 = double.Parse(Console.ReadLine());
                                //se saca el resultadp
                                resultado = num1 + num1 + num1 + num1;
                            }
                            catch
                            {
                                //se piede que ingrese un valor valido
                                Console.WriteLine("Ingrese un valor valido");
                                goto case 'P';
                            }
                        break;
                    }
                    break;

                case 'R':
                    //guarda lo ingresado por el usuario
                    Console.WriteLine("Que desea obtener: ");
                    Console.WriteLine("<A> Area ");
                    Console.WriteLine("<P> Perimetro ");
                    Console.Write("Se obtendra: ");
                    procedimineto = Convert.ToChar(Console.ReadLine());

                    switch (procedimineto)
                    {
                        case 'A':
                            try

                            {
                                //guarda lo ingresado por el usuario
                                Console.Write("Ingrese la base del rectangulo: ");
                                num1 = double.Parse(Console.ReadLine());
                                Console.Write("Ingrese el lado del rectangulo: ");
                                num2 = double.Parse(Console.ReadLine());
                                // se saca la operacion
                                resultado = num1 * num2;
                            }
                            catch
                            {
                                //se pide que ingrese un valor valido
                                Console.WriteLine("Ingrese un valor valido");
                                goto case 'A';
                            }
                            break;

                        case 'P':
                            try
                            {
                                //guarda lo ingresado por el usuario
                                Console.Write("Ingrese la base del rectangulo: ");
                                num1 = double.Parse(Console.ReadLine());
                                Console.Write("Ingrese el lado del rectangulo: ");
                                num2 = double.Parse(Console.ReadLine());
                                //se saca el resultado
                                resultado = num1 + num1 + num2 + num2;
                            }
                            catch
                            {
                                // se piede que ingrese un valor valido
                                Console.WriteLine("Ingrese un valor valido");
                                goto case 'P';
                            }
                            break;
                    }
                    break;

                case 'T':
                    //guarda lo ingresado por el usuario
                    Console.WriteLine("Que desea obtener: ");
                    Console.WriteLine("<A> Area ");
                    Console.WriteLine("<P> Perimetro ");
                    Console.Write("Se obtendra: ");
                    procedimineto = Convert.ToChar(Console.ReadLine());
                    switch (procedimineto)
                    {
                        case 'A':
                            try
                            {
                                //guarda lo ingresado por el usuario
                                Console.Write("Ingrese la base del triangulo: ");
                                num1 = double.Parse(Console.ReadLine());
                                Console.Write("Ingrese la altura del triangulo: ");
                                num2 = double.Parse(Console.ReadLine());
                                resultado = num1 * num2 / 2;
                            }
                            catch
                            {
                                Console.WriteLine("Ingrese un valor valido");
                                goto case 'A';
                            }
                            break;

                        case 'P':
                            try
                            {
                                //guarda lo ingresado por el usuario
                                Console.Write("Ingrese la base del triangulo: ");
                                num1 = double.Parse(Console.ReadLine());
                                Console.Write("Ingrese lado del triangulo: ");
                                num2 = double.Parse(Console.ReadLine());
                                Console.Write("Ingrese lado del triangulo: ");
                                num3 = double.Parse(Console.ReadLine());
                                resultado = num1 + num2 + num3;
                            }
                            catch
                            {
                                Console.WriteLine("Ingrese un valor valido");
                                goto case 'P';
                            }
                            break;
                    }
                    break;

                case 'E':
                    //guarda lo ingresado por el usuario
                    Console.WriteLine("Que desea obtener: ");
                    Console.WriteLine("<A> Area ");
                    Console.WriteLine("<P> Perimetro ");
                    Console.Write("Se obtendra: ");
                    procedimineto = Convert.ToChar(Console.ReadLine());
                    switch (procedimineto)
                    {
                        case 'A':
                            try
                            {
                                //guarda lo ingresado por el usuario
                                Console.Write("Ingrese el radio del circulo: ");
                                num1 = double.Parse(Console.ReadLine());
                                resultado = 3.14 * num1* num1;
                            }
                            catch
                            {
                                Console.WriteLine("Ingrese un valor valido");
                                goto case 'A';
                            }
                            break;
                        case 'P':
                            try
                            {
                                //guarda lo ingresado por el usuario
                                Console.Write("Ingrese el radio del circulo: ");
                                num1 = double.Parse(Console.ReadLine());
                                resultado = 2 * 3.14 * num1;
                            }
                            catch
                            {
                                //guarda lo ingresado por el usuario
                                Console.WriteLine("Ingrese un valor valido");
                                goto case 'P';
                            }
                            break;
                    }
                    break;

            }
            //se imprime el resultado de lo solicitado
            Console.WriteLine(" El resultado es " + resultado);
            Console.ReadLine();
        }
    }
}
