using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rpg.OrdemParanormal;
using static Rpg.OrdemParanormal.FichaCompletaOrdem;


namespace Rpg.OrdemParanormal
{
    internal class OrigemOrdem
    {      

        public Dictionary<string, string> Origem { get; private set; }
        public OrigemOrdem()
        {
            Origem = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase)
            {
                {"Agente de Saúde",""},
                {"Acadêmico",""},
                {"Amnésico",""},
                {"Artista",""},
                {"Atleta",""},
                {"Chef",""},
                {"Cientista Forense",""},
                {"Criminoso",""},
                {"Cultista Arrependido",""},
                {"Desgarrado",""},
                {"Dublê",""},
                {"Engenheiro",""},
                {"Escritor",""},
                {"Executivo",""},
                {"Gaudério Abutre",""},
                {"Ginasta",""},
                {"Investigador",""},
                {"Jornalista",""},
                {"Lutador",""},
                {"Magnata",""},
                {"Mercenário",""},
                {"Militar",""},
                {"Operário",""},
                {"Policial",""},
                {"Professor",""},
                {"Religioso",""},
                {"Revoltado",""},
                {"Servidor Público",""},
                {"Teórico da Conspiração",""},
                {"T.I.",""},
                {"Trabalhador Rural",""},
                {"Trambiqueiro",""},
                {"Universitário",""},
                {"Vítima",""}
            };


        }
        public void ExibirOrigem()
        {
            Console.WriteLine("-----| Origens |-----");
            foreach (var origem in Origem) {
                Console.WriteLine($"{origem.Key} | {origem.Value}");
            }
        }
            
        public void SelecioneOrigem(FichaCompletaOrdem ficha)
        {
            FichaCompletaOrdem fichaCompletaOrdem = new FichaCompletaOrdem();
            Console.WriteLine("escolha sua origem:");
            string OrigemSelecionada = Console.ReadLine();

            if (OrigemSelecionada == "Acadêmico") {

                ficha.Pericias["Intuição "] = 5;
                ficha.Pericias["Medicina"] = 5;
                ficha.Habilidades.Add("Foco de Atirador", new Habilidade { Descricao = "Quando faz um teste usando Intelecto, você pode gastar 2 PE para receber +5 nesse teste.", PontosDeEsforco = 2 });
            }
            else if(OrigemSelecionada == "Agente de Saúde") {
                ficha.Pericias["Ciências"] = 5;
                ficha.Pericias["Investigação"] = 5;
                ficha.Habilidades.Add("Técnica Medicinal", new Habilidade { Descricao = "Sempre que cura um personagem, você adiciona seu Intelecto no total de PV curados.", PontosDeEsforco = 0 });
            }
            else if (OrigemSelecionada == "Amnésico")
            {
                ficha.Pericias["Ciências"] = 5;
                ficha.Habilidades.Add("Vislumbres do Passado", new Habilidade { Descricao = "Uma vez por sessão, você pode fazer um teste de Intelecto (DT 10) para reconhecer pessoas ou lugares familiares, que tenha encontrado antes de perder a memória. Se passar, recebe 1d4 PE temporários e, a critério do mestre, uma informação útil.", PontosDeEsforco = 0 });
            } 
            else if (OrigemSelecionada == "Artista") {
                ficha.Pericias["Intuição "] = 5;
                ficha.Pericias["Medicina"] = 5;
                ficha.Habilidades.Add("Magnum Opus", new Habilidade { Descricao = "Você é famoso por uma de suas obras. Uma vez por missão, pode determinar que um personagem envolvido em uma cena de interação o reconheça. Você recebe +5 em testes de Presença e de perícias baseadas em Presença contra aquele personagem. A critério do mestre, pode receber esses bônus em outras situações nas quais seria reconhecido.", PontosDeEsforco = 0 });
            }
            else if (OrigemSelecionada == "Chef")
            {
                ficha.Pericias["Fortitude "] = 5;
                ficha.Pericias["Profissão"] = 5;
                ficha.Habilidades.Add("Ingrediente Secreto", new Habilidade { Descricao = "Em cenas de interlúdio, você pode fazer a ação alimentar-se para cozinhar um prato especial. Você, e todos os membros do grupo que fizeram a ação alimentar-se, recebem o benefício de dois pratos (caso o mesmo benefício seja escolhido duas vezes, seus efeitos se acumulam).", PontosDeEsforco = 0 });
            }
            else if (OrigemSelecionada == "Atleta") {
                ficha.Pericias["Acrobacia  "] = 5;
                ficha.Pericias["Atletismo"] = 5;
                ficha.Habilidades.Add("110%", new Habilidade { Descricao = "Quando faz um teste de perícia usando Força ou Agilidade (exceto Luta e Pontaria) você pode gastar 2 PE para receber +5 nesse teste.", PontosDeEsforco = 2});
            } 
            else if (OrigemSelecionada == "Cientista Forense"){
                ficha.Pericias["Ciências "] = 5;
                ficha.Pericias["Investigação"] = 5;
                ficha.Habilidades.Add("Investigação Científica", new Habilidade { Descricao = " Uma vez por cena de investigação, você pode gastar uma ação livre para procurar pistas, usando Ciências no lugar da perícia que seria usada para tentar encontrar a pista em questão.", PontosDeEsforco = 0 });
            } 
            else if (OrigemSelecionada == "Criminoso") {
                ficha.Pericias["Crime "] = 5;
                ficha.Pericias["Furtividade"] = 5;
                ficha.Habilidades.Add("O Crime Compensa", new Habilidade { Descricao = "No final de uma missão, escolha um item encontrado na missão. Em sua próxima missão, você pode incluir esse item em seu inventário sem que ele conte em seu limite de itens por patente.", PontosDeEsforco = 0 });

            } 
            else if (OrigemSelecionada == "Cultista Arrependido"){
                ficha.Pericias["Ocultismo"] = 5;
                ficha.Pericias["Religião"] = 5;
                ficha.Habilidades.Add("", new Habilidade { Descricao = "", PontosDeEsforco = 3 });
            } 
            else if (OrigemSelecionada == "Desgarrado") {
                ficha.Pericias["Fortitude "] = 5;
                ficha.Pericias["Sobrevivência"] = 5;
                ficha.Habilidades.Add("", new Habilidade { Descricao = "", PontosDeEsforco = 3 });                                                                                                       ;
            } 
            else if (OrigemSelecionada == "Dublê") {
                ficha.Pericias["Pilotagem"] = 5;
                ficha.Pericias["Reflexos"] = 5;
                ficha.Habilidades.Add("", new Habilidade { Descricao = "", PontosDeEsforco = 3 });

            } 
            else if (OrigemSelecionada == "Engenheiro") {
                ficha.Pericias["Profissão"] = 5;
                ficha.Pericias["Tecnologia"] = 5;
                ficha.Habilidades.Add("", new Habilidade { Descricao = "", PontosDeEsforco = 3 });

            } 
            else if (OrigemSelecionada == "Escritor") {
                ficha.Pericias["Artes"] = 5;
                ficha.Pericias["Atualidades"] = 5;
                ficha.Habilidades.Add("", new Habilidade { Descricao = "", PontosDeEsforco = 3 });
            } 
            else if (OrigemSelecionada == "Executivo") {
                ficha.Pericias["Diplomacia"] = 5;
                ficha.Pericias["Profissão"] = 5;
                ficha.Habilidades.Add("", new Habilidade { Descricao = "", PontosDeEsforco = 3 });
            } 
            else if (OrigemSelecionada == "Gaudério Abutre"){
                ficha.Pericias["Luta"] = 5;
                ficha.Pericias["Pilotagem"] = 5;
                ficha.Habilidades.Add("", new Habilidade { Descricao = "", PontosDeEsforco = 3 });
            } 
            else if (OrigemSelecionada == "Ginasta") {
                ficha.Pericias["Acrobacia"] = 5;
                ficha.Pericias["Reflexos"] = 5;
                ficha.Habilidades.Add("", new Habilidade { Descricao = "", PontosDeEsforco = 3 });
            } 
            else if (OrigemSelecionada == "Investigador") {
                ficha.Pericias["Investigação"] = 5;
                ficha.Pericias["Percepção"] = 5;
                ficha.Habilidades.Add("", new Habilidade { Descricao = "", PontosDeEsforco = 3 });
            } 
            else if (OrigemSelecionada == "Jornalista") {
                ficha.Pericias["Atualidades"] = 5;
                ficha.Pericias["Investigação"] = 5;
                ficha.Habilidades.Add("", new Habilidade { Descricao = "", PontosDeEsforco = 3 });
            } 
            else if (OrigemSelecionada == "Lutador") {
                ficha.Pericias["Luta"] = 5;
                ficha.Pericias["Reflexos"] = 5;
                ficha.Habilidades.Add("", new Habilidade { Descricao = "", PontosDeEsforco = 3 });
            } 
            else if (OrigemSelecionada == "Magnata") {
                ficha.Pericias["Diplomacia"] = 5;
                ficha.Pericias["Pilotagem"] = 5;
                ficha.Habilidades.Add("", new Habilidade { Descricao = "", PontosDeEsforco = 3 });
            } 
            else if (OrigemSelecionada == "Mercenário") {
                ficha.Pericias["Iniciativa"] = 5;
                ficha.Pericias["Intimidação"] = 5;
                ficha.Habilidades.Add("", new Habilidade { Descricao = "", PontosDeEsforco = 3 });
            } 
            else if (OrigemSelecionada == "Militar") {
                ficha.Pericias["Pontaria"] = 5;
                ficha.Pericias["Pontaria"] = 5;
                ficha.Habilidades.Add("", new Habilidade { Descricao = "", PontosDeEsforco = 3 });
            } 
            else if (OrigemSelecionada == "Operário") {
                ficha.Pericias["Fortitude"] = 5;
                ficha.Pericias["Profissão"] = 5;
                ficha.Habilidades.Add("", new Habilidade { Descricao = "", PontosDeEsforco = 3 });
            } 
            else if (OrigemSelecionada == "Policial") {
                ficha.Pericias["Percepção"] = 5;
                ficha.Pericias["Pontaria"] = 5;
                ficha.Habilidades.Add("", new Habilidade { Descricao = "", PontosDeEsforco = 3 });
            } 
            else if (OrigemSelecionada == "Professor") {
                ficha.Pericias["Ciências"] = 5;
                ficha.Pericias["Intuição"] = 5;
                ficha.Habilidades.Add("", new Habilidade { Descricao = "", PontosDeEsforco = 3 });
            } 
            else if (OrigemSelecionada == "Religioso") {
                ficha.Pericias["Religião"] = 5;
                ficha.Pericias["Vontade"] = 5;
                ficha.Habilidades.Add("", new Habilidade { Descricao = "", PontosDeEsforco = 3 });
            } 
            else if (OrigemSelecionada == "Revoltado") {
                ficha.Pericias["Furtividade"] = 5;
                ficha.Pericias["Vontade"] = 5;
                ficha.Habilidades.Add("", new Habilidade { Descricao = "", PontosDeEsforco = 3 });
            } 
            else if (OrigemSelecionada == "Servidor Público"){
                ficha.Pericias["Intuição"] = 5;
                ficha.Pericias["Vontade"] = 5;
                ficha.Habilidades.Add("", new Habilidade { Descricao = "", PontosDeEsforco = 3 });
            } 
            else if (OrigemSelecionada == "Teórico da Conspiração"){
                ficha.Pericias["Investigação"] = 5;
                ficha.Pericias["Ocultismo"] = 5;
                ficha.Habilidades.Add("", new Habilidade { Descricao = "", PontosDeEsforco = 3 });
            } 
            else if (OrigemSelecionada == "TI") {
                ficha.Pericias["Investigação"] = 5;
                ficha.Pericias["Tecnologia"] = 5;
                ficha.Habilidades.Add("", new Habilidade { Descricao = "", PontosDeEsforco = 3 });
            } 
            else if (OrigemSelecionada == "Trabalhador Rural"){
                ficha.Pericias["Adestramento"] = 5;
                ficha.Pericias["Sobrevivência"] = 5;
                ficha.Habilidades.Add("", new Habilidade { Descricao = "", PontosDeEsforco = 3 });
            } 
            else if (OrigemSelecionada == "Trambiqueiro") {
                ficha.Pericias["Crime"] = 5;
                ficha.Pericias["Enganação"] = 5;
                ficha.Habilidades.Add("", new Habilidade { Descricao = "", PontosDeEsforco = 3 });
            } 
            else if (OrigemSelecionada == "Universitário") {
                ficha.Pericias["Atualidades"] = 5;
                ficha.Pericias["Investigação"] = 5;
                ficha.Habilidades.Add("", new Habilidade { Descricao = "", PontosDeEsforco = 3 });
            } 
            else if (OrigemSelecionada == "Vítima") {
                ficha.Pericias["Reflexos"] = 5;
                ficha.Pericias["Vontade"] = 5;
                ficha.Habilidades.Add("", new Habilidade { Descricao = "", PontosDeEsforco = 3 });
            } else {
                Console.WriteLine("Aparentemente voce colocou uma origem n existente");
                SelecioneOrigem(ficha); 
            }
}
}
}
