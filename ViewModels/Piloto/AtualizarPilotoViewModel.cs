namespace VoeAirlines.ViewModels;

public class AtualizarPilotoViewModel
{
    public AtualizarPilotoViewModel(int id, string nome, string matricula, string cpf, string registro, string curso)
    {
        Id = id;
        Nome = nome;
        Matricula = matricula;
        CPF = cpf;
        Registro = registro;
        Curso = curso;
    }

    public int Id { get; set; }
    public string Nome { get; set; }
    public string Matricula { get; set; }
    public string CPF { get; set; }
    public string Registro { get; set; }
    public string Curso { get; internal set; }
}