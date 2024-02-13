using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EntityFramework.Models
{
    [Table("PRODUTOS")]
    public class Produto
    {
        [Key]
        [Required]
        [Column("PROID")]
        public int Id { get; set; }

        [Required]
        [MaxLength(150)]
        [Column("PRONOME")]
        public string Nome { get; set; } = string.Empty;

        [Required]
        [Column("PROVALOR")]
        public double Valor { get; set; }

        [MaxLength(255)]
        [Column("PROURLIMAGEM")]
        public string? URLImagem { get; set; }

        [MaxLength]
        [Column("PRODESCRICAO")]
        public string? Descricao { get; set; }
   
    }
}