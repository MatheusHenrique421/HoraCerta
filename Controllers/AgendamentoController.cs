using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc;
using HoraCerta.Models;

namespace HoraCerta.Controllers;

public class AgendamentoController : Controller
{
	[HttpGet]
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

	[HttpPost]
	public IActionResult Criar(AgendamentoViewModel model)
	{
		//Construir o método de enviar
		return this.View();
	}

	[HttpGet]
	public IActionResult Listar(int? ano, int? mes)
	{
		var agora = DateTime.Now;
		var anoSelecionado = ano ?? agora.Year;
		var mesSelecionado = mes ?? agora.Month;

		// Exemplo estático – normalmente você puxaria do banco
		var agendamentos = new List<AgendamentoViewModel>
		{
			new()
			{
				Id = Guid.NewGuid(),
				Data = new DateTime(anoSelecionado, mesSelecionado, 4),
				NomePessoa = "João Silva",
				NomeServico = "Corte de cabelo",
				NomeProfissional = "Marcos"
			},
			new()
			{
				Id = Guid.NewGuid(),
				Data = new DateTime(anoSelecionado, mesSelecionado, 18),
				NomePessoa = "Maria",
				NomeServico = "Manicure",
				NomeProfissional = "Ana"
			}
		};

		var model = new CalendarioViewModel
		{
			Ano = anoSelecionado,
			Mes = mesSelecionado,
			Agendamentos = agendamentos
		};

		return View(model);
	}

}
