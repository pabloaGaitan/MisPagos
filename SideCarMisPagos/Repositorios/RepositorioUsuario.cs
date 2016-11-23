using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SideCarMisPagos
{
    class RepositorioUsuario
    {
        Contexto ctx = new Contexto();
        public void CrearUsuario(Usuario usuario)
        {
            ctx.Usuarios.Add(usuario);
            ctx.SaveChanges();
        }

        public Usuario ConsultarUsuarioDocumentos(String doc, String tipo)
        {
            Usuario usuario = (from u in ctx.Usuarios
                               where u.TipoDocumento.Equals(tipo)
                               select u).Single();
            return usuario;
        }

        public IQueryable<Usuario> ConsultarUsuarios()
        {
            return ctx.Usuarios;
        }
        public void editarUsuario(Usuario usuarioNuevo)
        {
            Usuario u = ConsultarUsuarioDocumentos(usuarioNuevo.Documento, usuarioNuevo.TipoDocumento);
            u.UsuarioMisPagos = usuarioNuevo.UsuarioMisPagos;
            u.Contrasenia = usuarioNuevo.Contrasenia;
            ctx.Entry(u).State = EntityState.Modified;
            ctx.SaveChanges();
        }

    }
}
