using Microsoft.AspNetCore.Mvc;

namespace HoraCerta.Controllers
{
	public class ServicoController : Controller
	{
		public IActionResult Criar()
		{
			return this.View();
		}
	}
}
