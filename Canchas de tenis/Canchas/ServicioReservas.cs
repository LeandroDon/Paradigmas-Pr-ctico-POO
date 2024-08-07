public class ServicioReservas
{
    private RepositorioReservas repositorio;

    public ServicioReservas(RepositorioReservas repositorio)
    {
        this.repositorio = repositorio;
    }

    public void AgregarReserva(Reserva reserva)
    {
        repositorio.AgregarReserva(reserva);
    }

    public void EliminarReserva(int id)
    {
        repositorio.EliminarReserva(id);
    }

    public List<Reserva> ObtenerReservas()
    {
        return repositorio.ObtenerReservas();
    }

    public List<Reserva> ObtenerReservasPorCliente(int idCliente)
    {
        return repositorio.ObtenerReservasPorCliente(idCliente);
    }
}