using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EntityFramework.Models
{
    [Table("PEDIDOPRODUTOS")]
    public class PedidoProduto
    {
        [Key]
        [Required]
        [Column("PEDPRODID")]
        public int Id { get; set; }

        [Required]
        [Column("PEDPROQUANTIDADE")]
        public int Quantidade { get; set; }

        [Required]
        [Column("PEDPRODPEDIDOID")]
        public int PedidoId { get; set; }

        [ForeignKey("PedidoId")]
        public virtual Pedido? Pedido { get; set; }

        [Required]
        [Column("PEDPRODPRODUTOID")]
        public int ProdutoId { get; set; }

        [ForeignKey("ProdutoId")]
        public virtual Produto? Produto { get; set; }
    }
}