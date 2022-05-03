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
        private readonly ISerializadorTarefas serializador;
        List<Tarefa> tarefas;
        private int contador = 0;

        public RepositorioTarefaEmArquivo(ISerializadorTarefas serializador)
        {
            this.serializador = serializador;

            tarefas = serializador.CarregarTarefasDoArquivo();

            if (tarefas.Count > 0)
                contador = tarefas.Max(x => x.Numero);
        }

        public List<Tarefa> SelecionarTodos()
        {
            return tarefas;
        }

        public void Inserir(Tarefa novaTarefa)
        {
            novaTarefa.Numero = ++contador;
            tarefas.Add(novaTarefa);

            serializador.GravarTarefasEmArquivo(tarefas);
        }

        public void Editar(Tarefa tarefa)
        {
            foreach (var item in tarefas)
            {
                if (item.Numero == tarefa.Numero)
                {
                    item.Titulo = tarefa.Titulo;
                    item.Prioridade = tarefa.Prioridade;
                    break;
                }
            }

            serializador.GravarTarefasEmArquivo(tarefas);
        }

        public void Excluir(Tarefa tarefa)
        {
            tarefas.Remove(tarefa);

            serializador.GravarTarefasEmArquivo(tarefas);
        }

        public void AdicionarItens(Tarefa tarefaSelecionada, List<Item> itens)
        {
            foreach (var item in itens)
            {
                tarefaSelecionada.AdicionarItem(item);
            }

            serializador.GravarTarefasEmArquivo(tarefas);
        }

        public void AtualizarItens(Tarefa tarefaSelecionada,
            List<Item> itensConcluidos, List<Item> itensPendentes)
        {
            foreach (var item in itensConcluidos)
            {
                tarefaSelecionada.ConcluirItem(item);
            }

            foreach (var item in itensPendentes)
            {
                tarefaSelecionada.MarcarPendente(item);
            }

            serializador.GravarTarefasEmArquivo(tarefas);
        }

        public List<Tarefa> SelecionarTarefasConcluidas()
        {
            List<Tarefa> concluidaAlta = tarefas.Where(x => x.CalcularPercentualConcluido() == 100 && x.Prioridade == PrioridadeTarefa.Alta).ToList();
            List<Tarefa> concluidaNormal = tarefas.Where(x => x.CalcularPercentualConcluido() == 100 && x.Prioridade == PrioridadeTarefa.Normal).ToList();
            List<Tarefa> concluidaBaixa = tarefas.Where(x => x.CalcularPercentualConcluido() == 100 && x.Prioridade == PrioridadeTarefa.Baixa).ToList();

            concluidaAlta.AddRange(concluidaNormal);
            concluidaAlta.AddRange(concluidaBaixa);

            return concluidaAlta;
        }

        public List<Tarefa> SelecionarTarefasPendentes()
        {
            List<Tarefa> pendenteAlta = tarefas.Where(x => x.CalcularPercentualConcluido() < 100 && x.Prioridade == PrioridadeTarefa.Alta).ToList();
            List<Tarefa> pendenteNormal = tarefas.Where(x => x.CalcularPercentualConcluido() < 100 && x.Prioridade == PrioridadeTarefa.Normal).ToList();
            List<Tarefa> pendenteBaixa = tarefas.Where(x => x.CalcularPercentualConcluido() < 100 && x.Prioridade == PrioridadeTarefa.Baixa).ToList();

            pendenteAlta.AddRange(pendenteNormal);
            pendenteAlta.AddRange(pendenteBaixa);

            return pendenteAlta;
        }
    }
}
