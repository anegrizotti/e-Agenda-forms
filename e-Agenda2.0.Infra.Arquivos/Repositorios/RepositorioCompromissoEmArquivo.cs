using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using e_Agenda2._0.Dominio.ModuloCompromisso;

namespace e_Agenda2._0.Infra.Arquivos
{
    public class RepositorioCompromissoEmArquivo : IRepositorioCompromisso
    {
        private readonly ISerializador serializador;
        private readonly DataContext dataContext;

        public RepositorioCompromissoEmArquivo(ISerializador serializador, DataContext dataContext)
        {
            this.dataContext = dataContext;
            this.serializador = serializador;

            dataContext.Compromissos.AddRange(serializador.CarregarDadosDoArquivo().Compromissos);
        }

        public void Editar(Compromisso compromisso)
        {
            foreach (var item in dataContext.Compromissos)
            {
                if (item.Assunto == compromisso.Assunto)
                {
                    item.Assunto = compromisso.Assunto;
                    serializador.GravarDadosEmArquivo(dataContext);
                    break;
                }
            }
        }

        public void Excluir(Compromisso compromisso)
        {
            dataContext.Compromissos.Remove(compromisso);
            serializador.GravarDadosEmArquivo(dataContext);
        }

        public void Inserir(Compromisso novoCompromisso)
        {
            dataContext.Compromissos.Add(novoCompromisso);
            serializador.GravarDadosEmArquivo(dataContext);
        }

        public List<Compromisso> SelecionarCompromissoPassado()
        {
            return dataContext.Compromissos.Where(x => x.DataCompromisso < DateTime.Today).ToList();
        }

        public List<Compromisso> SelecionarCompromissoFuturo()
        {
            return dataContext.Compromissos.Where(x => x.DataCompromisso > DateTime.Today).ToList();
        }

        public List<Compromisso> SelecionarTodos()
        {
            return dataContext.Compromissos;
        }

        public List<Compromisso> SelecionarCompromissoPorPeriodo(DateTime dataInicio, DateTime dataTermino)
        {
            return dataContext.Compromissos.Where(x => x.DataCompromisso >= dataInicio && x.DataCompromisso <= dataTermino).ToList();
        }

    }
}
