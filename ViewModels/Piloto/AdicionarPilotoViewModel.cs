namespace VoeAirlines.ViewModels;

public class AdicionarPilotoViewModel
{


    public AdicionarPilotoViewModel(string nome, string matricula, string registro, string cpf, string curso)
    {
        Nome = nome;
        Matricula = matricula;
        Registro = registro;
        CPF = cpf;
        Curso = curso;
        
    }

    public string Nome { get; set; }
    public string Matricula { get; set; }

    public string Registro { get; set; }
    public string CPF { get; set; }

    public string Curso { get; set; }
}