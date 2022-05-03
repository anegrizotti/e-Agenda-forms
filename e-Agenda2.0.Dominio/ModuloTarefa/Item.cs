using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_Agenda2._0.Dominio.ModuloTarefa 
{ 

    [Serializable]

    public class Item
    {
        public string Titulo { get; set; }

        public bool Concluido { get; set; }

        public override string ToString()
        {
            return $"Título: {Titulo}, Concluído: {Concluido}";
        }

        public void Concluir()
        {
            Concluido = true;
        }

        internal void MarcarPendente()
        {
            Concluido = false;
        }

    }
}
