using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Data.SqlClient;

namespace ProductList
{
    class ManipulacaoSQL
    {
        SqlCommand comando = new SqlCommand();
        ConexaoSQL Conexao = new ConexaoSQL();

        public void InsertProduto(int cod, string nome, double preco, int qtd)
        {
            comando.CommandText = "INSERT INTO Produto(nomePdt, precoPdt, qtdPdt) values(@nome, @preco, @quantidade)"; // string para o SQL
            comando.Parameters.AddWithValue("@nome", nome);
            comando.Parameters.AddWithValue("@preco", preco);
            comando.Parameters.AddWithValue("@quantidade", qtd);

            try
            {
                comando.Connection = Conexao.AbrirConexao();
                comando.ExecuteNonQuery();
                Conexao.FecharConexao();


            }
            catch (SqlException exception)
            {
                Console.WriteLine(exception.Message);
            }

        }

        public void UpdateProduto(int cod, string nome, double preco, int qtd)
        {
            comando.CommandText = "UPDATE Produto set nomePdt=@nome, precoPdt=@preco, qtdPdt=@quantidade where codigoPdt=@codigo";
            comando.Parameters.AddWithValue("@codigo", cod);
            comando.Parameters.AddWithValue("@nome", nome);
            comando.Parameters.AddWithValue("@preco", preco);
            comando.Parameters.AddWithValue("@quantidade", qtd);

            try
            {
                comando.Connection = Conexao.AbrirConexao();
                comando.ExecuteNonQuery();
                Conexao.FecharConexao();

            }
            catch (SqlException exception)
            {
                Console.WriteLine(exception.Message);
            }

        }

        public void DeleteProduto(int cod)
        {
            comando.CommandText = "DELETE FROM Produto where codigoPdt=@codigo";
            comando.Parameters.AddWithValue("@codigo", cod);

            try
            {
                comando.Connection = Conexao.AbrirConexao();
                comando.ExecuteNonQuery();
                Conexao.FecharConexao();

            }
            catch (SqlException exception)
            {
                Console.WriteLine(exception.Message);
            }

        }

        public void SelectProduto()
        {
            comando.CommandText = "SELECT * FROM Produto";

            try
            {
                comando.Connection = Conexao.AbrirConexao();
                var i = comando.ExecuteReader();

                while (i.Read())
                {
                    Console.WriteLine($"\nCódigo: {i[0]}\nNome:{i[1]}\nPreço: {i[2]}\nQuantidade: {i[3]}");
                }

                Conexao.FecharConexao();

            }
            catch (SqlException exception)
            {
                Console.WriteLine(exception.Message);
            }
        }


    }
}
