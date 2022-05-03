using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using e_Agenda2._0.Dominio.ModuloContato;

namespace e_Agenda2._0.Dominio.ModuloCompromisso
{
    [Serializable]
    public class Compromisso
    { 
        public string Assunto { get; set; }
        public string Local { get; set; }
        public DateTime DataCompromisso { get; set; }
        public string HoraInicio { get; set; }
        public string HoraTermino { get; set; }
        public Contato Contato { get; set; }
        public Compromisso(string assunto, string local, DateTime dataCompromisso, string horaInicio, string horaTermino, Contato contato)
        {
            Assunto = assunto;
            Local = local;
            HoraInicio = horaInicio;
            HoraTermino = horaTermino;
            DataCompromisso = dataCompromisso;
            Contato = contato;
        }

        public Compromisso()
        {
        }

        public override string ToString()
        {
            string contatoRelacionado = Contato is null ? "Não disponível" : Contato.Nome;

            return $"Assunto: {Assunto}\n Local: {Local}\n Data do Compromisso: {DataCompromisso.Date}\n" +
                $"Hora de Inicio: {HoraInicio}\n Hora de Térimo: {HoraTermino}\n Contato: {contatoRelacionado}\n\n";
        }
    }
}
