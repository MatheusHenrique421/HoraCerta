using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;

namespace HoraCerta.Models
{
	public class ProfissionalViewModel
	{

		public Guid Id { get; set; } // Para edição

		[Required(ErrorMessage = "O nome do profissional é obrigatório.")]
		[StringLength(100, ErrorMessage = "O nome não pode ter mais de 100 caracteres.")]
		public string Nome { get; set; } = string.Empty;

		[Required(ErrorMessage = "O telefone é obrigatório.")]
		[Phone(ErrorMessage = "Telefone inválido.")]
		public string Telefone { get; set; } = string.Empty;

		[Required(ErrorMessage = "O e-mail é obrigatório.")]
		[EmailAddress(ErrorMessage = "E-mail inválido.")]
		public string Email { get; set; } = string.Empty;

		[Required(ErrorMessage = "Selecione a especialidade.")]
		public Guid EspecialidadeId { get; set; }

		// Listas para dropdowns
		public IEnumerable<SelectListItem>? Especialidades { get; set; }

		// Outras propriedades opcionais
		public string? Observacoes { get; set; }
		public bool Ativo { get; set; } = true;
	}
}
