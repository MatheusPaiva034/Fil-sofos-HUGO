bool f1Faca = false, f1Garfo = false, f1Comeu = false;
bool f2Faca = false, f2Garfo = false, f2Comeu = false;


Console.WriteLine("        FILÓSOFOS À MESA\n");

Console.WriteLine("   (F1)                 (F2)");
Console.WriteLine("    O                     O");
Console.WriteLine("   /|\\                   /|\\");
Console.WriteLine("   / \\                   / \\");
Console.WriteLine("     \\_________________/");
Console.WriteLine("        |  🍽️   🍽️  |");
Console.WriteLine("        |  faca garfo |");
Console.WriteLine("        |_____________|");

while (true)
{
    Console.WriteLine("\n===== MENU =====");
    Console.WriteLine("1 - F1 pegar faca (α1)");
    Console.WriteLine("2 - F1 pegar garfo (β1)");
    Console.WriteLine("3 - F1 comer/devolver (γ1)");
    Console.WriteLine("4 - F2 pegar faca (α2)");
    Console.WriteLine("5 - F2 pegar garfo (β2)");
    Console.WriteLine("6 - F2 comer/devolver (γ2)");
    Console.WriteLine("7 - Ver gabarito");
    Console.WriteLine("8 - Sair");

    int op = int.Parse(Console.ReadLine());

    // F1
    if (op == 1)
    {
        if (!f1Faca)
        {
            f1Faca = true;
            Console.WriteLine("F1 pegou a faca");
        }
        else Erro();
    }
    else if (op == 2)
    {
        if (!f1Garfo)
        {
            f1Garfo = true;
            Console.WriteLine("F1 pegou o garfo");
        }
        else Erro();
    }
    else if (op == 3)
    {
        if (f1Faca && f1Garfo)
        {
            f1Faca = false;
            f1Garfo = false;
            f1Comeu = true;
            Console.WriteLine("F1 comeu e devolveu os talheres");
        }
        else Erro();
    }

    // F2
    else if (op == 4)
    {
        if (!f2Faca)
        {
            f2Faca = true;
            Console.WriteLine("F2 pegou a faca");
        }
        else Erro();
    }
    else if (op == 5)
    {
        if (!f2Garfo)
        {
            f2Garfo = true;
            Console.WriteLine("F2 pegou o garfo");
        }
        else Erro();
    }
    else if (op == 6)
    {
        if (f2Faca && f2Garfo)
        {
            f2Faca = false;
            f2Garfo = false;
            f2Comeu = true;
            Console.WriteLine("F2 comeu e devolveu os talheres");
        }
        else Erro();
    }

    // GABARITO
    else if (op == 7)
    {
        Console.WriteLine("\n===== GABARITO =====");
        Console.WriteLine("Opção 1:");
        Console.WriteLine("1 → 2 → 3 → 4 → 5 → 6");
        Console.WriteLine("(F1 come primeiro, depois F2)");

        Console.WriteLine("\nOpção 2:");
        Console.WriteLine("4 → 5 → 6 → 1 → 2 → 3");
        Console.WriteLine("(F2 come primeiro, depois F1)");
    }

    else if (op == 8)
    {
        break;
    }
    else
    {
        Console.WriteLine("Opção inválida!");
    }

    // Verifica se os dois comeram
    if (f1Comeu && f2Comeu)
    {
        Console.WriteLine("\n✅ Os dois filósofos comeram e voltaram a pensar!");
        break;
    }
}
    

    static void Erro()
{
    Console.WriteLine("\n❌ O FILOSOFO FOI PELO CAMINHO ERRADO E OS DOIS NÃO VAO CONSEGUIR COMER E VOLTAR A PENSAR");
}
