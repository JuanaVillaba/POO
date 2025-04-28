namespace Ejercicio_2
{
    class Persona
    {
        public string nombre;
        private int edad;
        public int dni;

        Persona(){
            this.nombre ="Sin nombre";
            this.edad =0;
            this.dni = 0;
        }
        Persona(string nombre, int edad) {
            this.nombre = nombre;
            this.edad = edad;
            this.dni = 0;
        }
        Persona(string nombre, int edad, int dni) {
            this.nombre = nombre;
            this.edad = edad;
            this.dni = dni;
        }
        public void MostrarInformacion(string NOMBRE, int EDAD, int DNI) {
            
            Console.WriteLine($"Nombre: {NOMBRE} Edad: {EDAD} DNI: {DNI}");
        }

        static void Main(string[] args)
        {
            Persona p1 = new Persona("Bizcocho",3,45152666);
            Persona p2 = new Persona("Lola",4);
            Persona p3 = new Persona();

            p1.MostrarInformacion(p1.nombre,p1.edad,p1.dni);
            p2.MostrarInformacion(p2.nombre,p2.edad,p2.dni);
            p3.MostrarInformacion(p3.nombre,p3.edad,p3.dni);

            Console.WriteLine("Fin");
        }
    }
}
// Crear la clase Persona con los siguientes atributos:
//nombre
//private edad
//DNI
//Método:
//MostrarInformación() que imprima por consola los tres atributos.
// Crear 3 constructores:
//Uno vacío.
//Uno que reciba por parametro el nombre y la edad.
//Uno que reciba el nombre, la edad y el DNI.
//En el Main:
//Crear tres objetos de Persona usando los distintos constructores y mostrar los valores de sus
//propiedades con el método MostrarInformación().

