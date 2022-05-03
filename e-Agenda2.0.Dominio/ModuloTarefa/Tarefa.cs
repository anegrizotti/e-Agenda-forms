using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace e_Agenda2._0.Dominio.ModuloTarefa
{
    public class Tarefa
    {
        private List<Item> itens = new List<Item>();

        public Tarefa()
        {
            DataCriacao = DateTime.Now;
        }

        public Tarefa(int n, string t) : this()
        {
            Numero = n;
            Titulo = t;
            DataConclusao = null;
        }

        public int Numero { get; set; }
        public string Titulo { get; set; }
        public DateTime DataCriacao { get; set; }
        public DateTime? DataConclusao { get; set; }
        public PrioridadeTarefa Prioridade { get; set; }
        public List<Item> Itens { get { return itens; } }

        public override string ToString()
        {
            var percentual = CalcularPercentualConcluido();

            if (DataConclusao.HasValue)
            {
                return $"Número: {Numero}\n Título: {Titulo}\n Percentual: {percentual}\n" +
                    $"Data de Criação: {DataCriacao}\n Prioridade: {Prioridade}\n " +
                    $"Data de conclusão: {DataConclusao.Value.ToShortDateString()}\n\n";
            }

            return $"Número: {Numero}\n Título: {Titulo}\n Percentual: {percentual}\n Data de criação: {DataCriacao}\n Prioridade: {Prioridade}\n\n";
        }

        public void AdicionarItem(Item item)
        {
            if (Itens.Exists(x => x.Equals(item)) == false)
                itens.Add(item);
        }

        public void ConcluirItem(Item item)
        {
            Item itemTarefa = itens.Find(x => x.Equals(item));

            itemTarefa?.Concluir();

            var percentual = CalcularPercentualConcluido();

            if (percentual == 100)
                DataConclusao = DateTime.Now;
        }

        public void MarcarPendente(Item item)
        {
            Item itemTarefa = itens.Find(x => x.Equals(item));

            itemTarefa?.MarcarPendente();
        }

        public decimal CalcularPercentualConcluido()
        {
            if (itens.Count == 0)
                return 0;

            int qtdConcluidas = itens.Count(x => x.Concluido);

            var percentualConcluido = (qtdConcluidas / (decimal)itens.Count()) * 100;

            return Math.Round(percentualConcluido, 2);
        }
    }
}
