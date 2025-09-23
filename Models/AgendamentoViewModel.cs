using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;

namespace HoraCerta.Models
{
	public class AgendamentoViewModel
	{
		public Guid Id { get; set; }

		[Required(ErrorMessage = "A data e hora são obrigatórias.")]
		[Display(Name = "Data e Hora")]
		public DateTime Data { get; set; }

		[Required(ErrorMessage = "Selecione uma pessoa.")]
		public TimeSpan Hora { get; set; }

		[Required(ErrorMessage = "Selecione uma pessoa.")]
		[Display(Name = "Cliente")]
		public Guid PessoaId { get; set; }
		public string? NomePessoa { get; set; }

		[Required(ErrorMessage = "Selecione um profissional.")]
		[Display(Name = "Profissional")]
		public Guid ProfissionalId { get; set; }
		public string? NomeProfissional { get; set; }

		[Required(ErrorMessage = "Selecione um serviço.")]
		[Display(Name = "Serviço")]
		public Guid ServicoId { get; set; }
		public string? NomeServico { get; set; }

		public string? Observacao { get; set; }

		// Listas para popular os Dropdowns
		public IEnumerable<SelectListItem>? Pessoas { get; set; }
		public IEnumerable<SelectListItem>? Profissionais { get; set; }
		public IEnumerable<SelectListItem>? Servicos { get; set; }
	}

}
