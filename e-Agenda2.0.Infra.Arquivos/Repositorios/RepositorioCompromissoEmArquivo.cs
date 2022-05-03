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
        private readonly ISerializadorCompromissos serializador;
        List<Compromisso> compromissos;

        public RepositorioCompromissoEmArquivo(ISerializadorCompromissos serializador)
        {
            this.serializador = serializador;

            compromissos = serializador.CarregarCompromissosDoArquivo();


        }

        public void Editar(Compromisso compromisso)
        {
            foreach (var item in compromissos)
            {
                if (item.Assunto == compromisso.Assunto)
                {
                    item.Assunto = compromisso.Assunto;
                    break;
                }
            }

            serializador.GravarCompromissosEmArquivo(compromissos);
        }

        public void Excluir(Compromisso compromisso)
        {
            compromissos.Remove(compromisso);

            serializador.GravarCompromissosEmArquivo(compromissos);
        }

        public void Inserir(Compromisso novoCompromisso)
        {
            compromissos.Add(novoCompromisso);

            serializador.GravarCompromissosEmArquivo(compromissos);
        }

        public List<Compromisso> SelecionarCompromissoPassado()
        {
            return compromissos.Where(x => x.DataCompromisso < DateTime.Today).ToList();
        }

        public List<Compromisso> SelecionarCompromissoFuturo()
        {
            return compromissos.Where(x => x.DataCompromisso > DateTime.Today).ToList();
        }

        public List<Compromisso> SelecionarTodos()
        {
            return compromissos;
        }

        public List<Compromisso> SelecionarCompromissoPorPeriodo(DateTime dataInicio, DateTime dataTermino)
        {
            return compromissos.Where(x => x.DataCompromisso >= dataInicio && x.DataCompromisso <= dataTermino).ToList();
        }

    }
}
