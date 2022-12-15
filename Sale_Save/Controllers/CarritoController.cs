using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Sale_Save.Models;
using Microsoft.AspNetCore.Http;
using System.Collections.Generic;

namespace Sale_Save.Controllers
{
    public static class SessionExtension
    {
        public static void SetObject(this ISession session, string key, object value)
        {
            session.SetString(key, JsonConvert.SerializeObject(value));
        }

        public static T GetObject<T>(this ISession session, string key)
        {
            var value = session.GetString(key);
            return value == null ? default(T) : JsonConvert.DeserializeObject<T>(value);
        }
    }
    public class CarritoController : Controller
    {
        private readonly sale_saveContext Context;
        List<CarritoItem> compras = new List<CarritoItem>();

        public CarritoController(sale_saveContext context)
        {
            Context = context;
        }
        public IActionResult AgregarCarrito(int id)
        {

            var ObjSesion = HttpContext.Session.GetString("scliente");

            if (ObjSesion != null)
            {
                var ObjSesions = HttpContext.Session.GetString("carrito");

                var prod = (from t in Context.Productos
                            where t.IdProducto == id
                            join Marcas in Context.Marcas on t.IdMarca equals Marcas.IdMarca
                            join Categorias in Context.Categoria on t.IdCategoria equals Categorias.IdCategoria
                            select new carrito { p = t, m = Marcas, c = Categorias }).Single();
                if (ObjSesions == null)
                {


                    List<CarritoItem> compras = new List<CarritoItem>();
                    compras.Add(new CarritoItem(prod, 1));
                    HttpContext.Session.SetString("carrito", JsonConvert.SerializeObject(compras));
                }
                else
                {
                    List<CarritoItem> compras = HttpContext.Session.GetObject<List<CarritoItem>>("carrito");
                    compras.Add(new CarritoItem(prod, 1));
                    HttpContext.Session.SetString("carrito", JsonConvert.SerializeObject(compras));
                }

                return View();

            }
            else
            {
                return RedirectToAction("Index", "SS");

            }

        
        }


    }


}