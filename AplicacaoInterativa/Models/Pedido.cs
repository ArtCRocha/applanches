using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AplicacaoInterativa.Models
{
    public class Pedido
    {
        public int PedidoId { get; set; }

        [Required(ErrorMessage = "Informe o seu nome: ")]
        [StringLength(50)]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Informe o seu sobrenome: ")]
        [StringLength(50)]
        public string Sobrenome { get; set; }

        [Required(ErrorMessage = "Informe o seu endereço 1: ")]
        [StringLength(100)]
        [Display(Name = "Endereço")]
        public string Endereco1 { get; set; }

        [StringLength(100)]
        [Display(Name = "Endereço")]
        public string Endereco2 { get; set; }

        [Required(ErrorMessage = "Informe o seu CEP: ")]
        [StringLength(10, MinimumLength = 8)]
        [Display(Name = "CEP")]
        public string Cep { get; set; }

        [StringLength(10)]
        public string Estado { get; set; }

        [StringLength(50)]
        public string Cidade { get; set; }

        [Required(ErrorMessage = "Informe o seu Telefone: ")]
        [StringLength(25)]
        [DataType(DataType.PhoneNumber)]
        public string Telefone { get; set; }


        [Required(ErrorMessage = "Informe o seu e-mail: ")]
        [StringLength(50)]
        [DataType(DataType.EmailAddress)]
        [RegularExpression(@"^[\w!#$%&'*+\-/=?\^_`{|}~]+(\.[\w!#$%&'*+\-/=?\^_`{|}~]+)*"
        + "@"
        + @"((([\-\w]+\.)+[a-zA-Z]{2,4})|(([0-9]{1,3}\.){3}[0-9]{1,3}))$", ErrorMessage = "O email é inválido.")]
        public string Email { get; set; }

        [ScaffoldColumn(false)]
        [Column(TypeName = "decimal(18,2)")]
        [Display(Name = "Total de pedidos")]
        public decimal PedidoTotal { get; set; }

        [ScaffoldColumn(false)]
        [Display(Name = "Itens no pedido")]
        public decimal TotalItensPedidos { get; set; }


        [Display(Name = "Data do pedido")]
        [DataType(DataType.Text)]
        [DisplayFormat(DataFormatString = "{0: dd/MM/yyyy hh:mm}")]
        public DateTime PedidoEnviado { get; set; }

        [Display(Name = "Data envio pedido")]
        [DataType(DataType.Text)]
        [DisplayFormat(DataFormatString = "{0: dd/MM/yyyy hh:mm}")]
        public DateTime? PedidoEntregueEm { get; set; }

        public List<PedidoDetalhe> PedidoItens { get; set; }





    }
}
