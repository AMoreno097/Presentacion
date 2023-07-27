using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Presentacion.Controllers
{
    public class ProductoController : Controller
    {
        // GET: Producto
        public ActionResult ListaProducto()
        {

            Modelo.Result result = Negocio.producto.ListaProducto();
            Modelo.producto Producto = new Modelo.producto();


            Producto.productos = result.Objetos;

            return View(Producto);
        }
    }
}