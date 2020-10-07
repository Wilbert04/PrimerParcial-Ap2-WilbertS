using Microsoft.EntityFrameworkCore;
using PrimerParcial_Ap2_WIlbertSmith.DAL;
using PrimerParcial_Ap2_WIlbertSmith.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrimerParcial_Ap2_WIlbertSmith.BLL
{
    public class ProductoBLL
    {

        public static bool Guardar(Productos productos)
        {
            if (!Existe(productos.ProductoId))
                return Insertar(productos);
            else
            {
                return Modificar(productos);
            }
        }


        private static bool Insertar(Productos productos)
        {
            bool paso = false;
            Contexto db = new Contexto();

            try
            {
                db.productos.Add(productos);
                paso = db.SaveChanges() > 0;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                db.Dispose();
            }

            return paso;
        }


        public static bool Modificar(Productos productos)
        {
            bool paso = false;
            Contexto db = new Contexto();

            try
            {
                db.Entry(productos).State = EntityState.Modified;
                paso = db.SaveChanges() > 0;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                db.Dispose();
            }

            return paso;

        }

        public static bool Eliminar(int id)
        {
            bool paso = false;
            Contexto db = new Contexto();


            try
            {
                var eliminar = db.productos.Find(id);
                db.Entry(eliminar).State = EntityState.Deleted;
                paso = db.SaveChanges() > 0;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                db.Dispose();
            }

            return paso;
        }

        public static Productos Buscar(int id)
        {

            Contexto db = new Contexto();
            Productos productos = new Productos();
            try
            {
                productos = db.productos.Find(id);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                db.Dispose();
            }

            return productos;
        }

        public static bool Existe(int id)
        {
            bool encontrado = false;
            Contexto db = new Contexto();

            try
            {
                encontrado = db.productos.Any(a => a.ProductoId == id);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                db.Dispose();
            }

            return encontrado;
        }
    }
}
