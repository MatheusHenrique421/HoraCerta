using Microsoft.AspNetCore.Mvc;

namespace HoraCerta.Controllers
{
	public class ProfissionalController : Controller
	{
		public IActionResult Criar()
		{
			return this.View();
		}
	}
}
