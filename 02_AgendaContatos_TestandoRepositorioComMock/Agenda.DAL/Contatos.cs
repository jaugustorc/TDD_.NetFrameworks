using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using Agenda.Domain;
using Dapper;

namespace Agenda.DAL
{
    public class Contatos
    {
        string _strCon; 

        public Contatos()
        {
            _strCon = ConfigurationManager.ConnectionStrings["con"].ConnectionString;  
        }

        public void Adicionar(Contato contato)
        {
            using (var con = new SqlConnection(_strCon))
            {
                //con.Open();

                //var sql = string.Format("INSERT INTO CONTATO(ID, NOME) VALUES('{0}','{1}');", contato.Id, contato.Nome);
                //SqlCommand cmd = new SqlCommand(sql, con);
                //cmd.ExecuteNonQuery();

                con.Execute("INSERT INTO CONTATO(ID, NOME) VALUES(@Id,@Nome)", contato);
            } 
        }

        public Contato Obter(Guid id)
        {
            using (var con = new SqlConnection(_strCon))
            {
                //con.Open();

                //var sql = string.Format("SELECT ID, NOME FROM CONTATO WHERE ID = '{0};'", id);
                //SqlCommand cmd = new SqlCommand(sql, con);
                //var sqlDataReader = cmd.ExecuteReader();
                //sqlDataReader.Read();
                //var contato = new Contato()
                //{
                //    Id = Guid.Parse(sqlDataReader["ID"].ToString()),
                //    Nome = sqlDataReader["NOME"].ToString()
                //};

                var contato = con.QueryFirst<Contato>("SELECT ID, NOME FROM CONTATO WHERE ID = @Id", new {Id = id} );
                return contato;
            } 
        }

        public List<Contato> ObterTodos()
        {
            using (var con = new SqlConnection(_strCon))
            {
                //var list = new List<Contato>();
                //con.Open();

                //var sql = string.Format("SELECT ID, NOME FROM CONTATO");
                //SqlCommand cmd = new SqlCommand(sql, con);
                //var sqlDataReader = cmd.ExecuteReader();
                //while (sqlDataReader.Read())
                //{
                //    var contato = new Contato()
                //    {
                //        Id = Guid.Parse(sqlDataReader["ID"].ToString()),
                //        Nome = sqlDataReader["NOME"].ToString()
                //    };
                //    list.Add(contato);
                //} 

                //return list; 

                var contatos = con.Query<Contato>("SELECT ID, NOME FROM CONTATO").ToList();
                return contatos;
            }
        }
    }
}
