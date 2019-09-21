using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Sebrae.Models
{
    [Table("PESSOA_JURIDICA")]
    public class PessoaJuridica
    {
        [Key]
        public long CPF_CNPJ { get; set; }

        public string DS_RAZAO { get; set; }

        public string NM_FANTASIA { get; set; }

        public string DS_PORTE { get; set; }

        public string NR_COLABORADOR { get; set; }

        public string DT_FUNDACAO { get; set; }

        public string DS_CEP { get; set; }

        public string SG_UF { get; set; }

        public string DS_CIDADE { get; set; }

        public string DS_ESTADO { get; set; }

        public string DS_RUA { get; set; }

        public string NR_RESIDENCIA { get; set; }

        public string DS_COMPLEMENTO { get; set; }

        public string DS_LATITUTE { get; set; }

        public string DS_LONGITUDE { get; set; }

        public string DS_MAPA { get; set; }

        public string DS_EMAIL { get; set; }

        public string DS_TELEFONE { get; set; }

        public string DS_CELULAR { get; set; }

        public string DS_COMERCIAL { get; set; }

        public string DS_SETOR { get; set; }

        public string DS_ATIVIDADE { get; set; }

        public int QT_CLIENTES { get; set; }

        public int QT_VISITAS { get; set; }

        public int QT_REALIZADAS { get; set; }

        public int QT_HORAS { get; set; }
    }
}