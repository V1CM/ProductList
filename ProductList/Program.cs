using System;


namespace ProductList
{
    class Program
    {
        private static void TimeExit()
        {
            Console.Clear();

            for (int i = 3; i >= 1; i--)
            {
                Console.Clear();
                Console.WriteLine("Saindo em:" + i);
                System.Threading.Thread.Sleep(1000);
            }
           
        }

        static void Main(string[] args)
        {
            string r;
            do
            {
                Console.WriteLine("Bem - Vindo, usuário!");
                Console.WriteLine("Selecione uma opção.");
                Console.WriteLine("\n<1> Incluir Produto");
                Console.WriteLine("<2> Alterar Produto");
                Console.WriteLine("<3> Remover Produto");
                Console.WriteLine("<4> Listar Produtos");
                Console.WriteLine("<5> Sair");

                Console.Write("\nR:");
                r = Console.ReadLine();

                switch (r)
                {
                    case "1":
                        Console.Clear();
                        Produto.IncluirPrdoutos();
                        break;
                    case "2":
                        Console.Clear();
                        Produto.AlterarProduto();
                        break;
                    case "3":
                        Console.Clear();
                        Produto.RemoverProduto();
                        break;
                    case "4":
                        Console.Clear();
                        Produto.ListarProdutos();
                        break;
                    case "5":
                        TimeExit();
                        break;
                    default:
                        Console.WriteLine("\nDigite uma opção válida!");
                        Console.WriteLine("Aperte qualquer tecla para continuar.");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                }
            } while (r!="5");
            

        }
    }
}
