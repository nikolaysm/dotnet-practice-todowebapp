using Microsoft.AspNetCore.Http.Json;
using Microsoft.AspNetCore.Mvc.Routing;
using Microsoft.Extensions.Options;
using Microsoft.Net.Http.Headers;
using System.Net.Http.Headers;
using System.Text.Json;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();

// Begin HTTP client code

// Comments
// Add IHTTPClientFactory to the container and set the name of the factory
// to "ToDoAPI". The base address for the API requests is also set


// Code to add


builder.Services.AddHttpClient("ToDoAPI", httptClient => {
    httptClient.BaseAddress = new Uri("https://todoapinksm3.azurewebsites.net/ToDoList/");
});

// End of  HTTP client code

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();
