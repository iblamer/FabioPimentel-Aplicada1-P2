using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entidades;
using DAL;

namespace BLL
{
    public class TiposTelefonosBLL
    {
        public static List<TiposTelefonos>GetLista()
        {
            List<TiposTelefonos> lista = new List<TiposTelefonos>();
            var db = new ParcialDb();

            lista = db.TipoTelefono.ToList();
            return lista;
        }
    }
}
