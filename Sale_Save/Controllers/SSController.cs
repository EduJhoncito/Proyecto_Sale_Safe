using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Sale_Save.Models;
using System.Collections.Generic;

namespace Sale_Save.Controllers
{
    public class SSController : Controller
    {
        private readonly sale_saveContext Context;

        public SSController(sale_saveContext context) {
            Context = context;
        }
        public IActionResult Index()
        {
            return View();
        }

        [Route("IniSes.html")]
        public IActionResult IniSes()
        {
            return View();
        }

        [Route("Acercade.html")]
        public IActionResult Acercade()
        {
            return View();
        }

        [Route("PoliticaDePrivacidad.html")]
        public IActionResult PoliticaDePrivacidad()
        {
            return View();
        }

        [Route("TerminosYCondiciones.html")]
        public IActionResult TerminosYCondiciones()
        {
            return View();
        }

        [Route("cocinas.html")]
        public IActionResult cocinas()
        {
            var productos = (from t in Context.Productos
                             join Marcas in Context.Marcas on t.IdMarca equals Marcas.IdMarca
                             join Categorias in Context.Categoria on t.IdCategoria equals Categorias.IdCategoria
                             select new listado { p = t, m = Marcas, c = Categorias }).ToList();
            List<listado> l = new List<listado>();
            foreach (var item in productos)
            {
                if (item.c.TipoCategoria.Equals("Cocinas"))
                {
                    l.Add(item);
                }
            }
            return View(l);
        }

        [Route("descrip_productos.html")]
        public IActionResult descrip_productos(int idProducto)
        {

            var p = (from t in Context.Productos where t.IdProducto == idProducto select t).Single();

            Producto obj = new Producto();
            obj = p;
            return View(obj);
        }

        [Route("fecha.html")]
        public IActionResult Fecha() {
            return View();
        }

        [Route("climatizacion.html")]

        public IActionResult climatizacion()
        {
            var productos = (from t in Context.Productos
                            join Marcas in Context.Marcas on t.IdMarca equals Marcas.IdMarca
                            join Categorias in Context.Categoria on t.IdCategoria equals Categorias.IdCategoria
                            select new listado { p=t, m=Marcas, c=Categorias}).ToList();
            List<listado> l = new List<listado>();
            foreach (var item in productos) {
                if (item.c.TipoCategoria.Equals("Climatización")) { 
                    l.Add(item);
                }
            }
            return View(l);
        }

        [Route("cuidadoPersonal.html")]

        public IActionResult cuidadoPersonal()
        {
            var productos = (from t in Context.Productos
                             join Marcas in Context.Marcas on t.IdMarca equals Marcas.IdMarca
                             join Categorias in Context.Categoria on t.IdCategoria equals Categorias.IdCategoria
                             select new listado { p = t, m = Marcas, c = Categorias }).ToList();
            List<listado> l = new List<listado>();
            foreach (var item in productos)
            {
                if (item.c.TipoCategoria.Equals("CuidadoPersonal"))
                {
                    l.Add(item);
                }
            }
            return View(l);
        }

        [Route("microondas.html")]

        public IActionResult microondas()
        {
            var productos = (from t in Context.Productos
                             join Marcas in Context.Marcas on t.IdMarca equals Marcas.IdMarca
                             join Categorias in Context.Categoria on t.IdCategoria equals Categorias.IdCategoria
                             select new listado { p = t, m = Marcas, c = Categorias }).ToList();
            List<listado> l = new List<listado>();
            foreach (var item in productos)
            {
                if (item.c.TipoCategoria.Equals("Microondas"))
                {
                    l.Add(item);
                }
            }
            return View(l);
        }

        [Route("refrigerador.html")]

        public IActionResult refrigerador()
        {
            var productos = (from t in Context.Productos
                             join Marcas in Context.Marcas on t.IdMarca equals Marcas.IdMarca
                             join Categorias in Context.Categoria on t.IdCategoria equals Categorias.IdCategoria
                             select new listado { p = t, m = Marcas, c = Categorias }).ToList();
            List<listado> l = new List<listado>();
            foreach (var item in productos)
            {
                if (item.c.TipoCategoria.Equals("Refrigeradores"))
                {
                    l.Add(item);
                }
            }
            return View(l);
        }

        [Route("televisores.html")]

        public IActionResult televisores()
        {
            var productos = (from t in Context.Productos
                             join Marcas in Context.Marcas on t.IdMarca equals Marcas.IdMarca
                             join Categorias in Context.Categoria on t.IdCategoria equals Categorias.IdCategoria
                             select new listado { p = t, m = Marcas, c = Categorias }).ToList();
            List<listado> l = new List<listado>();
            foreach (var item in productos)
            {
                if (item.c.TipoCategoria.Equals("Televisores"))
                {
                    l.Add(item);
                }
            }
            return View(l);
        }
        }

    }



//Scaffold-DbContext "Server=localhost;Database=sale_save;Uid=root;Pwd=;" Pomelo.EntityFrameworkCore.MySql -OutputDir Models -Force