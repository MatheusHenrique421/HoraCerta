using HoraCerta.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace HoraCerta.Controllers
{
	public class AgendamentoController : Controller
	{
		public IActionResult Criar()
		{
			var viewModel = new AgendamentoViewModel
			{
				Hora = DateTime.Now.TimeOfDay,
				Data = DateTime.Now.AddDays(0), // padrão
				Pessoas =
				[
					new SelectListItem { Value = "1", Text = "João da Silva" },
					new SelectListItem { Value = "2", Text = "Maria Souza" }
				],
				Profissionais =
				[
					new SelectListItem { Value = "1", Text = "Dr. Paulo" },
					new SelectListItem { Value = "2", Text = "Dra. Ana" }
				],
				Servicos =
				[
					new SelectListItem { Value = "1", Text = "Corte de Cabelo" },
					new SelectListItem { Value = "2", Text = "Massagem Relaxante" }
				]
			};

			return this.View(viewModel);
		}
	}
}
