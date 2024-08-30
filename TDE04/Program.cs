using System.Collections;

double totalPedido = 0;

bool pedidoAberto = true;

while (pedidoAberto)
{
    Console.WriteLine("Bem-vindo ao melhor sistema de gerenciamento de pedidos da ULBRA");
    Console.WriteLine("1 - add item ao pedido");
    Console.WriteLine("2 - exibir total do pedido");
    Console.WriteLine("3 - finalizar pedido e sair");
    string opcao = Console.ReadLine();

    switch(opcao)
    {
        case "1":
        Console.WriteLine("escolha um item do cardapio");
        Console.WriteLine("1 - pizza (R$30.00)");
        Console.WriteLine("2 - hamburguer (R$15.00)");
        Console.WriteLine("3 - refrigerante (R$5.00)");
        string escolha = Console.ReadLine();

        if (escolha == "1")
        {
            Console.WriteLine("Vc add uma pizza");
            totalPedido +=30;
        }
        else if(escolha == "2")
        {
            Console.WriteLine("vc add um hamburguer");
            totalPedido +=15;
        }
        else if(escolha == "3")
        {
            Console.WriteLine("vc add um refri");
            totalPedido +=5;
        }
        else
        {
            Console.WriteLine("Escolha 1 2 ou 3");
        }
        break;

        case "2":
        Console.WriteLine(totalPedido);
        break;

        case "3":
        Console.WriteLine("volte smp");
        pedidoAberto = false;
        break;
        default:
        Console.WriteLine("Digite uma opção válida");
        break;
    }
  
}