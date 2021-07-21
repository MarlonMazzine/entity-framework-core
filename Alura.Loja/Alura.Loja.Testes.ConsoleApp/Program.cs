using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Alura.Loja.Testes.ConsoleApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            using (var contexto = new LojaContext())
            {
                var produtos = contexto.Produtos.ToList();

                EixibirEntries(contexto.ChangeTracker.Entries());

                var novoProduto = new Produto()
                {
                    Nome = "Sabão em pó",
                    Categoria = "Limpeza",
                    Preco = 4.99
                };

                contexto.Produtos.Add(novoProduto);
                contexto.Remove(novoProduto);
                EixibirEntries(contexto.ChangeTracker.Entries());
                contexto.SaveChanges();
                EixibirEntries(contexto.ChangeTracker.Entries());
            }
        }

        private static void EixibirEntries(IEnumerable<EntityEntry> entries)
        {
            Console.WriteLine("=====================");

            foreach (var e in entries)
            {
                Console.WriteLine(e.Entity.ToString() + " - " + e.State);
            }
        }
    }
}
