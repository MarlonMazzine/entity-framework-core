using System.Collections.Generic;

namespace Alura.Loja.Testes.ConsoleApp
{
    interface IProdutoDAO
    {
        void Adcionar(Produto p);
        void Atualizar(Produto p);
        void Remover(Produto p);
        IList<Produto> Produtos();
    }
}
