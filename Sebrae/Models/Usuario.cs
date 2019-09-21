using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Sebrae.Models
{
    [Table("Usuarios")]
    public class Usuario : BaseModel
    {
        [Required(ErrorMessage = "O nome é obrigatório!", AllowEmptyStrings = false)]
        public string Nome { get; set; }

        [Required(ErrorMessage = "A Senha é obrigatória!", AllowEmptyStrings = false)]
        [StringLength(120, MinimumLength = 6)]
        public string Senha { get; set; }
    }
}