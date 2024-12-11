// Liste des url 
// Page /Category/Details/{id} :
// Affiche les détails d’une catégorie et tous ses produits associés.
// Page /Category/CategoriesWithExpensiveProducts?price=500 : 
// Liste les catégories contenant au moins un produit avec un prix supérieur à 500.



using Microsoft.EntityFrameworkCore; // Nécessaire pour configurer le DbContext
using Exercice.Models; 
using Microsoft.AspNetCore.Builder; // Nécessaire pour configurer le pipeline d'exécution
using Microsoft.Extensions.DependencyInjection; 
using Microsoft.Extensions.Hosting;

var builder = WebApplication.CreateBuilder(args);

// Ajouter DbContext pour SQL Server
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

// Ajouter les services pour MVC
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configurer le pipeline d'exécution
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
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
