using Catalog.API.Models;

namespace Catalog.API.Data
{
    //Classe criada para popular o banco (temporaria de inicio de projeto)
    public static class CatalogContextSeed
    {
        public static async Task SeedAsync(CatalogContext context)
        {
            await context.Database.EnsureCreatedAsync();

            if (!context.CatalogItems.Any())
            {
                context.CatalogItems.AddRange(
                    new CatalogItem { Name = "Camiseta .NET Architecture", Description = "Camiseta oficial .NET", Price = 59.90m, StockQuantity = 100 },
                    new CatalogItem { Name = "Caneca Docker & Kubernetes", Description = "Caneca temática para devs", Price = 35.00m, StockQuantity = 50 },
                    new CatalogItem { Name = "Livro Microservices in .NET", Description = "Guia completo de arquitetura", Price = 120.00m, StockQuantity = 30 }
                );

                await context.SaveChangesAsync();
            }
        }
    }
}
