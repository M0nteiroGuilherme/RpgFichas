using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Rpg.OrdemParanormal
{

    internal class FichaOrdem
    {   
        internal class Ritual{
            public string Nome { get; set; }
            public int NivelDoRitual { get; set; }
            public string Alcance { get; set; }
            public string Alvo { get; set; }
            public string Descrição { get; set; }
        }

        internal class Personagem
        {           
            public int Sanidade { get; set; }
            public int Esforco { get; set; }
            public int Defesa { get; set; }
            public int Bloquei { get; set; }
            public int Esquiva { get; set; }

        }


        internal class Habilidade {
            public string Descricao {get; set;}
            public int PontosDeEsforco {  get; set;}
        
        }


        public Dictionary<string, int> Pericias { get; private set; }        
        public Dictionary<string, string> Combate {get; private set; }
        public Dictionary<string, Habilidade> Habilidades {get; private set; }
        public Dictionary<string, Ritual> Rituais {get; private set; }

        public FichaOrdem(){
            Pericias = new Dictionary<string, int>(StringComparer.OrdinalIgnoreCase)
            {
                { "Acrobacia", 0 },
                { "Adestramento", 0 },
                { "Arte", 0 },
                { "Atletismo", 0 },
                { "Atualidades", 0 },
                { "Ciências", 0 },
                { "Crime", 0 },
                { "Diplomacia", 0 },
                { "Enganação", 0 },
                { "Fortitude", 0 },
                { "Furtividade", 0 },
                { "Iniciativa", 0 },
                { "Intimidação", 0 },
                { "Intuição", 0 },
                { "Investigação", 0 },
                { "Luta", 0 },
                { "Medicina", 0 },
                { "Ocultismo", 0 },
                { "Percepção", 0 },
                { "Pilotagem", 0 },
                { "Pontaria", 0 },
                { "Profissão", 0 },
                { "Reflexos", 0 },
                { "Religião", 0 },
                { "Sobrevivência", 0 },
                { "Tática", 0 },
                { "Tecnologia", 0 },
                { "Vontade", 0 }
            };

        }
    }
}
