public class ServicioReservas
{
    private readonly RepositorioReservas _repositorio;

    public ServicioReservas(RepositorioReservas repositorio)
    {
        this._repositorio = repositorio;
    }

    public void AgregarReserva(Reserva reserva)
    {
        _repositorio.AgregarReserva(reserva);
    }

    public void EliminarReserva(int id)
    {
        _repositorio.EliminarReserva(id);
    }

    public List<Reserva> ObtenerReservas()
    {
        return _repositorio.ObtenerReservas();
    }

    public List<Reserva> ObtenerReservasPorCliente(int idCliente)
    {
        return _repositorio.ObtenerReservasPorCliente(idCliente);
    }

    public Reserva? ObtenerReservaPorId(int idReserva)
    {
        return _repositorio.ObtenerReservaPorId(idReserva);
    }
}
