using VoeAirlines.Contexts;
using VoeAirlines.Entities;
using VoeAirlines.Validators;
using VoeAirlines.ViewModels;
using FluentValidation;

namespace VoeAirlines.Services;

public class PilotoService
{
    private readonly VoeAirlinesContext _context;
    private readonly AdicionarPilotoValidator _adicionarPilotoValidator;
    private readonly AtualizarPilotoValidator _atualizarPilotoValidator;
    private readonly ExcluirPilotoValidator _excluirPilotoValidator;

    public PilotoService(VoeAirlinesContext context, AdicionarPilotoValidator adicionarPilotoValidator, AtualizarPilotoValidator atualizarPilotoValidator, ExcluirPilotoValidator excluirPilotoValidator)
    {
        _context = context;
        _adicionarPilotoValidator = adicionarPilotoValidator;
        _atualizarPilotoValidator = atualizarPilotoValidator;
        _excluirPilotoValidator = excluirPilotoValidator;
    }

    public DetalhesPilotoViewModel AdicionarPiloto(AdicionarPilotoViewModel dados)
    {
        _adicionarPilotoValidator.ValidateAndThrow(dados);

        var piloto = new Piloto(dados.Nome, dados.Matricula, dados.Registro, dados.CPF, dados.Curso);

        _context.Add(piloto);
        _context.SaveChanges();

        return new DetalhesPilotoViewModel(piloto.Id, piloto.Nome, piloto.Matricula, piloto.Registro, piloto.CPF, piloto.Curso);
    }

    public IEnumerable<ListarPilotoViewModel> ListarPilotos()
    {
        return _context.Pilotos.Select(p => new ListarPilotoViewModel(p.Id, p.Nome));
    }

    public DetalhesPilotoViewModel? ListarPilotoPeloId(int id)
    {
        var piloto = _context.Pilotos.Find(id);

        if (piloto != null)
        {
            return NewMethod(piloto);
        }

        return null;
    }

    private static DetalhesPilotoViewModel NewMethod(Piloto piloto)
    {
        return new DetalhesPilotoViewModel(piloto.Id, piloto.Nome, piloto.Matricula, piloto.Registro, piloto.CPF, piloto.Curso);
    }

    public DetalhesPilotoViewModel? AtualizarPiloto(AtualizarPilotoViewModel dados)
    {
        _atualizarPilotoValidator.ValidateAndThrow(dados);

        var piloto = _context.Pilotos.Find(dados.Id);

        if (piloto == null)
        {
            return null;
        }
        piloto.Nome = dados.Nome;
        piloto.Matricula = dados.Matricula;
        piloto.Registro = dados.Registro;
        piloto.CPF = dados.CPF;
        piloto.Curso = dados.Curso;

        _context.Update(piloto);
        _context.SaveChanges();

        return new DetalhesPilotoViewModel(piloto.Id, piloto.Nome, piloto.Matricula, piloto.Registro, piloto.CPF, piloto.Curso);
    }

    public void ExcluirPiloto(int id)
    {
        _excluirPilotoValidator.ValidateAndThrow(id);

        var piloto = _context.Pilotos.Find(id);

        if (piloto != null)
        {
            _context.Remove(piloto);
            _context.SaveChanges();
        }
    }
}