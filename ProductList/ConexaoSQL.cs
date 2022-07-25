using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Data.SqlClient;

namespace ProductList
{
    
    class ConexaoSQL
    {
        SqlConnection conexaoSQL = new SqlConnection(); 

        public ConexaoSQL() 
        {
           conexaoSQL.ConnectionString = @"User ID=aluno3;Password=aluno_4954;Data Source=localhost\SQLEXPRESS;
           Initial Catalog=Eproc_aluno3;Persist Security Info=True;Timeout=120;TrustServerCertificate=True";
        }

        public SqlConnection AbrirConexao()
        {
            if (conexaoSQL.State == System.Data.ConnectionState.Closed)
            {
                conexaoSQL.Open();
            }

            return conexaoSQL; 
        }
        public SqlConnection FecharConexao() 
        {
            if (conexaoSQL.State == System.Data.ConnectionState.Open)
            {
                conexaoSQL.Close();
            }

            return conexaoSQL;
        }


    }
}
