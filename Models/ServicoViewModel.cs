using System.ComponentModel.DataAnnotations;

namespace HoraCerta.Models
{
	public class ServicoViewModel
	{
		public Guid Id { get; set; }

		[Required(ErrorMessage = "O nome do serviço é obrigatório.")]
		public string Nome { get; set; } = string.Empty;

		[Required(ErrorMessage = "A descrição é obrigatória.")]
		public string Descricao { get; set; } = string.Empty;

		[Required(ErrorMessage = "O preço é obrigatório.")]
		[Range(0.01, 9999.99, ErrorMessage = "O preço deve ser maior que zero.")]
		public decimal Preco { get; set; }
	}
}
