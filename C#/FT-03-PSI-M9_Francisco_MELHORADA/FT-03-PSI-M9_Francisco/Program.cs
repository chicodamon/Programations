using FT_03_PSI_M9_Francisco;

int x = 0;
while (x != 5)
{
    Console.WriteLine("---MENU---");
    Console.WriteLine("1. Criar Viatura");
    Console.WriteLine("2. Alterar Viatura");
    Console.WriteLine("3. Remover Viatura");
    Console.WriteLine("4. Listar Viatura");
    Console.WriteLine("5. Sair");

    x = Convert.ToInt32(Console.ReadLine());

    switch (x)
    {
        case 1:
            Console.WriteLine("Criar Viatura");
            Console.Write("Introduza a Marca da Viatura: ");
            string marca = Console.ReadLine();
            Console.Write("Introduza o Modelo da Viatura: ");
            string modelo = Console.ReadLine();
            Console.Write("Introduza o Nº de portas: ");
            int numPortas = Convert.ToInt32(Console.ReadLine());
            Console.Write("Introduza o Ano da Viatura: ");
            int ano = Convert.ToInt32(Console.ReadLine());

            Viatura.CriarViatura(marca, modelo, numPortas, ano);
            break;
        case 2:
            Console.WriteLine("Editar Viatura");
            if (Viatura.ListaViaturas.Count == 0)
            {
                Console.WriteLine("Não existem viaturas a editar");
            }
            else
            {
                Viatura.EditarViatura();
            }
        break;
        case 3:
            Console.WriteLine("Remover Viatura");
            Viatura.RemoverViatura();
            break;
        case 4:
            Viatura.ListarViaturas();
            break;

        case 5:
            Console.WriteLine("A sair...");
            break;

        default:
            Console.WriteLine("Opção inválida.");
            break;
    }
}