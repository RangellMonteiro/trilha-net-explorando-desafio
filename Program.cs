// See https://aka.ms/new-console-template for more information
using System.Text;
using DesafioDeProgramacao02.Models;

Console.OutputEncoding = Encoding.UTF8;

// Cria os modelos de hóspedes e cadastra na lista de hóspedes
List<Pessoa> hospedes = new List<Pessoa>();

Pessoa p1 = new Pessoa(nome: "Hóspede 1");
Pessoa p2 = new Pessoa(nome: "Hóspede 2");

hospedes.Add(p1);
hospedes.Add(p2);

// Cria a suíte
Suite suite = new Suite(tipoSuite: "Premium", capacidade: 2, valorDiaria: 30);


// Cria uma nova reserva, passando a suíte e os hóspedes
Reserva reserva = new Reserva(diasReservados: 5);
reserva.CadastrarSuite(suite);
reserva.CadastrarHospedes(hospedes);

bool exibirMenu = true;

// Realiza o loop do menu
while (exibirMenu)
{
    Console.Clear();
    Console.WriteLine("Digite a sua opção:");
    Console.WriteLine("1 - Exibir quantidade de hóspedes");
    Console.WriteLine("2 - exibir valor da diária");
    Console.WriteLine("3 - Sair do programa");

    switch (Console.ReadLine())
    {
        case "1":
            Console.WriteLine($"Hóspedes: {reserva.ObterQuantidadeHospedes()}");
            break;

        case "2":
            Console.WriteLine($"Valor diária: {reserva.CalcularValorDiaria()}");;
            break;

        case "3":
            Console.WriteLine("Saindo do programa...");
            exibirMenu = false;
            break;

        default:
            Console.WriteLine("Opção inválida");
            break;
    }

    Console.WriteLine("Pressione uma tecla para continuar");
    Console.ReadLine();
}

Console.WriteLine("O programa se encerrou");
