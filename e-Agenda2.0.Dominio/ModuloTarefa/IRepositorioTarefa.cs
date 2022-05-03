using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_Agenda2._0.Dominio.ModuloTarefa
{
    public interface IRepositorioTarefa
    {
        void AdicionarItens(Tarefa tarefaSelecionada, List<Item> itens);
        void AtualizarItens(Tarefa tarefaSelecionada, List<Item> itensConcluidos, List<Item> itensPendentes);
        void Editar(Tarefa tarefa);
        void Excluir(Tarefa tarefa);
        void Inserir(Tarefa novaTarefa);
        List<Tarefa> SelecionarTodos();

        List<Tarefa> SelecionarTarefasConcluidas();

        List<Tarefa> SelecionarTarefasPendentes();
    }
}
