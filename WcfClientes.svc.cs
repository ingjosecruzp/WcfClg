using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Data.Entity;

namespace WcfClg
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "WcfClientes" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select WcfClientes.svc or WcfClientes.svc.cs at the Solution Explorer and start debugging.
    public class WcfClientes : IWcfClientes
    {
        public clientes add(clientes cliente)
        {
            try
            {
                clgEntities db = new clgEntities();

                db.clientes.Add(cliente);
                db.SaveChanges();

                return cliente;
            }
            catch (Exception ex)
            {

                return null;
            }
        }

        public List<clientes> all()
        {
            try
            {
                clgEntities db = new clgEntities();

                List<clientes> LstClientes = db.clientes.Include(c => c.direcciones).ToList();

                return LstClientes;
            }
            catch (Exception ex)
            {

                return null;
            }
        }

        public clientes delete(string id)
        {
            try
            {
                long ClienteId = long.Parse(id);

                clgEntities db = new clgEntities();

                clientes cliente = db.clientes.Find(ClienteId);

                db.clientes.Attach(cliente);
                db.clientes.Remove(cliente);

                db.SaveChanges();

                return cliente;

            }
            catch (Exception ex)
            {

                return null;
            }
        }

        public clientes get(string id)
        {
            try
            {
                clgEntities db = new clgEntities();

                long ClienteId = long.Parse(id);

                clientes cliente = db.clientes.Find(ClienteId);

                return cliente;
            }
            catch (Exception ex)
            {

                return null;
            }
        }

        public clientes update(clientes cliente)
        {
            try
            {
                clgEntities db = new clgEntities();
                db.clientes.Attach(cliente);
                db.Entry(cliente).State = System.Data.Entity.EntityState.Modified;

                db.SaveChanges();
                return cliente;
            }
            catch (Exception ex)
            {

                return null;
            }
        }
    }
}
