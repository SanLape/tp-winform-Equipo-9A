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

        List<Articulo> lista = new List<Articulo>();
        AccesoDatos data = new AccesoDatos();

        public List<Articulo> listar()
        {

           


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

        public void agregarArticulo(Articulo nuevo) {

            string insert = "INSERT INTO Articulos (Codigo, Nombre, Descripcion, Precio) " +
                            "VALUES (@Codigo, @Nombre, @Descripcion, @Precio)";


            try
            {
                data.setQuery(insert);

                data.setarParametro("@Codigo", nuevo.Codigo);
                data.setarParametro("@Nombre", nuevo.Nombre);
                data.setarParametro("@Descripcion", nuevo.Descripcion);
                data.setarParametro("@Precio", nuevo.Precio);

                data.ejecutarAccion();
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
