using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Sebrae.Models
{
    public class Context : DbContext
    {
        public Context() : base("SebraeDB")
        {

        }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<PessoaJuridica> PESSOA_JURIDICA { get; set; }
        public DbSet<HistoricoEndereco> HistoricoEnderecos { get; set; }
    }
}