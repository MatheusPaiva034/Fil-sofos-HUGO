Filosofos f = new Filosofos();
int opcao;

do
{
    Console.WriteLine("\n=== MENU ===");
    Console.WriteLine("1 - F1 comer");
    Console.WriteLine("2 - F2 comer");
    Console.WriteLine("0 - Sair");
    Console.Write("Escolha: ");

    opcao = int.Parse(Console.ReadLine());

    Console.WriteLine();

    switch (opcao)
    {
        case 1:
            f.ComerF1();
            break;

        case 2:
            f.ComerF2();
            break;

        case 0:
            Console.WriteLine("Encerrando");
            break;

        default:
            Console.WriteLine("Opção inválida!");
            break;
    }

} while (opcao != 0);
