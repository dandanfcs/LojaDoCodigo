﻿using CasaDoCodigo.Models;
using LojaDoCodigo.Repositories;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace LojaDoCodigo
{

    class DataService : IDataService
    {
        private readonly ApplicationContext context;
        private readonly IProdutoRepository produtoRepository;
        public DataService(ApplicationContext context, IProdutoRepository produtoRepository)
        {
            this.context = context;
            this.produtoRepository = produtoRepository;
        }

        public void InicializarDB()
        {
            context.Database.EnsureCreated();

            List<Livro> livros = GetLivros();

            produtoRepository.SaveProdutos(livros);
        }   

        private static List<Livro> GetLivros()
        {
            var json = File.ReadAllText("livros.json");
            var livros = JsonConvert.DeserializeObject<List<Livro>>(json);
            return livros;
        }
    }
}


