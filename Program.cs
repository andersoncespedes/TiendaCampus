// See https://aka.ms/new-console-template for more information
using tienda.View;
using tienda.Clases;
public class Programa{
    public static void Main(String[] args){
        List<Producto> productos = new();
        List<Categoria> categorias = new();
        Producto producto = new();
        Categoria categoria = new();
        Inventario inventario= new ();
        int opcion;
        MainMenu menu = new();
        do{ 
            opcion = menu.Menu();
            switch(opcion){
                case 1:
                    producto.Guardar(productos, categorias);
                    break;
                case 2:
                    categoria.Guardar(categorias);
                    break;
                case 3:
                    categoria.Listar(categorias);
                    break;
                case 4:
                    producto.Listar(productos);
                    break;
                case 5:
                    inventario.ListarInventario(productos,categorias );
                    break;
            }
        }while(opcion != 6);
    }   
}