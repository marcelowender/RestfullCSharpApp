using CadastroUsuarios.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CadastroUsuarios.DbContexts
{
    public class UsuarioContext : DbContext
    {
        public UsuarioContext() : base("name=UsuarioContext")
        {
         
        }

        public DbSet<Usuario> Usuarios { get; set; }
    
    }
}