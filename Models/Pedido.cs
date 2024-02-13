using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EntityFramework.Models
{
    [Table("PEDIDOS")]
    public class Pedido
    {
        [Key]
        [Required]
        [Column("PEDID")]
        public int Id { get; set; }

        [Required]
        [Column("PEDDATA")]
        public DateTime Data { get; set; }

        [Required]
        [Column("PEDVALORTOTAL")]
        public double ValorTotal { get; set; }

        [Required]
        [Column("PEDCLIID")]
        public int ClienteId { get; set; }

        [ForeignKey("ClienteId")]
        public virtual Cliente? Cliente { get; set; }
    }
}