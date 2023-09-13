namespace mvc1.Models;

public class TesteRepository : IRepository
{
    private static List<Produto> produtos = new List<Produto>()
    {
        new Produto
        {
            ProdutoId = 1,
            Nome = "Produto 1",
            Categoria = "Categoria 1",
            Preco = 10
        },
        new Produto
        {
            ProdutoId = 2,
            Nome = "Produto 2",
            Categoria = "Categoria 2",
            Preco = 20
        },
        new Produto
        {
            ProdutoId = 3,
            Nome = "Produto 3",
            Categoria = "Categoria 3",
            Preco = 30
        }
    };
    public IEnumerable<Produto> Produtos
    {
        get => produtos;
    }
}
