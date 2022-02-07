using Entidades;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.SqlClient;
using System.Text;

namespace DAL.Listados
{
    public class clsListadoPlantaDAL
    {
        /// <summary>
        ///     <cabecera>public static ObservableCollection<clsPlanta> generarListadoPlantasPorIdCategoriaDAL(int id)</cabecera>
        ///     <descripcion>Este metodo se encarga de traer el listado de plantas de una categoria en especifico.</descripcion>
        ///     <precondiciones>Que el id sea valido y la base de datos este creada</precondiciones>
        ///     <postcondiciones>Devuelve la lista de categorias</postcondiciones>
        /// </summary>
        /// <param name="id">int</param>
        /// <returns>ObservableCollection<clsPlanta> plantas</returns>
        public static ObservableCollection<clsPlanta> generarListadoPlantasPorIdCategoriaDAL(int id)
        {
            Conexion.conexionBDD conexion = new Conexion.conexionBDD();
            ObservableCollection<clsPlanta> plantas = new ObservableCollection<clsPlanta>();
            SqlConnection conection;
            SqlCommand miComando = new SqlCommand();
            SqlDataReader miLector;
            clsPlanta oPlanta;

            try
            {
                conection = conexion.getConnection();
                miComando.Parameters.Add("@id", System.Data.SqlDbType.Int).Value = id;
                miComando.CommandText = "SELECT * FROM Plantas WHERE idCategoria = @id";
                miComando.Connection = conection;
                miLector = miComando.ExecuteReader();
                if (miLector.HasRows)
                {
                    while (miLector.Read())
                    {
                        oPlanta = new clsPlanta();
                        oPlanta.IDPlanta = (int)miLector["idPlanta"];
                        if (miLector["nombrePlanta"] != System.DBNull.Value)
                        {
                            oPlanta.Nombre = (String)miLector["nombrePlanta"];
                        }
                        if (miLector["descripcion"] != System.DBNull.Value)
                        {
                            oPlanta.Descripcion = (String)miLector["descripcion"];
                        }
                        if (miLector["idCategoria"] != System.DBNull.Value)

                        { oPlanta.IdCategoria = (int)miLector["idCategoria"]; }
                        if (miLector["precio"] != System.DBNull.Value)
                        {
                            oPlanta.Precio = (double)miLector["precio"];
                        }
                        plantas.Add(oPlanta);
                    }
                }
                miLector.Close();
                conexion.closeConnection(ref conection);
            }
            catch (Exception e)
            {
                throw e;
            }
            return plantas;
        }
        /// <summary>
        ///     <cabecera>public static ObservableCollection<clsPlanta> generarListadoPlantasPorIdCategoriaDAL(int id)</cabecera>
        ///     <descripcion>Este metodo se encarga de traer el listado de plantas de una categoria en especifico.</descripcion>
        ///     <precondiciones>Que el id sea valido y la base de datos este creada</precondiciones>
        ///     <postcondiciones>Devuelve la lista de categorias</postcondiciones>
        /// </summary>
        /// <param name="id">int</param>
        /// <returns>ObservableCollection<clsPlanta> plantas</returns>
        public static ObservableCollection<clsPlanta> generarListadoPlantasDAL()
        {
            Conexion.conexionBDD conexion = new Conexion.conexionBDD();
            ObservableCollection<clsPlanta> plantas = new ObservableCollection<clsPlanta>();
            SqlConnection conection;
            SqlCommand miComando = new SqlCommand();
            SqlDataReader miLector;
            clsPlanta oPlanta;

            try
            {
                conection = conexion.getConnection();
                miComando.CommandText = "SELECT * FROM Plantas";
                miComando.Connection = conection;
                miLector = miComando.ExecuteReader();
                if (miLector.HasRows)
                {
                    while (miLector.Read())
                    {
                        oPlanta = new clsPlanta();
                        oPlanta.IDPlanta = (int)miLector["idPlanta"];
                        if (miLector["nombrePlanta"] != System.DBNull.Value)
                        {
                            oPlanta.Nombre = (String)miLector["nombrePlanta"];
                        }
                        if (miLector["descripcion"] != System.DBNull.Value)
                        {
                            oPlanta.Descripcion = (String)miLector["descripcion"];
                        }
                        if (miLector["idCategoria"] != System.DBNull.Value)

                        { oPlanta.IdCategoria = (int)miLector["idCategoria"]; }
                        if (miLector["precio"] != System.DBNull.Value)
                        {
                            oPlanta.Precio = (double)miLector["precio"];
                        }
                        plantas.Add(oPlanta);
                    }
                }
                miLector.Close();
                conexion.closeConnection(ref conection);
            }
            catch (Exception e)
            {
                throw e;
            }
            return plantas;
        }
        /// <summary>
        ///     <cabecera>public static clsPlanta generarPlantaPorIdDAL(int id)</cabecera>
        ///     <descripcion>Este metodo se encarga de traer una planta de la base de datos en base a su id</descripcion>
        ///     <precondciones>Que el id sea valido y la base de datos este creada</precondciones>
        ///     <postcondiciones>Devuelve la planta en concreto</postcondiciones>
        /// </summary>
        /// <param name="id">int</param>
        /// <returns>clsPlanta oPlanta</returns>
        public static clsPlanta generarPlantaPorIdDAL(int id)
        {
            Conexion.conexionBDD conexion = new Conexion.conexionBDD();
            SqlConnection conection;
            SqlCommand miComando = new SqlCommand();
            SqlDataReader miLector;
            clsPlanta oPlanta=null;

            try
            {
                conection = conexion.getConnection();
                miComando.Parameters.Add("@id", System.Data.SqlDbType.Int).Value = id;
                miComando.CommandText = "SELECT * FROM Plantas WHERE idPlanta = @id";
                miComando.Connection = conection;
                miLector = miComando.ExecuteReader();
                if (miLector.HasRows)
                {
                    miLector.Read();
                    oPlanta = new clsPlanta();
                    oPlanta.IDPlanta = (int)miLector["idPlanta"];
                    if (miLector["nombrePlanta"] != System.DBNull.Value)
                    {
                       oPlanta.Nombre = (String)miLector["nombrePlanta"];
                    }
                    if (miLector["descripcion"] != System.DBNull.Value)
                    {
                       oPlanta.Descripcion = (String)miLector["descripcion"];
                    }
                    if (miLector["idCategoria"] != System.DBNull.Value)

                    { oPlanta.IdCategoria = (int)miLector["idCategoria"]; }
                    if (miLector["precio"] != System.DBNull.Value)
                    {
                        oPlanta.Precio = (double)miLector["precio"];
                    }
                }
                miLector.Close();
                conexion.closeConnection(ref conection);
            }
            catch (Exception e)
            {
                throw e;
            }
            return oPlanta;
        }

    }
}
