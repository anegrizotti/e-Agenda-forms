using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using e_Agenda2._0.Dominio.ModuloCompromisso;

namespace e_Agenda2._0.Infra.Arquivos.SerializaçãoEmJson
{
    public class SerializacaoDeCompromissosEmJsonDotnet : ISerializadorCompromissos
    {
        private const string arquivoCompromissos = @"C:\Users\luisy\Documents\compromissos.json";

        public List<Compromisso> CarregarCompromissosDoArquivo()
        {
            if (File.Exists(arquivoCompromissos) == false)
                return new List<Compromisso>();

            string compromissosJson = File.ReadAllText(arquivoCompromissos);

            JsonSerializerSettings settings = new JsonSerializerSettings();

            settings.Formatting = Formatting.Indented;

            return JsonConvert.DeserializeObject<List<Compromisso>>(compromissosJson, settings);
        }

        public void GravarCompromissosEmArquivo(List<Compromisso> compromissos)
        {
            JsonSerializerSettings settings = new JsonSerializerSettings();

            settings.Formatting = Formatting.Indented;

            string CompromissosJson = JsonConvert.SerializeObject(compromissos, settings);

            File.WriteAllText(arquivoCompromissos, CompromissosJson);
        }
    }
}
