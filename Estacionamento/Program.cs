﻿using Estacionamento.Services;

// Coloca o encoding para UTF8 para exibir acentuação
Console.OutputEncoding = System.Text.Encoding.UTF8;

//Invoca a configuração inicial do estacionamento
bool inicializadorEstacionamento = true;
decimal precoInicial = 0;
decimal precoPorHora = 0;




do
{
    Console.Clear();

    try
    {
        Console.WriteLine("Seja bem vindo ao sistema de estacionamento!\n" +
                          "Digite o preço inicial:");
        precoInicial = Convert.ToDecimal(Console.ReadLine());

        Console.WriteLine("Agora digite o preço por hora:");
        precoPorHora = Convert.ToDecimal(Console.ReadLine());

        inicializadorEstacionamento = false;
    }
    catch(FormatException)
    {
        Console.WriteLine("Digite um preço válido!");
        Console.WriteLine("Pressione qualquer tecla para continuar");
        Console.ReadKey();
    }
}
while(inicializadorEstacionamento);


// Instancia a classe Estacionamento, já com os valores obtidos anteriormente
EstacionamentoImp es = new EstacionamentoImp(precoInicial, precoPorHora);

bool exibirMenu = true;

// Realiza o loop do menu
while (exibirMenu)
{
    Console.Clear();
    Console.WriteLine("----------------------------");
    Console.WriteLine("Digite a sua opção:");
    Console.WriteLine("1 - Cadastrar veículo");
    Console.WriteLine("2 - Remover veículo");
    Console.WriteLine("3 - Listar veículos");
    Console.WriteLine("4 - alterar funcionario ");
    Console.WriteLine("5 - Encerrar");
    Console.WriteLine("----------------------------");

    switch (Console.ReadLine())
    {
        case "1":
            es.AdicionarVeiculo();
            break;

        case "2":
            es.RemoverVeiculo();
            break;

        case "3":
            es.ListarVeiculos();
            break;

        case "4":
            es.MenuDeUsuario();
            break;

        case "5":
            exibirMenu = es.RelatorioDoDia();            
            break;

        default:
            Console.WriteLine("Opção inválida");
            break;
    }

    Console.WriteLine("\nPressione uma tecla para continuar");
    Console.ReadKey();
}
Console.Clear();
Console.WriteLine("O programa se encerrou");
