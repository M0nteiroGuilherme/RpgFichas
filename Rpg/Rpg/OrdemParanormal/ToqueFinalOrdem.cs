using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Rpg.OrdemParanormal;


namespace Rpg
{
     internal class ToqueFinalOrdem
    {
        public void Caracteristicas (FichaCompletaOrdem ficha)
        {
            
            Console.Clear();
            Console.WriteLine("\n\n| Caracteristicas do seu Personagem |--------------");
            Console.WriteLine("| ");
            Console.WriteLine($"| Nome do seu personagem è: {ficha.Personagem.Nome}");
            Console.WriteLine("| ");
            Console.WriteLine($"| A aparencia dele é: {ficha.Personagem.Aparencia}");
            Console.WriteLine("| ");
            Console.WriteLine($"| Sua personalidade condiz com: {ficha.Personagem.Personalidade}");
            Console.WriteLine("| ");
            Console.WriteLine($"| Sua historia é: {ficha.Personagem.Historia}");
            Console.WriteLine("| ");
            Console.WriteLine($"| E tem como objetivo: {ficha.Personagem.Objetivo} ");

            ficha.Salvar();
        }

        public void AltaracaoCaracteristicas(FichaCompletaOrdem ficha) {

            if (ficha.Personagem == null)
            {
                ficha.Personagem = new Personagem();
            }

            Console.WriteLine("coloque o nome do seu personagem: ");
            ficha.Personagem.Nome = Console.ReadLine();
            
            Console.WriteLine($"Descreva a Aparencia do {ficha.Personagem.Nome}: ");
            ficha.Personagem.Aparencia = Console.ReadLine();  
            
            Console.WriteLine($"Qual a historia do {ficha.Personagem.Nome}: ");
            ficha.Personagem.Historia = Console.ReadLine();
            
            Console.WriteLine($"qual o seu obejetivo {ficha.Personagem.Nome}: ");
            ficha.Personagem.Objetivo = Console.ReadLine();

            ficha.Salvar();
        }

        
     }
     
}
