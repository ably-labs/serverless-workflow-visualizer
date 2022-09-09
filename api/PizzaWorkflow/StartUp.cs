using System;
using Microsoft.Azure.Functions.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection;
using PizzaWorkflow;
using IO.Ably;

[assembly: FunctionsStartup(typeof(StartUp))]
namespace PizzaWorkflow
{
    public class StartUp : FunctionsStartup
    {
        public override void Configure(IFunctionsHostBuilder builder)
        {
            builder.Services.AddSingleton<IRestClient>(
                new AblyRest(Environment.GetEnvironmentVariable("ABLY_API_KEY")));
        }
    }
}