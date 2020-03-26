using ProseKit.AspNetCore.Services;

namespace Microsoft.Extensions.DependencyInjection
{
	public static class ProseServiceExtensions
	{
		public static IServiceCollection AddProse(this IServiceCollection services)
		{
			services.AddScoped<ProseContext>();
			return services;
		}
	}
}
