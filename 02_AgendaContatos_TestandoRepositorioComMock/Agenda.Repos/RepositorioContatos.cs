using Agenda.DAL;
using System;
using System.Collections.Generic;
using Agenda.Domain;

namespace Agenda.Repos
{
    public class RepositorioContatos
    {
        private readonly IContatos _contatos;
        private readonly ITelefones _telefones;

        public RepositorioContatos(IContatos contatos, ITelefones telefones)
        {
            _contatos = contatos;
            _telefones = telefones;
        }

        public IContato ObterPorId(Guid Id)
        {
            IContato contato = _contatos.Obter(Id);
            List<ITelefone> lstTelefones = _telefones.ObterTodosDoContato(Id);
            contato.Telefones = lstTelefones;

            return contato;
        }
    }
}
