using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Casamento.Model
{
    public class Pessoa
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="Campo nome obrigatório")]
        [MaxLength(30, ErrorMessage ="Tamanho máximo para este campo é de 30 caracteres")]
        public string Nome { get; set; }
        [MaxLength(30, ErrorMessage = "Tamanho máximo para este campo é de 30 caracteres")]
        [Required(ErrorMessage = "Campo Sobrenome obrigatório")]
        public string Sobrenome { get; set; }
    }
}
