using System;

class Program
{
    static void Main()
    {
        System.Console.ForegroundColor = ConsoleColor.Green;
        char operador, procedimiento, cont;
        double num1, num2, num3, resultado = 0, restemp = 0;
        //Ingresa la forma a calcular
        Console.Write("Utiliza unicamente MAYUSCULAS\n");
        Console.Write("Ingresa la operacion (C,R,T,O)\n");
        operador = Convert.ToChar(Console.ReadLine());

        switch (operador)
        {
            //Si es Cubo pide solo el lado y seleccionar que calcular si area o perimetro
            case 'C':
                try
                {
                    Console.WriteLine("Ingrese el lado del Cadrado\n");
                    num1 = Double.Parse(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Ingrese el lado del Cuadrado");
                    num1 = Double.Parse(Console.ReadLine());
                }
                Console.Write("Ingresa la operacion Area o Perimetro (A,P)\n");
                procedimiento = Convert.ToChar(Console.ReadLine());
                switch (procedimiento)
                {
                    //Calcula area
                    case 'A':
                        resultado = num1 * num1;
                        break;
                    //Calcula perimetro
                    case 'P':
                        resultado = num1 + num1 + num1 + num1;
                        break;
                }
                break;
            //Si es Rectangulo pide alto y largo y seleccionar que calcular si area o perimetro
            case 'R':
                try
                {
                    Console.WriteLine("Ingrese La Base\n");
                    num1 = Double.Parse(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Ingrese La Base (Numero)\n");
                    num1 = Double.Parse(Console.ReadLine());
                }
                try
                {
                    Console.WriteLine("Ingrese La Altura\n");
                    num2 = Double.Parse(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Ingrese La Altura(Numero)\n");
                    num2 = Double.Parse(Console.ReadLine());
                }
                Console.Write("Ingresa la operacion Area o Perimetro (A,P)\n");
                procedimiento = Convert.ToChar(Console.ReadLine());
                switch (procedimiento)
                {
                    //Calcula area
                    case 'A':
                        resultado = num1 * num2;
                        break;
                    //Calcula perimetro
                    case 'P':
                        resultado = num1 + num2 + num1 + num2;
                        break;
                }
                break;
            //Si es Triangulo pide 3 o 2 lados dependiendo y seleccionar que calcular si area o perimetro
            case 'T':
                Console.Write("Ingresa la operacion Area o Perimetro (A,P)\n");
                procedimiento = Convert.ToChar(Console.ReadLine());
                switch (procedimiento)
                {
                    //Calcula area
                    case 'A':
                        try
                        {
                            Console.WriteLine("Ingrese La Base\n");
                            num1 = Double.Parse(Console.ReadLine());
                        }
                        catch
                        {
                            Console.WriteLine("Ingrese La Base(Numero)\n");
                            num1 = Double.Parse(Console.ReadLine());
                        }
                        try
                        {
                            Console.WriteLine("Ingrese La Altura\n");
                            num2 = Double.Parse(Console.ReadLine());
                        }
                        catch
                        {
                            Console.WriteLine("Ingrese La Altura(Numero)\n");
                            num2 = Double.Parse(Console.ReadLine());
                        }
                        resultado = num1 * num2 / 2;
                        break;
                    //Calcula perimetro
                    case 'P':
                        try
                        {
                            Console.WriteLine("Ingrese el Primer Lado\n");
                            num1 = Double.Parse(Console.ReadLine());
                        }
                        catch
                        {
                            Console.WriteLine("Ingrese el Primer Lado(Numero)\n");
                            num1 = Double.Parse(Console.ReadLine());
                        }
                        try
                        {
                            Console.WriteLine("Ingrese el Segundo Lado\n");
                            num2 = Double.Parse(Console.ReadLine());
                        }
                        catch
                        {
                            Console.WriteLine("Ingrese el Segundo Lado(Numero)\n");
                            num2 = Double.Parse(Console.ReadLine());
                        }
                        try
                        {
                            Console.WriteLine("Ingrese el Tercer Lado\n");
                            num3 = Double.Parse(Console.ReadLine());
                        }
                        catch
                        {
                            Console.WriteLine("Ingrese el Tercer Lado(Numero)\n");
                            num3 = Double.Parse(Console.ReadLine());
                        }
                        resultado = num1 + num2 + num3;
                        break;
                }
                break;
            //Si es circulO pide solo el Radio y seleccionar que calcular si area o perimetro
            case 'O':
                try
                {
                    Console.WriteLine("Ingrese el Radio del Circulo\n");
                    num1 = Double.Parse(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Ingrese el Radio del Circulo(Numero)\n");
                    num1 = Double.Parse(Console.ReadLine());
                }
                Console.Write("Ingresa la operacion Area o Perimetro (A,P)\n");
                procedimiento = Convert.ToChar(Console.ReadLine());
                switch (procedimiento)
                {
                    //Calcula area
                    case 'A':
                        restemp = num1 * num1;
                        resultado = 3.14 * restemp;
                        break;
                    //Calcula perimetro
                    case 'P':
                        resultado = 2 * 3.14 * num1;
                        break;
                }
                break;
            default:
                //Si se pide una operacion inexistente
                Console.WriteLine("Operacion no definida, Pruebe de nuevo con otra Operacion permitida\n");
                Console.ReadLine();
                Main();
                return;
        }
        //Imprime el resultado
        Console.WriteLine("Resultado:" + resultado);
        Console.ReadLine();

        Console.Write("Quieres intentar de nuevo (S/N)\n");
        cont = Convert.ToChar(Console.ReadLine());
        //Vuelve a empezar
        switch (cont)
        {
            case 'S':
                Main();
                break;
            case 'N':
                break;
        }
    }
}