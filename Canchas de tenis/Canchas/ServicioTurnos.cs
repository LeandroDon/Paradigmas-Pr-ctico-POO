using System.Collections.Generic;

public class ServicioTurnos
{
    private RepositorioTurnos repositorio;

    public ServicioTurnos(RepositorioTurnos repositorio)
    {
        this.repositorio = repositorio;
    }

    public void AgregarTurno(Turno turno)
    {
        repositorio.AgregarTurno(turno);
    }

    public void EliminarTurno(int id)
    {
        repositorio.EliminarTurno(id);
    }

    public List<Turno> ObtenerTurnos()
    {
        return repositorio.ObtenerTurnos();
    }

    public List<Turno> ObtenerTurnosPorCancha(int idCancha)
    {
        return repositorio.ObtenerTurnosPorCancha(idCancha);
    }
}