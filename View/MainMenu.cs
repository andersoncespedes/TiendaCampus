using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace tienda.View;
    public class MainMenu
    {
        public int Menu(){
            Console.WriteLine("===============================");
            Console.WriteLine("\tMENU");
            Console.WriteLine("===============================");
            Console.WriteLine("1. Registrar Producto");
            Console.WriteLine("2. Registrar Categoria");
            Console.WriteLine("3. Listar Categorias");
            Console.WriteLine("4. Listar Productos");
            Console.WriteLine("5. Costo Total del Inventario");
            Console.WriteLine("6. Salir");
            Console.WriteLine();
            Console.Write("Digite Una Opcion -> ");
            return int.Parse(Console.ReadLine());
        }
    }
