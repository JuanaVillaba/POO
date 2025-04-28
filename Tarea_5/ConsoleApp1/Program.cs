namespace ConsoleApp1
{   class Producto
    {
        public int ganancia;
        public int Total_stock=0;
        static void Main(string[] args)
        {
            Producto producto = new Producto();
            string opcion, validar;
            Bebida bebida = new Bebida();
            Alimento alimento = new Alimento();
            Console.WriteLine("Bienvenidos al supermercado Eureka");
            Console.WriteLine("¿Que producto desearia comprar?");
            Console.WriteLine("[A] Alimento");
            Console.WriteLine("[B] Bebida");
            opcion =Console.ReadLine();
            if (opcion == "A" || opcion == "a")
            {
                Console.WriteLine("A comprado una alimento");
                alimento.A_Stock();
                producto.Total_stock += 1;
                alimento.papas_ganancia += alimento.A_Venta();
                producto.ganancia += alimento.papas_ganancia;
            }
            else
            {
                Console.WriteLine("A comprado un bebida");
                bebida.B_stock();
                bebida.jugo_ganancia += bebida.B_venta();
                producto.ganancia += bebida.jugo_ganancia;
                producto.Total_stock += 1;
            }
            Console.WriteLine("¿Le gustaria comprar algo mas?");
            Console.WriteLine("[S] Si o [N] NO");
            validar = Console.ReadLine();
            while (validar == "S" || validar == "s")
            {
                Console.WriteLine("¿Que producto desearia comprar?");
                Console.WriteLine("[A] Alimento");
                Console.WriteLine("[B] Bebida");
                opcion = Console.ReadLine();
                if (opcion == "A" || opcion == "a")
                {
                    Console.WriteLine("A comprado una alimento");
                    alimento.A_Stock();
                    producto.Total_stock += 1;
                    alimento.papas_ganancia += alimento.A_Venta();
                    producto.ganancia += alimento.papas_ganancia;
                }
                else
                {
                    Console.WriteLine("A comprado un bebida");
                    bebida.B_stock();
                    producto.Total_stock += 1;
                    bebida.jugo_ganancia += bebida.B_venta();
                    producto.ganancia += bebida.jugo_ganancia;
                }
                Console.WriteLine("¿Le gustaria comprar algo mas?");
                Console.WriteLine("[S]Si o [N] NO");
                validar = Console.ReadLine();
            }
            Console.WriteLine($"El total de ganancia es: {producto.ganancia} y se vendieron unos {producto.Total_stock} productos");
            Console.WriteLine($"Quedan de stock {alimento.papas_stock} de alimento y su ganancia fue de {alimento.papas_ganancia}");
            Console.WriteLine($"Quedan de stock {bebida.jugo_stock} de bebidas y su ganancia fue de {bebida.jugo_ganancia}");
        }
    }
    class Bebida : Producto {

        public int jugo_stock= 5;
        public int jugo_precio = 800;
        public int jugo_ganancia;
        public int B_venta() {
            Producto producto = new Producto();
            producto.ganancia += jugo_precio;
            return jugo_precio;
        }
        public void B_stock() {
            jugo_stock -= 1;
        }
    }
    class Alimento : Producto {
        public int papas_stock = 5;
        public int papas_precio = 2200;
        public int papas_ganancia;
        public int A_Venta() {
            Alimento alimento = new Alimento();
            Producto producto = new Producto();
            producto.ganancia += papas_precio;
            alimento.papas_ganancia += papas_precio;
            return papas_precio;
        }
        public void A_Stock() {
            papas_stock -= 1;
        }
    }
}
