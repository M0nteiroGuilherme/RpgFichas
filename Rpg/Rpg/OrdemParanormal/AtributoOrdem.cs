using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Rpg.OrdemParanormal;

namespace Rpg.OrdemParanormal
{

    internal class AtributoOrdem
    {
        public Dictionary<string, int> Atributo { get; private set; }

        public AtributoOrdem()
        {
            Atributo = new Dictionary<string, int>(StringComparer.OrdinalIgnoreCase)
            {
                {"Agilidade", 0},
                {"Força", 0},
                {"Presença", 0},
                {"Vigor", 0},
                {"Intelecto", 0}
            };
        }
        public void ExibirAtributo()
        {
            Console.WriteLine("----| PERICIAS |----");
            foreach (var atributo in Atributo)
            {
                Console.WriteLine($"[{atributo.Value}] {atributo.Key}");
            }
        }

        public void AlterarAtributo()
        {
            ExibirAtributo();
            Console.WriteLine("Coloque o Atributo que deseja alterar ");
            string AtributoSelecionado = Console.ReadLine();

            Console.WriteLine($"Quantos pontos deseja colocar em {AtributoSelecionado}");
            int PontosSelecionados = int.Parse(Console.ReadLine());


            Atributo[AtributoSelecionado] = PontosSelecionados;

            Console.Clear();
            ExibirAtributo();
        }

        public void CriandoAtributo()
        {
            Console.Clear();
            int PontosAtuais = 4;

            while (PontosAtuais > 0)
            {

                ExibirAtributo();

                Console.WriteLine("Escolha um dos atributos: ");
                string AtributoSelecionado = Console.ReadLine();

                Console.WriteLine($"Voce tem [{PontosAtuais}] pontos para colocar. O valor máximo inicial que você pode ter em cada atributo é 3");
                Console.WriteLine($"Quantos pontos deseja colocar em {AtributoSelecionado}");
                int PontoSelecionado  = int.Parse(Console.ReadLine());
               
                Atributo[AtributoSelecionado] = PontoSelecionado;

                PontosAtuais = PontosAtuais - PontoSelecionado;
                Console.Clear();

                Console.WriteLine("----|Pericia Atualizadas|----");

            }

            ExibirAtributo();
        }

    }
}
