using System;

namespace Ejercicio1
{
    class Vehiculo
    {
        public string Marca;
        public string Modelo;
        public int año;
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Auto auto = new Auto();
            auto.Marca = "Toyota";
            auto.Modelo = "Corolla";
            auto.año = 2022;
            Camioneta camioneta = new Camioneta();
            camioneta.Marca = "Fiat";
            camioneta.Modelo = "Toro SUV";
            camioneta.año = 2019;
            Moto moto = new Moto();
            moto.Marca = "Rouser";
            moto.Modelo = "N 250";
            moto.año = 2024;

            auto.A_Datos();
            auto.MostrarInformacion(auto.Marca,auto.Modelo,auto.año);
            auto.CambiarMarcha();

            camioneta.C_Datos();
            camioneta.MostrarInformacion(camioneta.Marca,camioneta.Modelo,camioneta.año);
            camioneta.CambiarMarcha();

            moto.M_Datos();
            moto.MostrarInformacion(moto.Marca,moto.Modelo,moto.año);
            moto.CambiarMarcha();

            Console.WriteLine("Fin");
        }
        public void CambiarMarcha() {
            Console.WriteLine("Se cambio la marcha");
        }

        public void MostrarInformacion(string marca, string modelo, int año)
        {
            this.Marca = Marca;
            Console.WriteLine($"La marca del vehiculo es {this.Marca} modelo {modelo} del año {año}");

        }
    }
    class Auto :Vehiculo {
        public int A_cantidad_puertas=4;
        public bool es_Automatico = true;
        
        public void A_Datos() {
           
            Console.WriteLine($"El auto tiene cantidad de puertas es: {A_cantidad_puertas} y su estado de automatico es: {es_Automatico}");
        }
    }
    class Camioneta :Vehiculo {
        public int C_cantidad_puertas =6;
        public bool es4x4 = false;
        public void C_Datos() {
            Console.WriteLine($"La camioneta tiene cantidad de puertas es: {C_cantidad_puertas} y su estado de 4x4 es: {es4x4}");
        }
    }
    class Moto :Vehiculo {
        public string tipo_manubrio = "Murcielago";
        public void M_Datos(){
            Console.WriteLine($"La moto tiene un tipo de manubrio: {tipo_manubrio}");
        }
    }
}


//1) Crear la clase Vehiculo que contenga marca, modelo y anio.
//Debe tener los métodos:
//CambiarMarcha()(simplemente un texto que informe el cambio de marcha)
//MostrarInformacion()
//Luego, crear tres clases que hereden de Vehiculo Auto, Camioneta, Moto
//Agregar propiedades específicas:
//Auto: CantidadPuertas, esAutomatico(booleano)
//Moto: TipoManubrio
//Camioneta: cantidadPuertas, es4x4(booleano)
//Se deben instanciar en el Main, creando un objeto de cada clase hija y llamar a sus métodos.


