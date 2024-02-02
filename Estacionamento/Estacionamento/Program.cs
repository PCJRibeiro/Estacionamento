using Estacionamento.Entites;


Console.WriteLine("Digite o preço inicial:");
int PrecoInicial = int.Parse(Console.ReadLine());
Console.WriteLine("Agora digite o preço por hora:");
int PrecoHora = int.Parse(Console.ReadLine());
int escolha = 0;
ClasseEstacionamento estacionamento1 = new ClasseEstacionamento();
estacionamento1.PrecoInicial = PrecoInicial;
estacionamento1.PrecoHora = PrecoHora;

while (escolha != 4) 

    {
    Console.WriteLine("Digite a sua opção: ");

    Console.WriteLine("1 - Cadastrar veículo");
    Console.WriteLine("2 - Remover veículo");
    Console.WriteLine("3 - Listar veículo");
    Console.WriteLine("4 - Encerrar");
    escolha = int.Parse(Console.ReadLine());
    if (escolha == 1)
    {
        Console.WriteLine("Digite a placa do veículo para estacionar:");
        String Placa = Console.ReadLine();
        Console.WriteLine(estacionamento1.AdicionarCarro(Placa));      
        Console.WriteLine("Pressione uma tecla para continuar");
        Console.ReadLine();
        Console.Clear();
    }
    else if (escolha == 2)
    {
        Console.Write("Digite a placa do veículo para retirar: ");
        String Placa = Console.ReadLine();
        Console.Write("Digite a quantidade de horas no estacionamento: ");
        int hora = int .Parse(Console.ReadLine());
        Console.WriteLine(estacionamento1.RemoverCarro(Placa, hora));
        Console.WriteLine("Pressione uma tecla para continuar");
        Console.ReadLine();
        Console.Clear();
    }
    else if (escolha == 3)
    {
        Console.WriteLine("Segue os carros estacionados:");     
        estacionamento1.ListarCarros();
        Console.WriteLine("Pressione uma tecla para continuar");
        Console.ReadLine();
        Console.Clear();
    }
    else if (escolha == 4)
    {
        Console.WriteLine("Fechando o programa!");
    }
    else
    {
        Console.WriteLine("Insira uma opção válida!");
    }
    }
