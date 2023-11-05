using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

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
            string nome = txtNovoContato.Text;
            //txtContatoSalvo.Text = nome;

            string strCon = @"Data Source=.\sqlexpress;Initial Catalog=Agenda;Integrated Security=true;";
            SqlConnection con = new SqlConnection(strCon);
            con.Open();

            string guid = Guid.NewGuid().ToString();
            string sql = string.Format("INSERT INTO CONTATO(ID, NOME) VALUES('{0}','{1}');", guid, nome);
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.ExecuteNonQuery();

            sql = string.Format("SELECT NOME FROM CONTATO WHERE ID = '{0};'", guid);
            cmd = new SqlCommand(sql, con);
            txtContatoSalvo.Text = cmd.ExecuteScalar().ToString();

            con.Close();
        }
    }
}
