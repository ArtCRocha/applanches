using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AplicacaoInterativa.Models
{
    [Table("Categorias")]
    public class Categoria
    {   [Key]
        public int CategoriaId { get; set; }
        [StringLength(100,ErrorMessage = "Tamanho maximo de 100 caracteres.")]
        [Required(ErrorMessage ="Favor informar nome da categoria.")]
        public string Nome { get; set; }
        [StringLength(200, ErrorMessage = "Tamanho maximo de 100 caracteres.")]
        [Required(ErrorMessage = "Favor informar a descrição da categoria.")]
        public string Descricao { get; set; }

        public List<Lanche> Lanches { get; set; }

    }
}
