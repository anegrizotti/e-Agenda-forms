using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using e_Agenda2._0.Dominio.ModuloTarefa;

namespace e_Agenda2._0.Infra.Arquivos.SerializaçãoEmJson
{
    public class SerializacaoDeTarefasEmJsonDotnet : ISerializadorTarefas
    {
        private const string arquivoTarefas = @"C:\Users\luisy\Documents\tarefas.json";

        public List<Tarefa> CarregarTarefasDoArquivo()
        {
            if (File.Exists(arquivoTarefas) == false)
                return new List<Tarefa>();

            string tarefasJson = File.ReadAllText(arquivoTarefas);

            JsonSerializerSettings settings = new JsonSerializerSettings();

            settings.Formatting = Formatting.Indented;

            return JsonConvert.DeserializeObject<List<Tarefa>>(tarefasJson, settings);
        }

        public void GravarTarefasEmArquivo(List<Tarefa> tarefas)
        {
            JsonSerializerSettings settings = new JsonSerializerSettings();

            settings.Formatting = Formatting.Indented;

            string tarefasJson = JsonConvert.SerializeObject(tarefas, settings);

            File.WriteAllText(arquivoTarefas, tarefasJson);
        }
    }
}
