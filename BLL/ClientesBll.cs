using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entidades;
using DAL;

namespace BLL
{
    public class ClientesBll
    {
        public static bool Insertar(Clientes cliente)
        {
            bool retorno = false;

            try
            {
                var db = new ParcialDb();                
                db.Cliente.Add(cliente);
                db.SaveChanges();
                retorno = true;                
            }catch(Exception)
            {
                throw;
            }
            return retorno;
        }

        public static Clientes Buscar(int id)
        {
            var db = new ParcialDb();
            return db.Cliente.Find(id);
        }

        public static List<Clientes> GetLista()
        {
            List<Clientes> lista = new List<Clientes>();
            var db = new ParcialDb();
            lista = db.Cliente.ToList();

            return lista;
        }

        public static List <Clientes>GetLista(DateTime desde, DateTime hasta)
        {
            List<Clientes> lista = new List<Clientes>();
            var db = new ParcialDb();

            lista = (from c in db.Cliente
                     where c.FechaNacimiento.Date >= desde && c.FechaNacimiento.Date <= hasta
                     select c).ToList();
            return lista;
        }

        public static List<Clientes> GetLista(string nombre)
        {
            List<Clientes> lista = new List<Clientes>();
            var db = new ParcialDb();

            lista = (from c in db.Cliente
                     where c.Nombres == nombre
                     select c).ToList();
            return lista;
        }

        public static List<Clientes> GetLista(int id)
        {
            List<Clientes> lista = new List<Clientes>();
            var db = new ParcialDb();

            lista = (from c in db.Cliente
                     where c.ClienteId == id
                     select c).ToList();
            return lista;
        }

        public static void Borrar(int id)
        {
            var db = new ParcialDb();
            var cliente = new Clientes();

            cliente = (from c in db.Cliente where id == c.ClienteId select c).FirstOrDefault();

            db.Cliente.Remove(cliente);
            db.SaveChanges();
        }

        public static void Modificar(int id, Clientes cliente)
        {
            var db = new ParcialDb();

            Clientes client = db.Cliente.Find(id);

            client.Nombres = cliente.Nombres;
            client.LimiteCredito = cliente.LimiteCredito;
            client.FechaNacimiento = cliente.FechaNacimiento;
            client.Telefonos = cliente.Telefonos;

            db.SaveChanges();
        }

    }
}
