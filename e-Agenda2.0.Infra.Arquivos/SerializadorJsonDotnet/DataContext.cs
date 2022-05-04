using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using e_Agenda2._0.Dominio.ModuloCompromisso;
using e_Agenda2._0.Dominio.ModuloContato;
using e_Agenda2._0.Dominio.ModuloTarefa;
using Newtonsoft.Json;

namespace e_Agenda2._0.Infra.Arquivos
{
    [Serializable]
    public class DataContext
    {
        public DataContext()
        {
            Tarefas = new List<Tarefa>();

            Contatos = new List<Contato>();

            Compromissos = new List<Compromisso>();
        }

        public List<Tarefa> Tarefas { get; set; }

        public List<Contato> Contatos { get; set; }

        public List<Compromisso> Compromissos { get; set; }

    }
}
