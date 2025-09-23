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
        
        public void AlterarAtributo(FichaCompletaOrdem ficha)
        {
            ficha.ExibirAtributo();
            Console.WriteLine("Coloque o Atributo que deseja alterar ");
            string AtributoSelecionado = Console.ReadLine();

            Console.WriteLine($"Quantos pontos deseja colocar em {AtributoSelecionado}");
            int PontosSelecionados = int.Parse(Console.ReadLine());


            ficha.Atributo[AtributoSelecionado] = PontosSelecionados;

            Console.Clear();
            ficha.ExibirAtributo();
        }

        public void CriandoAtributo(FichaCompletaOrdem ficha)
        {            
            Console.Clear();
            int PontosAtuais = 4;

            while (PontosAtuais > 0)
            {

                ficha.ExibirAtributo();

                Console.WriteLine("Escolha um dos atributos: ");
                string AtributoSelecionado = Console.ReadLine();

                Console.WriteLine($"Voce tem [{PontosAtuais}] pontos para colocar. O valor máximo inicial que você pode ter em cada atributo é 3");
                Console.WriteLine($"Quantos pontos deseja colocar em {AtributoSelecionado}");
                int PontoSelecionado  = int.Parse(Console.ReadLine());

                ficha.Atributo[AtributoSelecionado] = PontoSelecionado;

                PontosAtuais = PontosAtuais - PontoSelecionado;
                Console.Clear();

                Console.WriteLine("----|Pericia Atualizadas|----");
                ficha.Salvar();
            }

            ficha.ExibirAtributo();
        }

    }
}
