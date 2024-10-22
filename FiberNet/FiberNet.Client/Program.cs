using FiberNet.Client;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using MudBlazor.Services;

namespace FiberNet.Client
{
	internal class Program
	{
		static async Task Main(string[] args)
		{
			var builder = WebAssemblyHostBuilder.CreateDefault(args);

			builder.Services.AddAuthorizationCore();
			builder.Services.AddCascadingAuthenticationState();
			builder.Services.AddSingleton<AuthenticationStateProvider, PersistentAuthenticationStateProvider>();
			builder.Services.AddMudServices();
			await builder.Build().RunAsync();
		}
	}
}
