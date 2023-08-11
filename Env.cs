using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using tienda.Clases;
using System.IO;
using Newtonsoft.Json;
namespace tienda;

    public static class Env
    {
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
                json = JsonConvert.SerializeObject(productosLista); 
                File.WriteAllText(@"Json/Producto.json", json);
                break;
            case "categorias":
                json = JsonConvert.SerializeObject(categoriaLista); 
                File.WriteAllText(@"Json/Categoria.json", json);
                break;
        }
    }
        public static  List<Producto> productosLista = Serializar<Producto>(@"Json/Producto.json") ?? new();
        public static  List<Categoria> categoriaLista = Serializar<Categoria>(@"Json/Categoria.json") ?? new();
    }
