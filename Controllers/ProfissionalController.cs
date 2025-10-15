using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc;
using HoraCerta.Models;

namespace HoraCerta.Controllers;

public class ProfissionalController : Controller
{
	[HttpGet]
	public IActionResult Criar()
	{
		//Terminar de construir o endpint
		var model = new ProfissionalViewModel
		{

			Especialidades =
			[
				new SelectListItem { Value ="1", Text = "Tintura" },
				new SelectListItem { Value ="2", Text = "Corte" }
			]
		};

		return this.View(model);
	}

	[HttpPost]
	[ValidateAntiForgeryToken] // Proteção contra CSRF
	public IActionResult Criar(ProfissionalViewModel model)
	{
		//Terminar de construir o endpint
		// ... Lógica de POST

		return this.View(model);
	}

	[HttpGet]
	public IActionResult Listar()
	{
		//Terminar de construir o endpint
		var model = new ProfissionalViewModel
		{

			Especialidades =
			[
				new SelectListItem { Value ="1", Text = "Tintura" },
				new SelectListItem { Value ="2", Text = "Corte" }
			]
		};

		return this.View(model);
	}

}
