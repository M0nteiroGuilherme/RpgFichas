using System;
using Rpg;
using Rpg.OrdemParanormal;

// Loop para manter o menu ativo.
bool continuar = true;
    while (continuar)
    {
        Console.WriteLine("\n--- Bem vindo ao Fichário ---");
        Console.WriteLine("[1] Ver personagens");
        Console.WriteLine("[2] Criar um novo personagem");
        Console.WriteLine("[3] Excluir personagem");
        Console.WriteLine("[4] Sair");
        Console.Write("\nEscolha uma opção: ");

        // Tenta converter a entrada com segurança.
        if (int.TryParse(Console.ReadLine(), out int menuOpcao))
        {
            switch (menuOpcao)
            {
                case 1:
                    Console.WriteLine("Funcionalidade: Ver personagens");
                    break;
                case 2:
                    Console.WriteLine("\nEscolha o sistema desejado:");
                    Console.WriteLine("[1] D&D\n[2] Ordem Paranormal");
                    Console.Write("Digite sua opção: ");
                    if (int.TryParse(Console.ReadLine(), out int opcaoSistema))
                    {
                        if (opcaoSistema == 1)
                        {
                            Console.WriteLine("Funcionalidade: Criar personagem D&D");
                            // Adicione aqui a lógica para D&D.
                        }
                        else if (opcaoSistema == 2)
                        {   
                            OrigemOrdem origem = new OrigemOrdem();
                            AtributoOrdem atributo = new AtributoOrdem();
                            ToqueFinalOrdem caracteristicas = new ToqueFinalOrdem();

                            origem.ExibirOrigem();
                            /*
                            atributo.CriandoAtributo();                        
                            
                            caracteristicas.AltaracaoCaracteristicas();

                            caracteristicas.Caracteristicas();
                            */

                        }
                        else
                        {
                            Console.WriteLine("Opção de sistema inválida.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Entrada inválida. Por favor, digite um número.");
                    }
                    break;
                case 3:
                    Console.WriteLine("Funcionalidade: Excluir personagem");
                    break;
                case 4:
                    continuar = false;
                    Console.WriteLine("Saindo do Fichário. Até logo!");
                    break;
                default:
                    Console.WriteLine("Opção inválida. Por favor, escolha uma das opções do menu.");
                    break;
            
            }
        }
        else
        {
            Console.WriteLine("Entrada inválida. Por favor, digite um número.");
        }
    }