using System;
using System.Collections.Generic;
using Agenda.DAL;
using Agenda.Domain;
using NUnit.Framework;
using Moq;

namespace Agenda.Repos.Test
{
    [TestFixture]
    public class RepositorioContatosTest
    {
        Mock<IContatos> _contatos;
        Mock<ITelefones> _telefones;
        RepositorioContatos _repositorioContatos;

        [SetUp]
        public void SetUp()
        {
            _contatos = new Mock<IContatos>();
            _telefones = new Mock<ITelefones>();
            _repositorioContatos = new RepositorioContatos(_contatos.Object, _telefones.Object);
        }

        [Test]
        public void DeveSerPossivelObterContatoComListaTelefone()
        {
            // Monta
            var telefoneId = Guid.NewGuid();
            var contatoId = Guid.NewGuid();
            var lstTelefones = new List<ITelefone>();

            var mockContato = IContatoConstr.Um().ComId(contatoId).ComNome("Gustavo").Obter();
            mockContato.SetupSet(o => o.Telefones = It.IsAny<List<ITelefone>>()).Callback<List<ITelefone>>(p => lstTelefones = p);

            _contatos.Setup(o => o.Obter(contatoId)).Returns(mockContato.Object);  

            var mockTelefone = ITelefoneConstr.Um().Padrao().ComId(telefoneId).ComContatoId(contatoId).Construir();

            _telefones.Setup(o => o.ObterTodosDoContato(contatoId)).Returns(new List<ITelefone> { mockTelefone });

            // Executa
            var contatoResultado = _repositorioContatos.ObterPorId(contatoId);

            mockContato.SetupGet(o => o.Telefones).Returns(lstTelefones);

            // Verifica
            Assert.AreEqual(mockContato.Object.Id, contatoResultado.Id);
            Assert.AreEqual(mockContato.Object.Nome, contatoResultado.Nome);
            Assert.AreEqual(1, contatoResultado.Telefones.Count);
            Assert.AreEqual(mockTelefone.Id, contatoResultado.Telefones[0].Id);
            Assert.AreEqual(mockTelefone.Numero, contatoResultado.Telefones[0].Numero);
            Assert.AreEqual(mockContato.Object.Id, contatoResultado.Telefones[0].ContatoId); 
        }


        [TearDown]
        public void TearDown()
        {
            _contatos = null;
            _telefones = null;
            _repositorioContatos = null; 
        }
    }
} 