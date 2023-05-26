using System.Data.Common;
using Microsoft.Data.SqlClient;

namespace Agenda.UIDesktop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            string nome = txtContatoNovo.Text;

            //txtContatoSalvo.Text = nome;

            string strConn = @"Server=(localdb)\mssqllocaldb;Database=Agenda;Trusted_Connection=True;MultipleActiveResultSets=true";

            SqlConnection conn = new SqlConnection(strConn);
            conn.Open();

            string id = Guid.NewGuid().ToString();

            string sql = $"insert into Contato (Id, Nome) values ('{id}', '{nome}')";

            var cmd = new SqlCommand(sql, conn);

            cmd.ExecuteNonQuery();

            sql = $"SELECT [Nome] FROM [Agenda].[dbo].[Contato] WHERE Id = '{id}'";
            cmd = new SqlCommand(sql, conn);
            txtContatoSalvo.Text = cmd.ExecuteScalar().ToString();

            conn.Close();
        }
    }
}