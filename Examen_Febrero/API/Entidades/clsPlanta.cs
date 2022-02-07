using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Entidades
{
    public class clsPlanta
    {
        #region Atributos
        int iDPlanta;
        string nombre;
        string descripcion;
        int idCategoria;
        double precio;
        #endregion
        #region Constructores
        public clsPlanta()
        {
            iDPlanta = 0;
            nombre = "";
            descripcion = "";
            idCategoria = 0;
            int precio = 0;
        }
        #endregion
        #region Getters & Setters
        public int IDPlanta { get => iDPlanta; set => iDPlanta = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public int IdCategoria { get => idCategoria; set => idCategoria = value; }
        [Required(ErrorMessage = "Campo Obligatorio")]
        public double Precio { get => precio; set => precio = value; }
        #endregion
    }
}
