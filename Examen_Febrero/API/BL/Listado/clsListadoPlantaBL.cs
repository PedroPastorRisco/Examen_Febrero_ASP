using Entidades;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using DAL.Listados;

namespace BL.Listados
{
    public class clsListadoPlantaBL
    {
        /// <summary>
        ///     <cabecera>public static ObservableCollection<clsPlanta> generarListadoPlantasPorIdCategoriaBL(int id)</cabecera>
        ///     <descripcion>Este metodo se encarga de generar un listado de plantas en base al id de una categoria</descripcion>
        ///     <precondiciones>Que el id sea valido</precondiciones>
        ///     <postcondiciones>Devuelve el listado de plantas</postcondiciones>
        /// </summary>
        /// <param name="id">int </param>
        /// <returns>ObservableCollection<clsPlanta> plantas</returns>
        public static ObservableCollection<clsPlanta> generarListadoPlantasPorIdCategoriaBL(int id)
        {
            return clsListadoPlantaDAL.generarListadoPlantasPorIdCategoriaDAL(id);
        }
        /// <summary>
        ///     <cabecera>public static ObservableCollection<clsPlanta> generarListadoPlantasPorIdCategoriaBL(int id)</cabecera>
        ///     <descripcion>Este metodo se encarga de generar un listado de plantas en base al id de una categoria</descripcion>
        ///     <precondiciones>Que el id sea valido</precondiciones>
        ///     <postcondiciones>Devuelve el listado de plantas</postcondiciones>
        /// </summary>
        /// <param name="id">int </param>
        /// <returns>ObservableCollection<clsPlanta> plantas</returns>
        public static ObservableCollection<clsPlanta> generarListadoPlantasBL()
        {
            return clsListadoPlantaDAL.generarListadoPlantasDAL();
        }
        /// <summary>
        ///     <cabecera>public static clsPlanta generarPlantaPorIdDAL(int id)</cabecera>
        ///     <descripcion>Este metodo se encarga de generar una planta en base a su id</descripcion>
        ///     <precondiciones>que el id sea valido</precondiciones>
        ///     <postcondiciones>Devuelve una planta</postcondiciones>
        /// </summary>
        /// <param name="id">int </param>
        /// <returns>clsPlanta oPlanta</returns>
        public static clsPlanta generarPlantaPorIdBL(int id)
        {
            return clsListadoPlantaDAL.generarPlantaPorIdDAL(id);
        }
    }
}
