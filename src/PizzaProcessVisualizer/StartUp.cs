using System;
using Microsoft.Azure.Functions.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection;
using Ably.PizzaProcess;
using IO.Ably;

[assembly: FunctionsStartup(typeof(StartUp))]
namespace Ably.PizzaProcess
{
    public class StartUp : FunctionsStartup
    {
        public override void Configure(IFunctionsHostBuilder builder)
        {
            builder.Services.AddSingleton<IRestClient>(
                new AblyRest(Environment.GetEnvironmentVariable("ABLY_APIKEY")));
        }
    }
}