﻿using CasaDoCodigo.Models;
using System.Collections.Generic;

namespace LojaDoCodigo.Repositories
{
    public interface IProdutoRepository
    {
        void SaveProdutos(List<Livro> livros);
        List<Produto> GetProdutos();
    }
}