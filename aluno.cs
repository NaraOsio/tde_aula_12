public class Aluno
{
    public string Nome;
    public int Idade;

    public Aluno()
    {
        Nome = "Não Informado";
        Idade = 0;
    }

    public Aluno(string nome, int idade)
    {
        Nome = nome;
        Idade = idade;
    }
}