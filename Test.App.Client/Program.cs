using Test.App.Client;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Test.App.Client.ViewModels;

var builder = WebAssemblyHostBuilder.CreateDefault(args);

builder.Services.AddAuthorizationCore();
builder.Services.AddCascadingAuthenticationState();
builder.Services.AddSingleton<AuthenticationStateProvider, PersistentAuthenticationStateProvider>();

// FIXME: This is also required (which I expect) but why is it also required in Test.App?! 
builder.Services.AddSingleton<TestViewModel>();

await builder.Build().RunAsync();
