using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;

namespace IdentitySample
{
	public static class Program
	{
		public static void Main(string[] args)
		{
			BuildWebHost(args).Run();
		}

		public static IWebHost BuildWebHost(string[] args) =>
		   WebHost.CreateDefaultBuilder(args)
			   .UseStartup<Startup>()
			  .ConfigureAppConfiguration((hostContext, config) =>
			  {
				  // delete all default configuration providers
				  config.Sources.Clear();
				  config.AddJsonFile("appsettings.json", optional: true);
			  })
			  .Build();
	}
}