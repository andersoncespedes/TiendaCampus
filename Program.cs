// See https://aka.ms/new-console-template for more information
using tienda.View;
using tienda.Clases;
namespace tienda;
public class Programa{
    public static void Main(String[] args){
        Producto producto = new();
        Categoria categoria = new();
        Inventario inventario= new ();
        int opcion;
        MainMenu menu = new();
        do{ 
            opcion = menu.Menu();
            switch(opcion){
                case 1:
                    producto.Guardar(Env.productosLista, Env.categoriaLista);
                    Env.ActualizarJson("productos");
                    break;
                case 2:
                    categoria.Guardar(Env.categoriaLista);
                    Env.ActualizarJson("categorias");
                    break;
                case 3:
                    categoria.Listar(Env.categoriaLista);
                    break;
                case 4:
                    producto.Listar(Env.productosLista);
                    break;
                case 5:
                    inventario.ListarInventario(Env.productosLista,Env.categoriaLista );
                    break;
            }
        }while(opcion != 6);
    }   
}