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
    }
}
