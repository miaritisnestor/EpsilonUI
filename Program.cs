using EpsilonUI;
using EpsilonUI.StateContainers;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri("https://localhost:7190/") }); //builder.HostEnvironment.BaseAddress
builder.Services.AddSingleton<CustomerStateContainer>();

await builder.Build().RunAsync();
