using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace Entidades
{
    public class TiposTelefonos
    {
        [Key]
        public int TipoId { get; set; }
        public string Descripcion { get; set; }

        public List<Clientes> Clientes { get; set; }

        public TiposTelefonos()
        {
            this.Clientes = new List<Clientes>();
        }

        public TiposTelefonos(int id, string descripcion)
        {
            this.TipoId = id;
            this.Descripcion = descripcion;
        }
    }
}
