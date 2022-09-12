using System;
using IO.Ably;
using Microsoft.Azure.Functions.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection;
using Pizza;

[assembly: FunctionsStartup(typeof(Startup))]
namespace Pizza
{
    public class Startup : FunctionsStartup
    {
        public override void Configure(IFunctionsHostBuilder builder)
        {
            var ablyApiKey = Environment.GetEnvironmentVariable("ABLY_API_KEY");
            var ablyClient = new AblyRest(ablyApiKey);
            builder.Services.AddSingleton<IRestClient>(ablyClient);
            builder.Services.AddHttpClient("Workflow", httpClient =>
            {
                httpClient.BaseAddress = new Uri(Environment.GetEnvironmentVariable("WORKFLOW_FUNCTION_URL"));
                httpClient.DefaultRequestHeaders.Add("x-functions-key", Environment.GetEnvironmentVariable("WORKFLOW_FUNCTION_KEY"));
            });
        }
    }
}
