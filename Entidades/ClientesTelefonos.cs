using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace Entidades
{
    public class ClientesTelefonos
    {
        [Key]
        public int Id { set; get; }
        public int ClienteId { set; get; }
        public int TipoId { set; get; }
        public string Numero { set; get; }
    }
}
