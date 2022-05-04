using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using e_Agenda2._0.Dominio.ModuloTarefa;

namespace e_Agenda2._0.Infra.Arquivos
{
    public class RepositorioTarefaEmArquivo : IRepositorioTarefa
    {
        private readonly ISerializador serializador;
        private readonly DataContext dataContext;
        int contador = 0;

        public RepositorioTarefaEmArquivo(ISerializador serializador, DataContext dataContext)
        {
            this.dataContext = dataContext;
            this.serializador = serializador;

            if (dataContext.Tarefas.Count > 0)
                contador = dataContext.Tarefas.Max(x => x.Numero);

            dataContext.Tarefas.AddRange(serializador.CarregarDadosDoArquivo().Tarefas);
        }

        public List<Tarefa> SelecionarTodos()
        {
            return dataContext.Tarefas;
        }

        public void Inserir(Tarefa novaTarefa)
        {
            novaTarefa.Numero = ++contador;
            dataContext.Tarefas.Add(novaTarefa);
            serializador.GravarDadosEmArquivo(dataContext);
        }

        public void Editar(Tarefa tarefa)
        {
            foreach (var item in dataContext.Tarefas)
            {
                if (item.Numero == tarefa.Numero)
                {
                    item.Titulo = tarefa.Titulo;
                    item.Prioridade = tarefa.Prioridade;
                    serializador.GravarDadosEmArquivo(dataContext);
                    break;
                }
            }
        }

        public void Excluir(Tarefa tarefa)
        {
            dataContext.Tarefas.Remove(tarefa);
            serializador.GravarDadosEmArquivo(dataContext);
        }

        public void AdicionarItens(Tarefa tarefaSelecionada, List<Item> itens)
        {
            foreach (var item in itens)
            {
                tarefaSelecionada.AdicionarItem(item);
                serializador.GravarDadosEmArquivo(dataContext);
            }
        }

        public void AtualizarItens(Tarefa tarefaSelecionada,
            List<Item> itensConcluidos, List<Item> itensPendentes)
        {
            foreach (var item in itensConcluidos)
            {
                tarefaSelecionada.ConcluirItem(item);
                serializador.GravarDadosEmArquivo(dataContext);
            }

            foreach (var item in itensPendentes)
            {
                tarefaSelecionada.MarcarPendente(item);
                serializador.GravarDadosEmArquivo(dataContext);
            }
        }

        public List<Tarefa> SelecionarTarefasConcluidas()
        {
            List<Tarefa> concluidaAlta = dataContext.Tarefas.Where(x => x.CalcularPercentualConcluido() == 100 && x.Prioridade == PrioridadeTarefa.Alta).ToList();
            List<Tarefa> concluidaNormal = dataContext.Tarefas.Where(x => x.CalcularPercentualConcluido() == 100 && x.Prioridade == PrioridadeTarefa.Normal).ToList();
            List<Tarefa> concluidaBaixa = dataContext.Tarefas.Where(x => x.CalcularPercentualConcluido() == 100 && x.Prioridade == PrioridadeTarefa.Baixa).ToList();

            concluidaAlta.AddRange(concluidaNormal);
            concluidaAlta.AddRange(concluidaBaixa);

            return concluidaAlta;
        }

        public List<Tarefa> SelecionarTarefasPendentes()
        {
            List<Tarefa> pendenteAlta = dataContext.Tarefas.Where(x => x.CalcularPercentualConcluido() < 100 && x.Prioridade == PrioridadeTarefa.Alta).ToList();
            List<Tarefa> pendenteNormal = dataContext.Tarefas.Where(x => x.CalcularPercentualConcluido() < 100 && x.Prioridade == PrioridadeTarefa.Normal).ToList();
            List<Tarefa> pendenteBaixa = dataContext.Tarefas.Where(x => x.CalcularPercentualConcluido() < 100 && x.Prioridade == PrioridadeTarefa.Baixa).ToList();

            pendenteAlta.AddRange(pendenteNormal);
            pendenteAlta.AddRange(pendenteBaixa);

            return pendenteAlta;
        }
    }
}
