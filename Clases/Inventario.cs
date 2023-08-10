using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace tienda.Clases;

    public class Inventario
    {
        public void ListarInventario(List<Producto> productos, List<Categoria> categorias){
            var relacion = productos.Join(categorias,
            productos => productos.IdCategoria,
            categorias => categorias.IdCategoria,
            (productos, categorias) => new 
            {
                productoNombre = productos.Nombre,
                productosCodigo = productos.CodProducto,
                productosStock = productos.Stock,
                productosValor = productos.PrecioCompra,
                categoriaDescripcion =categorias.Descripcion
            }
            );
            double total = 0;
            Console.Clear();
            Console.WriteLine("===============================");
            Console.WriteLine("\tLista De Inventarios");
            Console.WriteLine("===============================");
            Console.WriteLine("{0,-30} {1,7}, {2,14} {3,21} {4,28}", "ID Producto", "Nombre Producto", "Stock", "Valor Unit",  "Sub Total");
            foreach(var inventario in relacion){
                double subTotal = inventario.productosStock * inventario.productosValor;
                total += subTotal;
                Console.WriteLine("{0,-30} {1,7} {2,14} {3,21} {4,28}", inventario.productosCodigo, inventario.productoNombre, inventario.productosStock, inventario.productosValor,  subTotal);
            }
            Console.WriteLine($"Total: {total}");
            Console.Write("Presione Enter Para Continuar -> ");
            Console.ReadLine();
        }
    }
