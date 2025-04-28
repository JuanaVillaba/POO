using System;

namespace Ejercicio1 {
 class Program
    {
        public static void Main(string[] args)
        {
            Persona p1 = new Persona("Boomer", 5, 45152666);
            Persona p2 = new Persona("Lola");
            Persona p3 = new Persona();
            p1.MostrarDatos(p1.nombre, p1.GetEdad(), p1.dni);
            p2.MostrarDatos(p2.nombre, p2.GetEdad(), p2.dni);
            p3.MostrarDatos(p3.nombre, p3.GetEdad(), p3.dni);
            p1.setEdad(p1.nombre, p1.GetEdad());
            p2.setEdad(p2.nombre, p2.GetEdad());
            p3.setEdad(p3.nombre, p3.GetEdad());
            p1.MostrarDatos(p1.nombre, p1.GetEdad(), p1.dni);
            p2.MostrarDatos(p2.nombre, p2.GetEdad(), p2.dni);
            p3.MostrarDatos(p3.nombre, p3.GetEdad(), p3.dni);
        }
 }
 class Persona
    {
        public string nombre;
        private int edad;
        public int dni;

        public Persona(string nombre, int edad, int dni)
        {
            this.nombre = nombre;
            this.edad = edad;
            this.dni = dni;
        }
        public Persona(string nombre)
        {
            this.nombre = nombre;
            this.edad = 1;
            this.dni = 11111111;
        }
        public Persona()
        {
            this.nombre = "Sin nombre";
            this.edad = 0;
            this.dni = 00000000;
        }
        public void MostrarDatos(string nombre, int edad, int dni)
        {
            Console.WriteLine($"{nombre} {edad} {dni}");
        }
        public int GetEdad()
        {
            return edad;
        }
        public int setEdad(string nombre, int edad)
        {
            int nueva_edad;
            Console.WriteLine($"Ingrese la nueva edad de {nombre}:");
            nueva_edad = int.Parse(Console.ReadLine());
            return this.edad = nueva_edad;
        }
 }
}