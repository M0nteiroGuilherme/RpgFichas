using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace Rpg
{
     internal class ToqueFinalOrdem
    {
        public string Nome;
        public string Aparencia;
        public string Personalidade;
        public string Historia;
        public string Obejetivo;

        public void Caracteristicas (){
            Console.Clear();
            Console.WriteLine("\n\n| Caracteristicas do seu Personagem |--------------");
            Console.WriteLine("| ");
            Console.WriteLine($"| Nome do seu personagem è: {Nome}");
            Console.WriteLine("| ");
            Console.WriteLine($"| A aparencia dele é: {Aparencia}");
            Console.WriteLine("| ");
            Console.WriteLine($"| Sua personalidade condiz com: {Personalidade}");
            Console.WriteLine("| ");
            Console.WriteLine($"| Sua historia é: {Historia}");
            Console.WriteLine("| ");
            Console.WriteLine($"| E tem como objetivo: {Obejetivo} ");
        }

        public void AltaracaoCaracteristicas() {
            ToqueFinalOrdem caracteristicas = new ToqueFinalOrdem();

            Console.WriteLine("coloque o nome do seu personagem: ");
            string NovoNome = Console.ReadLine();
            caracteristicas.Nome = NovoNome;

            Console.WriteLine($"Descreva a Aparencia do {NovoNome}: ");
            string NovaAparencia = Console.ReadLine();
            caracteristicas.Aparencia = NovaAparencia;

            Console.WriteLine($"Qual a historia do {NovoNome}: ");
            string NovaHistoria = Console.ReadLine();
            caracteristicas.Historia = NovaHistoria;

            Console.WriteLine($"qual o seu obejetivo {NovoNome}: ");
            string NovoObjetivo = Console.ReadLine();
            caracteristicas.Obejetivo = NovoObjetivo;

        }
     }

}
