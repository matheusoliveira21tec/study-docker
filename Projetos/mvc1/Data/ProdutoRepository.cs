using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using mvc1.Models;

namespace mvc1.Data
{
    public class ProdutoRepository : IRepository
    {
        private AppDbContext context;
        public ProdutoRepository(AppDbContext ctx)
        {
            context = ctx;
        }
        public IEnumerable<Produto> Produtos => context.Produtos;
    }
}