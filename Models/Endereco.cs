using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EntityFramework.Models
{
    [Table("ENDERECOS")]
    public class Endereco
    {
        [Key]
        [Required]
        [Column("ENDID")]
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        [Column("ENDRUA")]
        public string Rua { get; set; } = string.Empty;

        [Required]
        [Column("ENDNUMERO")]
        public int Numero { get; set; }

        [Column("ENDCOMPLEMENTO")]
        public string? Complemento { get; set; }

        [Required]
        [MaxLength(50)]
        [Column("ENDBAIRRO")]
        public string Bairro { get; set; } = string.Empty;

        [Required]
        [MaxLength(50)]
        [Column("ENDCIDADE")]
        public string Cidade { get; set; } = string.Empty;

        [Required]
        [MaxLength(50)]
        [Column("ENDESTADO")]
        public string Estado { get; set; } = string.Empty;

        [Required]
        [MaxLength(50)]
        [Column("ENDPAIS")]
        public string Pais { get; set; } = string.Empty;

        [Required]
        [MaxLength(20)]
        [Column("ENDCEP")]        
        public string CEP { get; set; } = string.Empty;

        public virtual Cliente? Cliente { get; set; }
    }
}