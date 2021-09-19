using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CADASTRO
{
    public class Produtos : EntidadeBase
    {
        private string Descricao { get; set; }
        private GrupoProdutos Grupo { get; set; }
        private string Unidade { get; set; }
        private decimal Valor { get; set; }
        private bool Status { get; set; }

        public Produtos(int id, string descricao, GrupoProdutos grupo, string unid, decimal valor)
        {
            this.Id = id;
            this.Descricao = descricao;
            this.Grupo = grupo;
            this.Unidade = unid;
            this.Valor = valor;
            this.Status = false;
        }

        public override string ToString()
        {
            string retorno = "";
            retorno += "Id: " + this.Id + Environment.NewLine;
            retorno += "Descrição: " + this.Descricao + Environment.NewLine;
            retorno += "Grupo: " + this.Grupo + Environment.NewLine;
            retorno += "Unid: " + this.Unidade + Environment.NewLine;
            retorno += "Valor: " + this.Valor + Environment.NewLine;
            retorno += "Status: " + this.Status;
            return retorno;
        }
        public string RetornaDescricao()
        {
            return this.Descricao;
        }
        public string RetornaUnid()
        {
            return this.Unidade;
        }
        public decimal RetornaValor()
        {
            return this.Valor;
        }
        public int RetornaId()
        {
            return this.Id;
        }
        public bool RetornaStatus()
        {
            return this.Status;
        }
        public void Excluir()
        {
            this.Status = true;
        }
    }
}
