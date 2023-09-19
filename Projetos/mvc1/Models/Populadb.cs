using Microsoft.EntityFrameworkCore;
using mvc1.Data;

namespace mvc1.Models
{
    public static class Populadb
    {
        public static void IncluiDadosDB(IServiceProvider serviceProvider)
        {
            using (var scope = serviceProvider.CreateScope())
            {
                var context = scope.ServiceProvider.GetRequiredService<AppDbContext>();
                System.Console.WriteLine("Aplicando Migrations...");
                context.Database.Migrate();

                if (!context.Produtos.Any())
                {
                    System.Console.WriteLine("Criando dados...");
                    context.Produtos.AddRange(
                        new Produto("Luvas de goleiro", "Futebol", 25),
                        new Produto("Bola de basquete", "Basquete", 48.95m),
                        new Produto("Bola de Futebol", "Futebol", 19.50m),
                        new Produto("Óculos para natação", "Aquaticos", 34.95m),
                        new Produto("Meias Grandes", "Futebol", 50),
                        new Produto("Calção de banho", "Aquáticos", 16),
                        new Produto("Cesta para quadra", "Basquete", 29.95m)
                    );
                    context.SaveChanges();
                }
                else
                {
                    System.Console.WriteLine("Dados já existem...");
                }
            }
        }

    }
}