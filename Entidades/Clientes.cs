using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace Entidades
{
    public class Clientes
    {
        [Key]
        public int ClienteId { get; set;}
        public string Nombres { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public double LimiteCredito { set; get; }
        public List<TiposTelefonos> Telefonos { get; set; }

        public Clientes()
        {
            this.Telefonos = new List<TiposTelefonos>();
        }

        public Clientes(string nombres, DateTime fechaNacimiento, float limiteCredito)
        {
            this.Nombres = nombres;
            this.FechaNacimiento = fechaNacimiento;
            this.LimiteCredito = limiteCredito;
            this.Telefonos = new List<TiposTelefonos>();
        }
    }
}
