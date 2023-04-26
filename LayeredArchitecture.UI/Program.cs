using LayeredArchitecture.DAL;
using LayeredArchitecture.ENT;
using LayeredArchitecture.REP.Abstracts;
using LayeredArchitecture.REP.Concretes;
using LayeredArchitecture.UI.Models.ViewModel;
using LayeredArchitecture.UOW;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<Context>(options =>
        options.UseSqlServer(builder.Configuration.GetConnectionString("LayeredArchitecture")));
builder.Services.AddScoped<ICatRepos, CatRepos<Categories>>();
builder.Services.AddScoped<IProdRepos, ProdRepos<Products>>();
builder.Services.AddScoped<IUow, Uow>();
builder.Services.AddScoped<CategoriesModel>();
builder.Services.AddScoped<ProductsModel>();

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

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();