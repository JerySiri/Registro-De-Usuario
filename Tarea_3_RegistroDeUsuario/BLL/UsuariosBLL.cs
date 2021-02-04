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
    class UsuariosBLL
    {
        private static bool Insertar(Usuarios user)
        {

            bool paso = false;
            Contexto contexto = new Contexto();

            try
            {
                contexto.Usuarios.Add(user);
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

        public static bool Modificar(Usuarios user)
        {
            bool paso = false;
            Contexto contexto = new Contexto();
            try
            {
                contexto.Entry(user).State = EntityState.Modified;
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
                encontrado = contexto.Usuarios.Any(e => e.UsuarioId == id);
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
       
        public static bool Guardar(Usuarios user)
        {

            if (!Existe(user.UsuarioId))
               return Insertar(user);
            else
                return Modificar(user);
            
                

        }

        public static bool Eliminar(int id)
        {
            bool paso = false;
            Contexto contexto = new Contexto();

            try
            {
                var user = contexto.Usuarios.Find(id);
                if (user != null)
                {
                    contexto.Usuarios.Remove(user);
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

        public static List<Usuarios> GetUsuario()
        {
            List<Usuarios> lista = new List<Usuarios>();
            Contexto contexto = new Contexto();
            try
            {
                lista = contexto.Usuarios.ToList();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }
            return lista;
        }

        public static List<Usuarios> GetList(Expression<Func<Usuarios, bool>> criterio)
        {
            List<Usuarios> Lista = new List<Usuarios>();
            Contexto contexto = new Contexto();

            try
            {

                Lista = contexto.Usuarios.Where(criterio).ToList();
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

        public static Usuarios Buscar(int id)
        {
            Contexto contexto = new Contexto();
            Usuarios user;

            try
            {
                user = contexto.Usuarios.Find(id);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }

            return user;
        }
    }
}
