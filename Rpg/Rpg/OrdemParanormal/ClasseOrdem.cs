using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Rpg.OrdemParanormal.FichaCompletaOrdem;


namespace Rpg.OrdemParanormal
{ 

    internal class ClasseOrdem
    {
        string EscolhaClasse;

        public void SelecaoClasse(FichaCompletaOrdem ficha)
        {           

            Console.WriteLine("Selecione sua classe ");
            Console.WriteLine("-----| Classes |-----");
            Console.WriteLine("Combatente\nEspecialista\nOcultista\nMundano");
            EscolhaClasse = Console.ReadLine();

            if (EscolhaClasse == "Combatente" || EscolhaClasse == "combatente")
            {
                int ValorVigor = ficha.Atributo["vigor"];
                int ValorPresenca = ficha.Atributo["Presença"];

                ficha.Personagem.Vida = ValorVigor + 20;
                ficha.Personagem.PontosDeEsforco = ValorPresenca + 2;
                ficha.Personagem.Sanidade = 12;               

            }
            else if (EscolhaClasse == "Especialista" || EscolhaClasse == "especialista")
            {
                int ValorVigor = ficha.Atributo["vigor"];
                int ValorPresenca = ficha.Atributo["Presença"];

                ficha.Personagem.Vida = ValorVigor + 16;
                ficha.Personagem.PontosDeEsforco = ValorPresenca + 3;
                ficha.Personagem.Sanidade = 16;                

            }
            else if (EscolhaClasse == "Ocultista" || EscolhaClasse == "ocultista")
            {
                int ValorVigor = ficha.Atributo["vigor"];
                int ValorPresenca = ficha.Atributo["Presença"];

                ficha.Personagem.Vida = ValorVigor + 12;
                ficha.Personagem.PontosDeEsforco = ValorPresenca + 4;
                ficha.Personagem.Sanidade = 20;

            }
            else if (EscolhaClasse == "Mundano" || EscolhaClasse == "Mundano")
            {
                int ValorVigor = ficha.Atributo["vigor"];
                int ValorPresenca = ficha.Atributo["Presença"];

                ficha.Personagem.Vida = ValorVigor + 8;
                ficha.Personagem.PontosDeEsforco = ValorPresenca + 1;
                ficha.Personagem.Sanidade = 8;

            }
            ficha.Salvar();
        }
    }
}
