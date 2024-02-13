using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EntityFramework.Models
{
    [Table("CLIENTES")]
    public class Cliente
    {
        [Key]
        [Required]
        [Column("CLIID")]
        public int Id { get; set; }

        [MaxLength(150)]
        [Column("CLINOME")]
        [Required]
        public string Nome { get; set; } = string.Empty;

        [Required]
        [Column("CLIENDERECO")]
        public int EnderecoId { get; set; }

        [ForeignKey("EnderecoId")]
        public virtual Endereco? Endereco { get; set; }
    }
}