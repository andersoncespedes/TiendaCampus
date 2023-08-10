using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace tienda.Clases;

    public class Producto
    {
        public string CodProducto {get; set;}
        public string Nombre {get; set;}
        public int Stock {get; set;}
        public int StockMin {get; set;}

        public int StockMax {get; set;}
        public double PrecioVenta {get; set;}
        public double PrecioCompra {get; set;}
        public int IdCategoria {get; set;}
        public Producto(string codProducto, string nombre, int stock, int stockMin, int stockMax, double precioVenta, double precioCompra, int idCategoria){
            CodProducto = codProducto;
            Nombre = nombre;
            Stock = stock;
            StockMin = stockMin;
            StockMax = stockMax;
            PrecioVenta = precioVenta;
            PrecioCompra = precioCompra;
            IdCategoria = idCategoria;
        }
        public Producto(){

        }
        public void Guardar(List<Producto> productos, List<Categoria> categorias){
            Console.WriteLine("===============================");
            Console.WriteLine("\tGuardar Producto");
            Console.WriteLine("===============================");
            Console.Write("Codigo del Producto -> ");
            string Codigo = Console.ReadLine();
            Console.Write("Nombre del Producto -> ");
            string Nombre = Console.ReadLine();
            Console.Write("Stock del Producto -> ");
            int Stock = int.Parse(Console.ReadLine());
            Console.Write("Stock Minimo del Producto -> ");
            int StockMin = int.Parse(Console.ReadLine());
            Console.Write("Stock Maximo del Producto -> ");
            int StockMax = int.Parse(Console.ReadLine());
            Console.Write("Precio de Venta del Producto -> ");
            int PrecioVenta = int.Parse(Console.ReadLine());
            Console.Write("Precio de Compra del Producto -> ");
            int PrecioCompra = int.Parse(Console.ReadLine());
            Categoria categoria = new();
            categoria.Listar(categorias);
            Console.Write("Ingrese el id de la categoria -> ");
            int IdCategoria = int.Parse(Console.ReadLine());
            Producto producto =new(Codigo, Nombre, Stock, StockMin, StockMax, PrecioVenta, PrecioCompra,IdCategoria);
            productos.Add(producto);
        }
         public void Listar(List<Producto> productos){
            Console.Clear();
            Console.WriteLine("===============================");
            Console.WriteLine("\tLista De Productos");
            Console.WriteLine("===============================");
            Console.WriteLine("{0,-30} {1,7} {2, 14}", "ID Productos", "Nombre", "Stock");
            foreach(Producto producto in productos){
                Console.WriteLine("{0, -30} {1,7} {2, 14}", producto.CodProducto, producto.Nombre, producto.Stock);
            }
            Console.Write("Presione Enter Para Continuar -> ");
            Console.ReadLine();
        }
    }
