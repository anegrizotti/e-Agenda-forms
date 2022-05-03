using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_Agenda2._0.Dominio.ModuloCompromisso
{
    public interface IRepositorioCompromisso
    {
        void Editar(Compromisso compromisso);
        void Excluir(Compromisso compromisso);
        void Inserir(Compromisso novoCompromisso);
        List<Compromisso> SelecionarTodos();

        List<Compromisso> SelecionarCompromissoPassado();

        List<Compromisso> SelecionarCompromissoFuturo();
        List<Compromisso> SelecionarCompromissoPorPeriodo(DateTime value1, DateTime value2);
    }
}
