namespace Ejercicio2
{
    class CALCULO
    {
        static void Main(string[] args)
        {
            int a = 0, b = 0, resultado, buscar;
            double A, B, C, RESULTADO;
            bool Booleano;
            Calculadora calculadora = new Calculadora();

            Console.WriteLine("Ingrese numero para sumar: ");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese numero para sumar: ");
            b = int.Parse(Console.ReadLine());
 
            resultado = calculadora.Sumar(a, b);
            Console.WriteLine($"El resultado es: {resultado}");

            Console.WriteLine("Ingrese numero para sumar: ");
            A = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese numero para sumar: ");
            B = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese numero para sumar: ");
            C = double.Parse(Console.ReadLine());

            RESULTADO = calculadora.Sumar3(A, B, C);
            Console.WriteLine($"El resultado es: {RESULTADO}");

            calculadora.Sumar_Mensajes();
            Console.WriteLine("Ingrese un numero para saber si es par o impar: ");
            buscar = int.Parse(Console.ReadLine());
            Booleano = calculadora.Par_Impar(buscar);
            Console.WriteLine($"El numero {buscar} es {Booleano}");
            Console.WriteLine("FIN");
            
        }
    }
    class Calculadora
    {
        public int Sumar(int a, int b)
        {
            return a + b;
        }
        public double Sumar3(double A, double B, double C)
        {
            return A + B + C;
        }
        public void Sumar_Mensajes() {
            string mensaje;
            int numero_A, numero_B, resultado;
            Console.WriteLine("Ingrese mensaje: ");
            mensaje = Console.ReadLine();
            Console.WriteLine("Ingrese numero: ");
            numero_A=int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese numero: ");
            numero_B = int.Parse(Console.ReadLine());
            resultado =numero_A +numero_B;
            Console.WriteLine($"El mensaje es: {mensaje}");
            Console.WriteLine($"La suma es {resultado}");
        }
        public bool Par_Impar(int buscar)
        {
            bool respuesta;
            if (buscar % 2 == 0) {
                return respuesta =true;
            }
            else
            {
                return respuesta = false;
            }
        }
    }
}