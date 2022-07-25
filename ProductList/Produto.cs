using System;
using System.Collections.Generic;
using System.Text;

namespace ProductList
{
    class Produto
    {
        private string sTrNomePdt;
        private double dbPrecoPdt;
        private int intCodigoPdt;
        private int intQtdPdt;

        public string NomePdt { get { return sTrNomePdt; } set { sTrNomePdt = value; } }
        public double PrecoPdt { get {return dbPrecoPdt; } set { dbPrecoPdt = value; } }
        public int CodigoPdt { get { return intCodigoPdt; } set { intCodigoPdt = value; } }
        public int QtdPdt { get { return intQtdPdt; } set { intQtdPdt = value; } }

        public static void IncluirPrdoutos()
        {

            Produto novoPdt = new Produto();

            Console.WriteLine("-- INCLUSÃO DE PRODUTO --");
            
            Console.Write("Digite o nome do produto:");
            novoPdt.NomePdt = Console.ReadLine();
            Console.Write("Digite o preço de {0}:", novoPdt.NomePdt);
            novoPdt.PrecoPdt = double.Parse(Console.ReadLine());
            Console.Write("Digite a quantidade de {0}:", novoPdt.NomePdt);
            novoPdt.QtdPdt = int.Parse(Console.ReadLine());


            Console.WriteLine("\nPressione qualquer tecla para continuar.");
            Console.ReadKey();
            Console.Clear();

            ManipulacaoSQL Insert = new ManipulacaoSQL();
            Insert.InsertProduto(novoPdt.CodigoPdt, novoPdt.NomePdt, novoPdt.PrecoPdt, novoPdt.intQtdPdt);

            Console.WriteLine("\nPressione qualquer tecla para continuar.");
            
        }

        public static void AlterarProduto()
        {

            Produto produto = new Produto();

            Console.WriteLine("-- ALTERAÇÃO DE PRODUTO --");

            Console.Write("Digite o código do produto que deseja alterar:");
            produto.CodigoPdt = int.Parse(Console.ReadLine());

            Console.Write("Digite o novo nome do produto:");
            produto.NomePdt = Console.ReadLine();

            Console.Write("Digite o novo preço do produto:");
            produto.PrecoPdt = double.Parse(Console.ReadLine());

            Console.Write("Digite a nova quantidade do produto:");
            produto.QtdPdt = int.Parse(Console.ReadLine());


            Console.WriteLine("\nPressione qualquer tecla para continuar.");
            Console.ReadKey();

            ManipulacaoSQL Alterar = new ManipulacaoSQL();

            Alterar.UpdateProduto(produto.CodigoPdt, produto.NomePdt, produto.PrecoPdt, produto.QtdPdt);

            

        }

        public static void RemoverProduto()
        {

            Produto produto = new Produto();

            Console.WriteLine("-- REMOÇÃO DE PRODUTO --");

            Console.Write("Digite o código do produto:");
            produto.CodigoPdt = int.Parse(Console.ReadLine());

            ManipulacaoSQL Remover = new ManipulacaoSQL();

            Remover.DeleteProduto(produto.CodigoPdt);

            Console.WriteLine("\nPressione qualquer tecla para continuar.");
            Console.ReadKey();
            Console.Clear();

        }

        public static void ListarProdutos()
        {
            ManipulacaoSQL Listar = new ManipulacaoSQL();
            Listar.SelectProduto();
            

            Console.WriteLine("\nPressione qualquer tecla para continuar.");
            Console.ReadKey();
            Console.Clear();
        }

    }
}
