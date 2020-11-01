using System;
using System.Net.Http;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Text;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Tewr.Blazor.FileReader;
using BlazorMovies.Client.Helpers;
using BlazorMovies.Client.Repositories;

namespace BlazorMovies.Client
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("app");

            ConfigureServices(builder.Services);

            builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
            // builder.Services.AddFileReaderService(o => o.UseWasmSharedBuffer = true);

            await builder.Build().RunAsync();
        }

        public static void ConfigureServices(IServiceCollection services)
        {
            services.AddOptions(); // Authourisation system
            services.AddTransient<IRepository, RepositoryInMemory>(); // If we make a request for the IRepository service via Dependency Injection, then it will be served with the RepositoryInMemory class
            services.AddScoped<IHttpService, HttpServices>();
            services.AddScoped<IGenresRepository, GenresRepository>();
            services.AddScoped<IPeopleRepository, PeopleRepository>();
            services.AddScoped<IMoviesRepository, MoviesRepository>();
            services.AddFileReaderService(options => options.InitializeOnFirstCall = true);
        }

    }
}
