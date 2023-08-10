using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace tienda.Clases;
public class Categoria
{
    public int IdCategoria { get; set;}
    public string Descripcion { get;set;}
    public Categoria(int idCategoria, string descripcion){
        IdCategoria = idCategoria;
        Descripcion = descripcion;
    }
    public Categoria(){

    }
        public int GenerarId(List<Categoria> categorias){
            try{
                int Id = categorias[^1].IdCategoria + 1;
                return Id;
            }catch(Exception){
                return 0;
            }
        }
        public void Guardar(List<Categoria> categorias){
            Console.Clear();
            Console.WriteLine("===============================");
            Console.WriteLine("\tGuardar Categoria");
            Console.WriteLine("===============================");
            Console.Write("Descripcion -> ");
            string Descripcion = Console.ReadLine();
            Categoria categoria = new(GenerarId(categorias), Descripcion);
            categorias.Add(categoria);
        }
        public void Listar(List<Categoria> categorias){
            Console.Clear();
            Console.WriteLine("===============================");
            
            Console.WriteLine("\tLista De Categorias");
            Console.WriteLine("===============================");
            Console.WriteLine("{0,-30} {1,7}", "ID Categoria", "Descripcion" );
            foreach(Categoria categoria in categorias){
                Console.WriteLine("{0, -30} {1,7}", categoria.IdCategoria, categoria.Descripcion);
            }
            Console.Write("Presione Enter Para Continuar -> ");
            Console.ReadLine();
        }
        

}
