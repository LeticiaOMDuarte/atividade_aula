namespace VoeAirlines.ViewModels;

public class DetalhesPilotoViewModel
{
   
    public DetalhesPilotoViewModel(int id, string nome, string matricula, string registro, string cpf, string curso)
    {
        Id = id;
        Nome = nome;
        Matricula = matricula;
        Registro = registro;
        CPF = cpf;
     
    }


    public int Id { get; set; }
    public string Nome { get; set; }
    public string Matricula { get; set; }

    public string Registro { get; set; }

    public string CPF { get; set; }
}