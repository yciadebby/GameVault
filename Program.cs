using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using GameVault;
using GameVault.Services;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

// GameVault Services
builder.Services.AddSingleton<ToastService>();
builder.Services.AddSingleton<LocalStorageService>();
builder.Services.AddSingleton<GameVaultState>();

var host = builder.Build();

// Hydrate stored state on startup
var state = host.Services.GetRequiredService<GameVaultState>();
await state.InitializeAsync();

await host.RunAsync();
