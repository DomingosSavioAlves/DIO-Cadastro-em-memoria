using CADASTRO.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CADASTRO
{
    public class ModeloProdutos : Modelo<Produtos>
    {
        List<Produtos> ListaProdutos = new List<Produtos>();
        public void Alterar(int id, Produtos objeto)
        {
           ListaProdutos[id]=objeto;
        }

        public void Excluir(int id)
        {
            ListaProdutos[id].Excluir();
        }

        public void Inserir(Produtos objeto)
        {
            ListaProdutos.Add(objeto);
        }

        public List<Produtos> Lista()
        {
            return ListaProdutos;
        }

        public int ProximoId()
        {
            return ListaProdutos.Count;
        }

        public Produtos RetornaPorID(int id)
        {
            return ListaProdutos[id];
        }
    }
}
