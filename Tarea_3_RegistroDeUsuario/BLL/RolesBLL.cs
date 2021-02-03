using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tarea_3_RegistroDeUsuario.Entidades;
using Tarea_3_RegistroDeUsuario.DAL;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace Tarea_3_RegistroDeUsuario.BLL
{
    class RolesBLL
    {
        private static bool Insertar(Roles rol)
        {

            bool paso = false;
            Contexto contexto = new Contexto();

            try
            {
                contexto.Roles.Add(rol);
                paso = contexto.SaveChanges() > 0;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }
            return paso;
        }

        public static bool Modificar(Roles rol)
        {
            bool paso = false;
            Contexto contexto = new Contexto();
            try
            {
                contexto.Entry(rol).State = EntityState.Modified;
                paso = contexto.SaveChanges() > 0;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }
            return paso;
        }

        private static bool Existe(int id)
        {
            Contexto contexto = new Contexto();
            bool encontrado = false;

            try
            {
                encontrado = contexto.Roles.Any(e => e.rolesId == id);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }

            return encontrado;
        }
        public static bool ExisteDescripcion(string descripcion)
        {

            Contexto contexto = new Contexto();
            bool encontrado = false;

            try
            {
                encontrado = contexto.Roles.Any(e => e.descripcion == descripcion);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }

            return encontrado;
        }
        public static bool Guardar(Roles rol)
        {

            if (!Existe(rol.rolesId))
                return Insertar(rol);
            else
                return Modificar(rol);

        }

        public static bool Eliminar(int id)
        {
            bool paso = false;
            Contexto contexto = new Contexto();

            try
            {
                var rol = contexto.Roles.Find(id);

                if (rol != null)
                {
                    contexto.Roles.Remove(rol);
                    paso = contexto.SaveChanges() > 0;
                }
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }
            return paso;
        }

        public static Roles Buscar(int id)
        {
            Contexto contexto = new Contexto();
            Roles rol;

            try
            {
                rol = contexto.Roles.Find(id);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }

            return rol;
        }

        public static List<Roles> GetList(Expression<Func<Roles, bool>> criterio)
        {
            List<Roles> Lista = new List<Roles>();
            Contexto contexto = new Contexto();

            try
            {
                
                Lista = contexto.Roles.Where(criterio).ToList();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }
            return Lista;
        }
    }
}
