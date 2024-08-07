public class RepositorioReservas
{
    private List<Reserva> _reservas = new List<Reserva>();

    public void AgregarReserva(Reserva reserva)
    {
        reserva.Id = GeneradorId.ObtenerNuevoId();
        _reservas.Add(reserva);
    }

    public void EliminarReserva(int id)
    {
        var reserva = _reservas.FirstOrDefault(r => r.Id == id);
        if (reserva != null)
        {
            _reservas.Remove(reserva);
        }
    }

    public List<Reserva> ObtenerReservas()
    {
        return _reservas;
    }

    public List<Reserva> ObtenerReservasPorCliente(int idCliente)
    {
        return _reservas.Where(r => r.IdCliente == idCliente).ToList();
    }
}