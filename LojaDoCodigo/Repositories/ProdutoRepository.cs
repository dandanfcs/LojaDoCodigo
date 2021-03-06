using CasaDoCodigo.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LojaDoCodigo.Repositories
{
    public class ProdutoRepository : BaseRepository<Produto>, IProdutoRepository
    {
       public ProdutoRepository(ApplicationContext context): base (context)
        {

        }
        public void SaveProdutos(List<Livro> livros)
        {
            foreach (var livro in livros)
            {
               dbSet.Add(new Produto(livro.Codigo, livro.Nome, livro.Preco));
            }
            context.SaveChanges();
        }
        public List<Produto> GetProdutos()
        {
            return dbSet.ToList();
        }
    }
    public class Livro
    {
        public string Codigo { get; set; }
        public string Nome { get; set; }
        public float Preco { get; set; }
    }
}
