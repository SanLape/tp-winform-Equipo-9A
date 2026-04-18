using dominio;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using datos;

namespace negocio
{
    public class ArticuloNegocio
    {

        public List<Articulo> listar()
        {

            List<Articulo> lista = new List<Articulo>();    
            AccesoDatos data = new AccesoDatos();   


            try
            {
                data.setQuery("select * from ARTICULOS");
                data.lecturaDatos();

                while (data.Lector.Read())
                {
                    Articulo aux = new Articulo();
                    aux.Id = (int)data.Lector["Id"];
                    aux.Codigo = (string)data.Lector["Codigo"];
                    aux.Nombre = (string)data.Lector["Nombre"];
                    aux.Descripcion = (string)data.Lector["Descripcion"];
                    aux.Precio = (decimal)data.Lector["Precio"];
                    



                    lista.Add(aux);



                }


                return lista;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                data.cerrarConexion();
            }
        }
       

    }   
}
