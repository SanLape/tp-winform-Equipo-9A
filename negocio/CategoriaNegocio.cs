using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using datos;
using dominio;

namespace negocio
{
    public class CategoriaNegocio
    {
        List<Categoria> lista = new List<Categoria>();
        AccesoDatos datos = new AccesoDatos();
        public List<Categoria> listar()
        {
            try
            {
                datos.setQuery("select id, descripcion from CATEGORIAS");
                datos.lecturaDatos();

                while (datos.Lector.Read())
                {
                    Categoria aux = new Categoria();
                    aux.Id = (int)datos.Lector["id"];
                    aux.Nombre = (string)datos.Lector["descripcion"];

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
                datos.cerrarConexion();
            }
        }
        public void agregar(Categoria nuevo)
        {
            string insert = "INSERT INTO CATEGORIAS (Descripcion) VALUES(@nombre)";
            try
            {
                datos.setQuery(insert);
                datos.setarParametro("@nombre", nuevo.Nombre);

                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }
    }
}
