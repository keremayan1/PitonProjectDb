using Core.Extensions;
using Core.Utilities.Services;
using FluentValidation.AspNetCore;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using MVCUI.Extensions;
using MVCUI.Services.Abstract;
using MVCUI.Services.Concrete;
using MVCUI.Validators.FluentValidation;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDependencyResolvers(builder.Configuration, new ServicesExtension());


// Add services to the container.
builder.Services.AddControllersWithViews().AddFluentValidation(fv=>fv.RegisterValidatorsFromAssemblyContaining<AddPlanValidator>());

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
