using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;
using Entidades;

namespace DAL.Gestora
{
    public class clsGestoraPlantaDAL
    {
        /// <summary>
        ///     <cabecera>public static int editarPrecioPlantaDAL(clsPlanta oPlanta)</cabecera>
        ///     <descripcion>Este metodo se encarga de actualizar el precio de una planta en la base de datos.</descripcion>
        ///     <precondiciones>Que el id sea valido</precondiciones>
        ///     <postcondiciones>Actualizar el precio de la planta</postcondiciones>
        /// </summary>
        /// <param name="oPlanta">clsPlanta</param>
        /// <returns>int filasAfectadas</returns>
        public static int editarPrecioPlantaDAL(clsPlanta oPlanta)
        {
            int resultado = 0;
            Conexion.conexionBDD conexion = new Conexion.conexionBDD();
            SqlConnection conection;
            SqlCommand miComando = new SqlCommand();

            try
            {
                conection = conexion.getConnection();
                miComando.Parameters.Add("@id", System.Data.SqlDbType.Int).Value = oPlanta.IDPlanta;
                if (!String.IsNullOrEmpty(oPlanta.Nombre))
                {
                    miComando.Parameters.Add("@nombre", System.Data.SqlDbType.VarChar).Value = oPlanta.Nombre;
                }
                else
                {
                    miComando.Parameters.Add("@nombre", System.Data.SqlDbType.VarChar).Value = "SoyNula";
                }
                if (!String.IsNullOrEmpty(oPlanta.Descripcion))
                {
                    miComando.Parameters.Add("@desc", System.Data.SqlDbType.VarChar).Value = oPlanta.Descripcion;
                }
                else
                {
                    miComando.Parameters.Add("@desc", System.Data.SqlDbType.VarChar).Value = System.DBNull.Value;
                }
                if (oPlanta.IdCategoria != 0)
                {
                    miComando.Parameters.Add("@idCat", System.Data.SqlDbType.Int).Value = oPlanta.IdCategoria;
                }
                else
                {
                    miComando.Parameters.Add("@idCat", System.Data.SqlDbType.Int).Value = 1;
                }
                if (oPlanta.Precio != 0)
                {
                    miComando.Parameters.Add("@precio", System.Data.SqlDbType.Float).Value = oPlanta.Precio;
                }
                else
                {
                    miComando.Parameters.Add("@precio", System.Data.SqlDbType.Float).Value = System.DBNull.Value;
                }
                miComando.CommandText = "UPDATE Plantas SET precio = @precio WHERE idPlanta = @id";
                miComando.Connection = conection;
                resultado = miComando.ExecuteNonQuery();
                conexion.closeConnection(ref conection);
            }
            catch (Exception)
            {
                throw;
            }
            return resultado;
        }
        /// <summary>
        ///     <cabecera>public static int editarPrecioPlantaDAL(clsPlanta oPlanta)</cabecera>
        ///     <descripcion>Este metodo se encarga de actualizar el precio de una planta en la base de datos.</descripcion>
        ///     <precondiciones>Que el id sea valido</precondiciones>
        ///     <postcondiciones>Actualizar el precio de la planta</postcondiciones>
        /// </summary>
        /// <param name="oPlanta">clsPlanta</param>
        /// <returns>int filasAfectadas</returns>
        public static int insertarPlantaDAL(clsPlanta oPlanta)
        {
            int resultado = 0;
            Conexion.conexionBDD conexion = new Conexion.conexionBDD();
            SqlConnection conection;
            SqlCommand miComando = new SqlCommand();

            try
            {
                conection = conexion.getConnection();
                if (!String.IsNullOrEmpty(oPlanta.Nombre))
                {
                    miComando.Parameters.Add("@nombre", System.Data.SqlDbType.VarChar).Value = oPlanta.Nombre;
                }
                else
                {
                    miComando.Parameters.Add("@nombre", System.Data.SqlDbType.VarChar).Value = "SoyNula";
                }
                if (!String.IsNullOrEmpty(oPlanta.Descripcion))
                {
                    miComando.Parameters.Add("@desc", System.Data.SqlDbType.VarChar).Value = oPlanta.Descripcion;
                }
                else
                {
                    miComando.Parameters.Add("@desc", System.Data.SqlDbType.VarChar).Value = System.DBNull.Value;
                }
                if (oPlanta.IdCategoria != 0)
                {
                    miComando.Parameters.Add("@idCat", System.Data.SqlDbType.Int).Value = oPlanta.IdCategoria;
                }
                else
                {
                    miComando.Parameters.Add("@idCat", System.Data.SqlDbType.Int).Value = 1;
                }
                if (oPlanta.Precio != 0)
                {
                    miComando.Parameters.Add("@precio", System.Data.SqlDbType.Float).Value = oPlanta.Precio;
                }
                else
                {
                    miComando.Parameters.Add("@precio", System.Data.SqlDbType.Float).Value = System.DBNull.Value;
                }
                miComando.CommandText = "INSERT INTO Plantas VALUES(@nombre,@desc,@idCat,@precio)";
                miComando.Connection = conection;
                resultado = miComando.ExecuteNonQuery();
                conexion.closeConnection(ref conection);
            }
            catch (Exception)
            {
                throw;
            }
            return resultado;
        }
    }
}
