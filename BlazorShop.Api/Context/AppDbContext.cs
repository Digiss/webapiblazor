
using BlazorShop.Api.Entities;
using Microsoft.EntityFrameworkCore;

namespace BlazorShop.Api.Context;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    { }

    public DbSet<Carrinho>? Carrinhos { get; set; }
    public DbSet<CarrinhoItem>? CarrinhoItens { get; set; }
    public DbSet<Produto>? Produtos { get; set; }
    public DbSet<Categoria>? Categorias { get; set; }
    public DbSet<Usuario>? Usuarios { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        // Produtos
        // Blusa Category
        modelBuilder.Entity<Produto>().HasData(new Produto
        {
            Id = 1,
            Nome = "Blusa Scuderia Ferrari '24",
            Descricao = "Peça para uma criança desenhar um carro, e ela certamente o fará vermelho. -Enzo Ferrari",
            ImagemUrl = "/Imagens/Blusas/ferrari.webp",
            Preco = 100,
            Quantidade = 100,
            CategoriaId = 1
        });

        modelBuilder.Entity<Produto>().HasData(new Produto
        {
            Id = 2,
            Nome = "Blusa Mercedes-Benz AMG Petronas",
            Descricao = "Blusa utilizada pelo pitcrew Mercedes em 2024",
            ImagemUrl = "/Imagens/Blusas/mercedes.webp",
            Preco = 345,
            Quantidade = 123,
            CategoriaId = 1
        });

        modelBuilder.Entity<Produto>().HasData(new Produto
        {
            Id = 3,
            Nome = "Blusa ORACLE Red Bull Racing",
            Descricao = "Blusa utilizada pelo pitcrew Red Bull em 2024",
            ImagemUrl = "/Imagens/Blusas/redbull.AVIF",
            Preco = 400,
            Quantidade = 97,
            CategoriaId = 1
        });

        modelBuilder.Entity<Produto>().HasData(new Produto
        {
            Id = 4,
            Nome = "Blusa Scuderia Ferrari (Azul)",
            Descricao = "Blusa utilizada pelo pitcrew Ferrari no GP de Miami de 2024",
            ImagemUrl = "/Imagens/Blusas/ferrariazul.webp",
            Preco = 670,
            Quantidade = 35,
            CategoriaId = 1
        });

        // Camisas Category
        modelBuilder.Entity<Produto>().HasData(new Produto
        {
            Id = 5,
            Nome = "Camisa Scuderia Ferrari",
            Descricao = "Replica da polo utilizada pelo pitcrew Scuderia Ferrari",
            ImagemUrl = "/Imagens/camisas/ferrarivermelha1.webp",
            Preco = 670,
            Quantidade = 120,
            CategoriaId = 3
        });

        modelBuilder.Entity<Produto>().HasData(new Produto
        {
            Id = 6,
            Nome = "Camisa Scuderia Ferrari (WEC)",
            Descricao = "Replica da polo utilizada pelo pitcrew Scuderia Ferrari (WEC)",
            ImagemUrl = "/Imagens/camisas/ferrarivermelha2.jpg",
            Preco = 560,
            Quantidade = 30,
            CategoriaId = 3
        });

        modelBuilder.Entity<Produto>().HasData(new Produto
        {
            Id = 7,
            Nome = "Camisa Scuderia Ferrari (GP de Miami '24)",
            Descricao = "Replica da polo utilizada pelo pitcrew Scuderia Ferrari no GP de Miami de 2024",
            ImagemUrl = "/Imagens/camisas/ferrariazul.webp",
            Preco = 780,
            Quantidade = 67,
            CategoriaId = 3
        });

        modelBuilder.Entity<Produto>().HasData(new Produto
        {
            Id = 8,
            Nome = "Camisa ORACLE Red Bull Racing",
            Descricao = "Replica da polo utilizada pelo pitcrew da RBR",
            ImagemUrl = "/Imagens/camisas/redbull.webp",
            Preco = 380,
            Quantidade = 266,
            CategoriaId = 3
        });

modelBuilder.Entity<Produto>().HasData(new Produto
{
    Id = 9,
    Nome = "Camisa ORACLE Red Bull Racing (Branca)",
    Descricao = "Replica da polo utilizada pelo pitcrew da RBR",
    ImagemUrl = "/Imagens/camisas/redbull2.webp",
    Preco = 280,
    Quantidade = 152,
    CategoriaId = 3
});

        modelBuilder.Entity<Produto>().HasData(new Produto
        {
            Id = 10,
            Nome = "Camisa Mercedes-Benz AMG Petronas",
            Descricao = "Replica da polo utilizada pelo pitcrew da Mercedes",
            ImagemUrl = "/Imagens/camisas/mercedespreta.webp",
            Preco = 540,
            Quantidade = 248,
            CategoriaId = 3
        });

        modelBuilder.Entity<Produto>().HasData(new Produto
        {
            Id = 11,
            Nome = "Camisa Mercedes-Benz AMG Petronas (branca)",
            Descricao = "Replica da polo utilizada pelo pitcrew da Mercedes",
            ImagemUrl = "/Imagens/camisas/mercedesbranca.webp",
            Preco = 540,
            Quantidade = 424,
            CategoriaId = 3
        });

        modelBuilder.Entity<Produto>().HasData(new Produto
        {
            Id = 12,
            Nome = "Camisa Lewis 44",
            Descricao = "Camisa feita para uso de Fans",
            ImagemUrl = "/Imagens/camisas/mercedesamarela.webp",
            Preco = 780,
            Quantidade = 22,
            CategoriaId = 3
        });
    }
}