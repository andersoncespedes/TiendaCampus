using tienda.Clases;
using Newtonsoft.Json;
namespace tienda;

    public static class Env
    {
        public const string FilePathProduct = @"Json/Producto.json";
        public const string FilePathCategory = @"Json/Categoria.json";

        public static List<T> Serializar<T>(string path){
            try{
                using (StreamReader jsonStream = File.OpenText(path))
            {
                var json = jsonStream.ReadToEnd();
                List<T> objeto = JsonConvert.DeserializeObject<List<T>>(json);
                return objeto;
            }
            }catch(Exception){
                return null;
            }
        }
          public static void ActualizarJson(string lista){
        string json;
        switch (lista){
            case "productos":
                json = JsonConvert.SerializeObject(productosLista,Formatting.Indented); 
                File.WriteAllText(FilePathProduct, json);
                break;
            case "categorias":
                json = JsonConvert.SerializeObject(categoriaLista, Formatting.Indented); 
                File.WriteAllText(FilePathCategory , json);
                break;
        }
    }
        public static  List<Producto> productosLista = Serializar<Producto>(FilePathProduct) ?? new();
        public static  List<Categoria> categoriaLista = Serializar<Categoria>(FilePathCategory ) ?? new();
    }
