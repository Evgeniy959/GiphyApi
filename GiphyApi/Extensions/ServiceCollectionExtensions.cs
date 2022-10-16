using GiphyApi.Options;
using GiphyApi.Services;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GiphyApi.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddGiphyApi(this IServiceCollection services, Action<GiphyApiOptions> options)
        {
            services.AddTransient<IGiphyApiService, GiphyApiService>();
            services.Configure<GiphyApiOptions>(options);
            return services;
        }
    }
}
