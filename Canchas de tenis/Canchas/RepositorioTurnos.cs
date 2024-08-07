using System.Collections.Generic;
using System.Linq;

public class RepositorioTurnos
{
    private List<Turno> turnos;

    public RepositorioTurnos()
    {
        turnos = new List<Turno>();
    }

    public void AgregarTurno(Turno turno)
    {
        if (turnos.Any(t => t.Id == turno.Id))
        {
            throw new InvalidOperationException("El turno ya existe.");
        }

        if (turnos.Any(t => t.CanchaId == turno.CanchaId &&
                           t.Fecha == turno.Fecha &&
                           (turno.HoraInicio < t.HoraFin && turno.HoraFin > t.HoraInicio)))
        {
            throw new InvalidOperationException("El turno se superpone con otro turno existente.");
        }
        
        turno.Id = GeneradorId.ObtenerNuevoId();
        turnos.Add(turno);
    }

    public void EliminarTurno(int id)
    {
        var turno = turnos.SingleOrDefault(t => t.Id == id);
        if (turno == null)
        {
            throw new KeyNotFoundException("El turno no existe.");
        }

        turnos.Remove(turno);
    }

    public List<Turno> ObtenerTurnos()
    {
        return turnos;
    }

    public List<Turno> ObtenerTurnosPorCancha(int canchaId)
    {
        return turnos.Where(t => t.CanchaId == canchaId).ToList();
    }

    public List<Turno> ObtenerTurnosPorFecha(DateTime fecha)
    {
        return turnos.Where(t => t.Fecha.Date == fecha.Date).ToList();
    }
}

public class Turno
{
    public int Id { get; set; }
    public int CanchaId { get; set; }
    public DateTime Fecha { get; set; }
    public TimeSpan HoraInicio { get; set; }
    public TimeSpan HoraFin { get; set; }

    public Turno() { }

    public Turno(int canchaId, DateTime fecha, TimeSpan horaInicio, TimeSpan horaFin)
    {
        CanchaId = canchaId;
        Fecha = fecha;
        HoraInicio = horaInicio;
        HoraFin = horaFin;
    }
}