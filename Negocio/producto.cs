using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class producto
    {
        public static Modelo.Result AgragarProducto(Modelo.producto Producto)
        {
            Modelo.Result result = new Modelo.Result();
            try
            {
                using(Conexion.DB_CeciliaGabriela_EscalonaChavarriaEntities context =  new Conexion.DB_CeciliaGabriela_EscalonaChavarriaEntities())
                {
                    int query = context.Insertar(Producto.nombre, Producto.precio, Producto.fabricante.codigo);
                    if(query > 0)
                    {
                        result.Correcto = true;
                    }
                    else
                    {
                        result.MensajeError = "No se pudo agregar correctamente el producto";
                        result.Correcto = false;
                    }
                }

            }
            catch(Exception Ex)
            {
                result.Correcto = false;
            }
            return result;
        }
        public static Modelo.Result ListaProducto()
        {
            Modelo.Result result = new Modelo.Result();
            try
            {
                using(Conexion.DB_CeciliaGabriela_EscalonaChavarriaEntities context = new Conexion.DB_CeciliaGabriela_EscalonaChavarriaEntities())
                {
                    var query = context.ListaProducto();
                    if(query != null)
                    {
                        result.Objetos = new List<object>();
                        
                        foreach(var obj in query)
                        {
                            Modelo.producto Productos = new Modelo.producto();
                            Productos.codigo = obj.codigo;
                            Productos.nombre = obj.nombre;
                            Productos.precio = obj.precio.Value;
                            Productos.fabricante = new Modelo.fabricante();
                            Productos.fabricante.nombre= obj.fabricante;
                            result.Objetos.Add(Productos);
                        }
                    }
                }
            }
            catch(Exception Ex)
            {

            }
            return result;
        }
    }
}
