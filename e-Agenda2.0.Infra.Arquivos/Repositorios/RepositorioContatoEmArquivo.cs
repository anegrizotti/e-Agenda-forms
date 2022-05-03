using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using e_Agenda2._0.Dominio.ModuloContato;

namespace e_Agenda2._0.Infra.Arquivos
{
    public class RepositorioContatoEmArquivo : IRepositorioContato
    {
        private readonly ISerializadorContatos serializador;
        List<Contato> contatos;

        public RepositorioContatoEmArquivo(ISerializadorContatos serializador)
        {
            this.serializador = serializador;

            contatos = serializador.CarregarContatosDoArquivo();
        }

        public List<Contato> SelecionarTodos()
        {
            return contatos;
        }

        public void Inserir(Contato novoContato)
        {
            contatos.Add(novoContato);

            serializador.GravarContatosEmArquivo(contatos);
        }

        public void Editar(Contato contato)
        {
            foreach (var item in contatos)
            {
                if (item.Telefone == contato.Telefone)
                {
                    item.Telefone = contato.Telefone;
                    break;
                }
            }

            serializador.GravarContatosEmArquivo(contatos);
        }

        public void Excluir(Contato contato)
        {
            contatos.Remove(contato);

            serializador.GravarContatosEmArquivo(contatos);
        }

    }
}
