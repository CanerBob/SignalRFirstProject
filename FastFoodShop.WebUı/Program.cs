using DataAccessLayer.Database;
using FastFoodShop.WebUý.Dependensies;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.Authorization;
using Microsoft.EntityFrameworkCore;
var requiredAuthorizePolicy=new AuthorizationPolicyBuilder().RequireAuthenticatedUser().Build();
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDependencyServices(builder.Configuration);
builder.Services.AddIdentity<AppUser, AppRole>().AddEntityFrameworkStores<AppDbContext>();
// Add services to the container.
builder.Services.AddControllersWithViews(opt => 
{
	opt.Filters.Add(new AuthorizeFilter(requiredAuthorizePolicy));
});
builder.Services.ConfigureApplicationCookie(opt =>
{
	opt.LoginPath = "/Login/Index/";
});
builder.Services.AddHttpClient();
builder.Services.AddDependencyServices(builder.Configuration);
var app = builder.Build();
// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
	app.UseExceptionHandler("/Home/Error");
	// The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
	app.UseHsts();
}
app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();
app.UseAuthentication();
app.UseAuthorization();
app.MapControllerRoute(
	name: "default",
	pattern: "{controller=Default}/{action=Index}/{id?}");
app.Run();