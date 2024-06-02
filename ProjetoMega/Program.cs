using ProjetoMega.OpcoesDoMenu;

Console.WriteLine();
Console.WriteLine(@"
███╗░░░███╗███████╗░██████╗░░█████╗░░██████╗███████╗███╗░░██╗░█████╗░
████╗░████║██╔════╝██╔════╝░██╔══██╗██╔════╝██╔════╝████╗░██║██╔══██╗
██╔████╔██║█████╗░░██║░░██╗░███████║╚█████╗░█████╗░░██╔██╗██║███████║
██║╚██╔╝██║██╔══╝░░██║░░╚██╗██╔══██║░╚═══██╗██╔══╝░░██║╚████║██╔══██║
██║░╚═╝░██║███████╗╚██████╔╝██║░░██║██████╔╝███████╗██║░╚███║██║░░██║
╚═╝░░░░░╚═╝╚══════╝░╚═════╝░╚═╝░░╚═╝╚═════╝░╚══════╝╚═╝░░╚══╝╚═╝░░╚═╝");
Console.WriteLine();
Console.WriteLine("Bem vindo ao projeto, aqui sua sorte é nossa aposta.\n");
Console.WriteLine("Digite uma das opções do menu abaixo: \n");
Console.WriteLine("1 - Sortear numeros");
Console.WriteLine("2 - Conferir resultados");
Console.WriteLine("3 - Arquivar jogo");
Console.WriteLine("4 - Sair\n");
Console.Write("Sua opção: ");

string opcaoSelecionada = Console.ReadLine()!;
int opcaoMenu = int.Parse(opcaoSelecionada);

switch (opcaoMenu)
{
    case 1: OpcaoDoMenuSortear.OpcaoDoMenu();
        break;
      
}


