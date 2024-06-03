public class Funcionario
{
    public string Nome;
    public string Cargo;
    public int Salario;

    public Funcionario()
    {
        Nome = "desconhecido";
        Cargo = "nao informado";
        Salario = 0;
    }

    public Funcionario(string nome, string cargo, int salario)
    {
        Nome = nome;
        Cargo = cargo;
        Salario = salario;
    }
}
