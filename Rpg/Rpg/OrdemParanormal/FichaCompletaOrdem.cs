using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Rpg.OrdemParanormal
{


    public class Personagem
    {
        public string Nome { get; set; }
        public string Aparencia { get; set; }
        public string Personalidade { get; set; }
        public string Historia { get; set; }
        public string Objetivo { get; set; }

        public int Vida { get; set; }
        public int Sanidade { get; set; }
        public int Defesa { get; set; }
        public int Bloqueio { get; set; }
        public int Esquiva { get; set; }
        public int PontosDeEsforco { get; set; }

        public Personagem()
        {
        }

        public Personagem(string nome, string aparencia, string personalidade, string historia, string objetivo, int vida, int sanidade, int defesa, int bloqueio, int esquiva, int pontosDeEsforco)
        {
            Nome = nome;
            Aparencia = aparencia;
            Personalidade = personalidade;
            Historia = historia;
            Objetivo = objetivo;
            Vida = vida;
            Sanidade = sanidade;
            Defesa = defesa;
            Bloqueio = bloqueio;
            Esquiva = esquiva;
            PontosDeEsforco = pontosDeEsforco;
        }
    }    

    public class Ritual
    {
        public string Nome { get; set; }
        public int NivelDoRitual { get; set; }
        public string Alcance { get; set; }
        public string Alvo { get; set; }
        public string Descrição { get; set; }
    }

    public class Habilidade
    {
        public string Descricao { get; set; }
        public int PontosDeEsforco { get; set; }
    }

  


    internal class FichaCompletaOrdem
    {
        string EscolhaClasse;
        public Personagem Personagem { get; set; }
        public Dictionary<string, int> Atributo { get; private set; }

        public Dictionary<string, int> Pericias { get; private set; }
        public Dictionary<string, string> Combate { get; private set; }
        public Dictionary<string, Habilidade> Habilidades { get; private set; }
        public Dictionary<string, Ritual> Rituais { get; private set; }

        public FichaCompletaOrdem()
        {
            
            Atributo = new Dictionary<string, int>(StringComparer.OrdinalIgnoreCase)
            {
                {"Agilidade", 0}, {"Força", 0}, {"Presença", 0}, {"Vigor", 0}, {"Intelecto", 0}
            };
            InicializarPropriedadesDaFicha();
        }

        public FichaCompletaOrdem(string nomePersonagem)
        {
            
            Atributo = new Dictionary<string, int>(StringComparer.OrdinalIgnoreCase)
            {
                {"Agilidade", 0}, {"Força", 0}, {"Presença", 0}, {"Vigor", 0}, {"Intelecto", 0}
            };
            InicializarPropriedadesDaFicha();
        }
        public void InicializarPropriedadesDaFicha()
        {
            Personagem = new Personagem();
            Pericias = new Dictionary<string, int>(StringComparer.OrdinalIgnoreCase)
            {
                { "Acrobacia", 0 }, { "Adestramento", 0 }, { "Arte", 0 },
                { "Atletismo", 0 }, { "Atualidades", 0 }, { "Ciências", 0 },
                { "Crime", 0 }, { "Diplomacia", 0 }, { "Enganação", 0 },
                { "Fortitude", 0 }, { "Furtividade", 0 }, { "Iniciativa", 0 },
                { "Intimidação", 0 }, { "Intuição", 0 }, { "Investigação", 0 },
                { "Luta", 0 }, { "Medicina", 0 }, { "Ocultismo", 0 },
                { "Percepção", 0 }, { "Pilotagem", 0 }, { "Pontaria", 0 },
                { "Profissão", 0 }, { "Reflexos", 0 }, { "Religião", 0 },
                { "Sobrevivência", 0 }, { "Tática", 0 }, { "Tecnologia", 0 },
                { "Vontade", 0 }
            };
            Combate = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
            Habilidades = new Dictionary<string, Habilidade>(StringComparer.OrdinalIgnoreCase);
            Rituais = new Dictionary<string, Ritual>(StringComparer.OrdinalIgnoreCase);
        }


        public void Salvar()
        {
            string fileName = $"{Personagem.Nome}.json";
            string jsonString = JsonSerializer.Serialize(this, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(fileName, jsonString);
            Console.WriteLine($"Ficha salva com sucesso em: {fileName}");
        }


        public static FichaCompletaOrdem Carregar(string nomeArquivo)
        {
            if (!nomeArquivo.EndsWith(".json"))
            {
                nomeArquivo += ".json";
            }

            if (!File.Exists(nomeArquivo))
            {
                Console.WriteLine($"ERRO: Arquivo de ficha não encontrado: {nomeArquivo}");
                return null;
            }

            string jsonString = File.ReadAllText(nomeArquivo);
            try
            {
                return JsonSerializer.Deserialize<FichaCompletaOrdem>(jsonString);
            }
            catch (JsonException ex)
            {
                Console.WriteLine($"ERRO: Falha ao ler o arquivo JSON. Detalhes: {ex.Message}");
                return null;
            }
        }

        public void ExibirAtributo()
        {
            Console.WriteLine("----| ATRIBUTOS |----");
            foreach (var atributo in Atributo)
            {
                Console.WriteLine($"[{atributo.Value}] {atributo.Key}");
            }
        }
    }
}    
