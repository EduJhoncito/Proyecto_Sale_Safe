using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Sale_Save.Models;
using Microsoft.AspNetCore.Http;

namespace Sale_Save.Controllers
{
    public class ClientesController : Controller
    {
        private readonly sale_saveContext Context;

        public ClientesController(sale_saveContext context)
        {
            Context = context;
        }

        [Route("Clientes/CreateCliente")]
        public IActionResult CreateCliente(Cliente obj)
        {

            if (ModelState.IsValid)
            {
                Context.Clientes.Add(obj);
                Context.SaveChanges();
                //return RedirectToAction("Index");

                HttpContext.Session.SetString("scliente", JsonConvert.SerializeObject(obj));
                return RedirectToAction("Index", "SS");

            }
            else
            {
                return View();
            }
        }

        public IActionResult CerrarSesion() {
            HttpContext.Session.Clear();
            return RedirectToAction("Index", "SS");
        }
    }
}
