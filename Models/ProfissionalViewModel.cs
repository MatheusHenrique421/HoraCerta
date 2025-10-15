using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;

namespace HoraCerta.Models
{
	public class ProfissionalViewModel
	{
		public Guid Id { get; set; }

		[Required(ErrorMessage = "O nome do profissional é obrigatório.")]
		[StringLength(100, ErrorMessage = "O nome não pode ter mais de 100 caracteres.")]
		public string Nome { get; set; } = string.Empty;

		[Required(ErrorMessage = "O sobrenome do profissional é obrigatório.")]
		[StringLength(100, ErrorMessage = "O sobrenome não pode ter mais de 100 caracteres.")]
		public string Sobrenome { get; set; } = string.Empty;

		[Phone(ErrorMessage = "Telefone inválido.")]
		public string Telefone { get; set; } = string.Empty;

		[Required(ErrorMessage = "O WhatsApp é obrigatório.")]
		[Phone(ErrorMessage = "WhatsApp inválido.")]
		public string WhatsApp { get; set; } = string.Empty;

		[Required(ErrorMessage = "O e-mail é obrigatório.")]
		[EmailAddress(ErrorMessage = "E-mail inválido.")]
		public string Email { get; set; } = string.Empty;

		public string? Instagram { get; set; } = string.Empty;

		[Required(ErrorMessage = "Selecione ao menos uma especialidade.")]
		public Guid EspecialidadesIdSelecionadas { get; set; }

		public string? EspecialidadesSelecionadas { get; set; } // O nome DEVE ser igual ao 'name' do input hidden

		// Listas para dropdowns		
		public IEnumerable<SelectListItem>? Especialidades { get; set; }

		// Outras propriedades opcionais
		public string? Observacao { get; set; }
	}
}
