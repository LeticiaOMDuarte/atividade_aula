/*
    namespace = organização ou agrupamento lógico de classe

*/
namespace VoeAirlines.Entities;

// A classe é um conjunto de objetos
public class Login{  //PascalCasing

    public int Id { get; set; }

    public string? Usuario { get; set; } // Propriedade automatica

    public string? Senha { get; set; } // Propriedade automatica

    //Construtor

    public Login(string? usuario, string? senha)
    {
        Usuario = usuario;
        Senha = senha;
    }
}