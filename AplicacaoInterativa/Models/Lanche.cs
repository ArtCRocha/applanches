using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AplicacaoInterativa.Models
{
    [Table("Lanches")]
    public class Lanche
    {
        [Key]
        public int LancheId { get; set; }

        [StringLength(80, MinimumLength = 10, ErrorMessage = "O mínimo de caracteres é 10 máximo de caracteres é 80")]
        [Required(ErrorMessage = "Informe o nome do lanche")]
        [Display(Name = "Nome do lanche")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Informe a descrição do lanche")]
        [Display(Name = "Descrição da Categoria")]
        [MinLength(20, ErrorMessage = "O mínimo de caracteres é 20")]
        [MaxLength(200, ErrorMessage = "O máximo de caracteres é 200")]
        public string DescricaoCurta { get; set; }

        [Required(ErrorMessage = "Informe a descrição detalhada do lanche")]
        [Display(Name = "Descrição detalhada da Categoria")]
        [MinLength(40, ErrorMessage = "O mínimo de caracteres é 40")]
        [MaxLength(300, ErrorMessage = "O máximo de caracteres é 300")]
        public string DescricaoDetalhada { get; set; }

        [Required(ErrorMessage = "Informe o preço do lanche")]
        [Display(Name = "Preço")]
        [Column(TypeName = "decimal(10, 2)")]
        [Range(1, 999.99, ErrorMessage = "O preço deve variar entre 1 e 999.99")]
        public decimal Preco { get; set; }

        [Display(Name = "Caminho Imagem")]
        [StringLength(200, ErrorMessage = "O máximo de caracteres é 200")]
        public string ImagemUrl { get; set; }

        [Display(Name = "Caminho Imagem Miniatura")]
        [StringLength(200, ErrorMessage = "O máximo de caracteres é 200")]
        public string ImagemThumbnailUrl { get; set; }

        [Display(Name = "Preferido?")]
        public bool IsLanchePreferido { get; set; }

        [Display(Name = "Estoque")]
        public bool EmEstoque { get; set; }


        public int CategoriaId { get; set; }

        public virtual Categoria Categoria { get; set; }
    }
}
