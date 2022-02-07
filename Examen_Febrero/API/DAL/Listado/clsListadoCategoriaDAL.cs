using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.SqlClient;
using System.Text;
using Entidades;

namespace DAL.Listados
{
    public class clsListadoCategoriaDAL
    {
        /// <summary>
        ///     <cabecera>public static ObservableCollection<clsCategoria> generarListadoCategoriasBL()</cabecera>
        ///     <descripcion>Este metodo se encarga de traer el listado de categorias de la bdd</descripcion>
        ///     <precondiciones>Que la bdd esté creada</precondiciones>
        ///     <postcondiciones>Devuelve el listado de categorias</postcondiciones>
        /// </summary>
        /// <returns>ObservableCollection<clsCategoria> categorias</returns>
        public static ObservableCollection<clsCategoria> generarListadoCategoriasBL()
        {
            Conexion.conexionBDD conexion = new Conexion.conexionBDD();
            ObservableCollection<clsCategoria> categorias = new ObservableCollection<clsCategoria>();
            SqlConnection conection;
            SqlCommand miComando = new SqlCommand();
            SqlDataReader miLector;
            clsCategoria oCategoria;

            try
            {
                conection = conexion.getConnection();
                miComando.CommandText = "SELECT * FROM Categorias";
                miComando.Connection = conection;
                miLector = miComando.ExecuteReader();
                if (miLector.HasRows)
                {
                    while (miLector.Read())
                    {
                        oCategoria = new clsCategoria();
                        oCategoria.IDCategoria = (int)miLector["idCategoria"];
                        oCategoria.NombreCategoria = (String)miLector["nombreCategoria"];
                        categorias.Add(oCategoria);
                    }
                }
                miLector.Close();
                conexion.closeConnection(ref conection);
            }
            catch (Exception e)
            {
                throw e;
            }
            return categorias;
        }
    }
}
