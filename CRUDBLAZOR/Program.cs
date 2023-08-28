using CRUDBLAZOR;
using CRUDBLAZOR.Services;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;


var builder = WebApplication.CreateBuilder(args);

builder.Services.AddSingleton<List<Elemento>>();
builder.Services.AddSingleton<Elemento>();
builder.Services.AddTransient<ISwitchService, SwitchService>();
builder.Services.AddSingleton<IFillMockData, FillMockData>();
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();


var app = builder.Build();


app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();

