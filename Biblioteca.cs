public class Livro
{
    public string Titulo;
    public string Autor;
    public int Ano;
    public Livro()
    {

    }

    public Livro(string titulo, string autor, int ano)
    {
        Titulo = titulo;
        Autor = autor;
        Ano = ano;
    }

    public void ExibirInfo()
    {
        Console.WriteLine("Titulo: " + Titulo);
        Console.WriteLine("Autor: " + Autor);
        Console.WriteLine("Ano: " + Ano);
    }

}

