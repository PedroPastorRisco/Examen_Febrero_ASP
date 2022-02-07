using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades
{
    public class clsCategoria
    {
        #region Atributos
        int iDCategoria;
        string nombreCategoria;
        #endregion
        #region Constructores
        public clsCategoria()
        {
            iDCategoria = 0;
            nombreCategoria = "";
        }
        #endregion
        #region Getters & Setters
        public int IDCategoria { get => iDCategoria; set => iDCategoria = value; }
        public string NombreCategoria { get => nombreCategoria; set => nombreCategoria = value; }
        #endregion
    }
}
