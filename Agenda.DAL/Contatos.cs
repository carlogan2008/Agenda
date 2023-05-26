using Microsoft.Data.SqlClient;

namespace Agenda.DAL
{
    public class Contatos
    {
        string _strConn;
        SqlConnection _conn;

        public Contatos()
        {
            string _strConn = @"Server=(localdb)\mssqllocaldb;Database=Agenda;Trusted_Connection=True;MultipleActiveResultSets=true";

            SqlConnection _conn = new SqlConnection(_strConn);
        }

        public bool Adicionar(string id, string nome)
        {
            string sql = $"insert into Contato (Id, Nome) values ('{id}', '{nome}')";

            var cmd = new SqlCommand(sql, _conn);

            cmd.ExecuteNonQuery();

            return true;
        }
    }
}