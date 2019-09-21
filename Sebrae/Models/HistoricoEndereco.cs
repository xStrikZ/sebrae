using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Sebrae.Models
{
    [Table("HistoricoEnderecos")]
    public class HistoricoEndereco : BaseModel
    {
        public string CNPJ { get; set; }

        public string CEP { get; set; }

        public string Estado { get; set; }

        public string Cidade { get; set; }

        public string Rua { get; set; }

        public string Numero { get; set; }

        public string Complemento { get; set; }

        public DateTime DataRegistro { get; set; }
    }
}