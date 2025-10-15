namespace HoraCerta.Models;

public class CalendarioViewModel
{
	public int Ano { get; set; }
	public int Mes { get; set; }
	public IEnumerable<AgendamentoViewModel> Agendamentos { get; set; } = Enumerable.Empty<AgendamentoViewModel>();

	public string NomeMes => new DateTime(Ano, Mes, 1).ToString("MMMM yyyy");
}
