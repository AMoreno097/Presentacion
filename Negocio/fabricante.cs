using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class fabricante
    {
        public static Modelo.Result Listafabricante()
        {
            Modelo.Result result = new Modelo.Result();
            try
            {
                using (Conexion.DB_CeciliaGabriela_EscalonaChavarriaEntities context = new Conexion.DB_CeciliaGabriela_EscalonaChavarriaEntities())
                {
                    var query = context.ListaProducto();
                    if (query != null)
                    {
                        result.Objetos = new List<object>();
                        Modelo.producto Productos = new Modelo.producto();
                        foreach (var obj in query)
                        {
                            Productos.codigo = obj.codigo;
                            Productos.nombre = obj.nombre;
                            Productos.precio = obj.precio.Value;
                            Productos.fabricante = new Modelo.fabricante();
                            Productos.fabricante.nombre = obj.fabricante;
                            result.Objetos.Add(Productos);
                        }
                    }
                }
            }
            catch (Exception Ex)
            {

            }
            return result;
        }
    }
}
