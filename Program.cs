using System;

namespace CADASTRO
{
    class Program
    {
        static ModeloProdutos modeloprodutos = new ModeloProdutos();
        static void Main(string[] args)
        {

            string cadastroProduto = TelaCadastroProdutos();
            while (cadastroProduto.ToUpper() != "X")
            {
                switch (cadastroProduto)
                {
                    case "1":
                        ListarProdutos();
                        break;
                    case "2":
                        InserirProduto();
                        break;
                    case "3":
                        AlterarProduto();
                        break;
                    case "4":
                        ExcluirProduto();
                        break;
                    case "5":
                        VisualizarProduto();
                        break;
                    case "C":
                        Console.Clear();
                        break;

                    default:
                        throw new ArgumentOutOfRangeException();
                }
                cadastroProduto = TelaCadastroProdutos();
            }
        }

        private static string TelaCadastroProdutos()
        {
            Console.WriteLine();
            Console.WriteLine("-- CADASTRO DE PRODUTO --");
            Console.WriteLine();
            Console.WriteLine("1 - Listar Produtos");
            Console.WriteLine("2 - Inserir novo Produto");
            Console.WriteLine("3 - Alterar");
            Console.WriteLine("4 - Excluir");
            Console.WriteLine("5 - Visualizar Grupo");
            Console.WriteLine("C - Limpar tela");
            Console.WriteLine("X - Sair");
            Console.WriteLine();

            string telaCadastroProduto = Console.ReadLine().ToUpper();
            Console.WriteLine();
            return telaCadastroProduto;
        }

        private static void ListarProdutos()
        {
            Console.WriteLine("Listar Produtos");

            var lista = modeloprodutos.Lista();

            if (lista.Count == 0)
            {
                Console.WriteLine("Nenhum Produto cadastrado.");
                return;
            }
            foreach (var produto in lista)
            {
                var status = produto.RetornaStatus();

                Console.WriteLine("#ID: {0}: - {1} - {2} - {3} - {4}", produto.RetornaId(), produto.RetornaDescricao(),produto.RetornaUnid(),produto.RetornaValor(), status ? "Excluido" : "");
            }
        }
        private static void InserirProduto()
        {
            Console.WriteLine("Inserir novo produto");

            foreach (int i in Enum.GetValues(typeof(GrupoProdutos)))
            {
                Console.WriteLine("{0} - {1}", i, Enum.GetName(typeof(GrupoProdutos), i));
            }

            Console.WriteLine("Digite o grupo entre as opções acima: ");
            int entradaGrupo = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite a descrição do Produto: ");
            string entradaDescr = Console.ReadLine();

            Console.WriteLine("Digite a unidade do Produto: ");
            string entradaUnid = Console.ReadLine();

            Console.WriteLine("Digite o preço do Produto: ");
            string entradaPreco = Console.ReadLine();

            Produtos novoProduto = new Produtos(id: modeloprodutos.ProximoId(), grupo: (GrupoProdutos)entradaGrupo, descricao: entradaDescr, unid: entradaUnid,
                valor: Convert.ToDecimal(entradaPreco));

            modeloprodutos.Inserir(novoProduto);
        }
        private static void AlterarProduto()
        {
            Console.WriteLine("Digite o Id do Produto");
            int indiceProduto = int.Parse(Console.ReadLine());

            foreach (int i in Enum.GetValues(typeof(GrupoProdutos)))
            {
                Console.WriteLine("{0} - {1}", i, Enum.GetName(typeof(GrupoProdutos), i));
            }

            Console.WriteLine("Digite o grupo entre as opções acima: ");
            int entradaGrupo = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite a descrição do Produto: ");
            string entradaDescr = Console.ReadLine();

            Console.WriteLine("Digite a unidade do Produto: ");
            string entradaUnid = Console.ReadLine();

            Console.WriteLine("Digite o preço do Produto: ");
            string entradaPreco = Console.ReadLine();

            Produtos alterarProduto = new Produtos(id: modeloprodutos.ProximoId(), grupo: (GrupoProdutos)entradaGrupo, descricao: entradaDescr, unid: entradaUnid,
                valor: Convert.ToDecimal(entradaPreco));

            modeloprodutos.Alterar(indiceProduto,alterarProduto);
        }
        private static void ExcluirProduto()
        {
            Console.WriteLine("Digite o Id doProduto");
            int indiceProduto = int.Parse(Console.ReadLine());

            modeloprodutos.Excluir(indiceProduto);
        }
        private static void VisualizarProduto()
        {
            Console.WriteLine("Digite o Id do Produto");
            int indiceProduto = int.Parse(Console.ReadLine());

            var produto = modeloprodutos.RetornaPorID(indiceProduto);

            Console.WriteLine(produto);
        }
    }
}
