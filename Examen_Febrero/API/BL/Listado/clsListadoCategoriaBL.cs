using Entidades;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using DAL.Listados;

namespace BL.Listados
{
    public class clsListadoCategoriaBL
    {
        /// <summary>
        ///     <cabecera>public static ObservableCollection<clsCategoria> generarListadoCategoriasBL()</cabecera>
        ///     <descripcion>Este metodo se encarga de llamar a la capa dal para traer un listado de categorias</descripcion>
        ///     <precondiciones>Ninguna</precondiciones>
        ///     <postcondiciones>Devuelve la lista de categorias</postcondiciones>
        /// </summary>
        /// <returns></returns>
        public static ObservableCollection<clsCategoria> generarListadoCategoriasBL()
        {
            return clsListadoCategoriaDAL.generarListadoCategoriasBL();
        }
    }
}
