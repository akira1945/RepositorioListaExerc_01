using ConsoleApp.ExerciciosMod01.Classes;

internal class Program
{
    private static void Main(string[] args)
    {
        
        // List<ItemLocadora>;
        Filme filme = new Filme(1, "Resgate Soldado Ryan", 1998, "Spilberg", 230);
        filme.ExibirDetalhes();
    }
}