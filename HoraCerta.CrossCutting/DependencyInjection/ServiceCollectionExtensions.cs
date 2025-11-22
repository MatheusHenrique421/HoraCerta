using Microsoft.Extensions.DependencyInjection;

namespace HoraCerta.CrossCutting.DependencyInjection;

public static class ServiceCollectionExtensions
{
	public static IServiceCollection AddDependencyInjection(this IServiceCollection services)
	{
		//Registro de dependências:
		#region Application Services
		//services.AddScoped<IProfissionalService, ProfissionalService>();
		#endregion

		#region Data Repositories
		//services.AddScoped<IProfissionalRepository, ProfissionalRepository>();
		#endregion

		// Adicione outros serviços, handlers, clients, etc.

		return services;
	}
}
