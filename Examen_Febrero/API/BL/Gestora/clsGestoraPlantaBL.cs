using Entidades;
using System;
using System.Collections.Generic;
using System.Text;
using DAL.Gestora;

namespace BL.Gestora
{
    public class clsGestoraPlantaBL
    {
        /// <summary>
        ///     <cabecera>public static int editarPrecioPlantaBL(clsPlanta oPlanta)</cabecera>
        ///     <descripcion>Este metodo se encarga de editar el precio de una planta</descripcion>
        ///     <precondiciones>Ninguna</precondiciones>
        ///     <postcondiciones>Devuelve el numero de filas afectadas</postcondiciones>
        /// </summary>
        /// <param name="oPlanta">clsPlanta</param>
        /// <returns>int filasAfectadas</returns>
        public static int editarPrecioPlantaBL(clsPlanta oPlanta)
        {
            return clsGestoraPlantaDAL.editarPrecioPlantaDAL(oPlanta);
        }
    }
}
