using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Agenda.Domain;
using AutoFixture;
using NUnit.Framework;

namespace Agenda.DAL.Test
{
    public  class Contatos2Test
    {
        Contatos _contatos;
        Fixture _fixture;

        [SetUp]
        public void SetUp()
        {
            _contatos = new Contatos();
            _fixture = new Fixture();
        }

        [Test]
        public void ObterTodosContatosTest()
        {
            //Monta
            Contato contato = _fixture.Create<Contato>();
            Contato contato2 = _fixture.Create<Contato>();

            //Executa
            _contatos.Adicionar(contato);
            _contatos.Adicionar(contato2);
            var listaContatos = _contatos.ObterTodos();
            var contatoResultado = listaContatos.Where(p => p.Id == contato.Id || p.Id == contato2.Id).FirstOrDefault();

            //Verifica
            Assert.IsTrue(contatoResultado != null);
            Assert.AreEqual(2, listaContatos.Count);
            
        }


        [TearDown]
        public void TearDown()
        {
            _contatos = null;
            _fixture = null;
        }
    }
}
