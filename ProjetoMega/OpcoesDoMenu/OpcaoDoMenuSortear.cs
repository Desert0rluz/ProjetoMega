namespace ProjetoMega.OpcoesDoMenu;

internal class OpcaoDoMenuSortear
{
    public static void OpcaoDoMenu()
    {
        List<int> numerosSorteados = SortearNumeros();
        Console.WriteLine("Números sorteados:");
        foreach (int numero in numerosSorteados)
        {
            Console.WriteLine(numero);
        } 
    }
    static List<int> SortearNumeros()
    {
        Random random = new Random();
        HashSet<int> numerosSorteados = new HashSet<int>();

        while (numerosSorteados.Count < 6)
        {
            int numero = random.Next(1, 61);
            numerosSorteados.Add(numero);
        }
        return new List<int>(numerosSorteados);
    }
}

