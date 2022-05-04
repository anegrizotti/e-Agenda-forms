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
        private readonly ISerializador serializador;
        private readonly DataContext dataContext;

        public RepositorioContatoEmArquivo(ISerializador serializador, DataContext dataContext)
        {
            this.dataContext = dataContext;
            this.serializador = serializador;

            dataContext.Contatos.AddRange(serializador.CarregarDadosDoArquivo().Contatos);
        }

        public List<Contato> SelecionarTodos()
        {
            return dataContext.Contatos;
        }

        public void Inserir(Contato novoContato)
        {
            dataContext.Contatos.Add(novoContato);
            serializador.GravarDadosEmArquivo(dataContext);
        }

        public void Editar(Contato contato)
        {
            foreach (var item in dataContext.Contatos)
            {
                if (item.Telefone == contato.Telefone)
                {
                    item.Telefone = contato.Telefone;
                    serializador.GravarDadosEmArquivo(dataContext);
                    break;
                }
            }
        }

        public void Excluir(Contato contato)
        {
            dataContext.Contatos.Remove(contato);
            serializador.GravarDadosEmArquivo(dataContext);
        }

    }
}
