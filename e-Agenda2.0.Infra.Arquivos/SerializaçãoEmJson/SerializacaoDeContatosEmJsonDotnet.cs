using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using e_Agenda2._0.Dominio.ModuloContato;
using Newtonsoft.Json;

namespace e_Agenda2._0.Infra.Arquivos.SerializaçãoEmJson
{
    public class SerializacaoDeContatosEmJsonDotnet : ISerializadorContatos
    {
        private const string arquivoContatos = @"C:\Users\luisy\Documents\contatos.json";

        public List<Contato> CarregarContatosDoArquivo()
        {
            if (File.Exists(arquivoContatos) == false)
                return new List<Contato>();

            string contatosJson = File.ReadAllText(arquivoContatos);

            JsonSerializerSettings settings = new JsonSerializerSettings();

            settings.Formatting = Formatting.Indented;

            return JsonConvert.DeserializeObject<List<Contato>>(contatosJson, settings);
        }

        public void GravarContatosEmArquivo(List<Contato> contatos)
        {
            JsonSerializerSettings settings = new JsonSerializerSettings();

            settings.Formatting = Formatting.Indented;

            string contatosJson = JsonConvert.SerializeObject(contatos, settings);

            File.WriteAllText(arquivoContatos, contatosJson);
        }
    }
}
