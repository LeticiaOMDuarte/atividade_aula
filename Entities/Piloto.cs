namespace VoeAirlines.Entities;

public class Piloto
{
    public Piloto(string nome, string matricula, string registro, string cpf, string curso)
    {
        Nome = nome;
        Matricula = matricula;
        Registro = registro;
        CPF = cpf;
        Curso = curso;
    }

   
    public int Id { get; set; }
    public string Nome { get; set; }
    public string Matricula { get; set; }
    public string Registro { get; set; }
    public string CPF { get; set; }

    public string Curso { get; set; }
    public ICollection<Voo> Voos { get; set; } = null!;
   
}