using mvc1.Models;

namespace mvc1.Data;
public interface IRepository
{
    IEnumerable<Produto> Produtos { get; }
}