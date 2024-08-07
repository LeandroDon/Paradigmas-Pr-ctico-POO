public class ServicioPagos
{
    private RepositorioPagos repositorio;

    public ServicioPagos(RepositorioPagos repositorio)
    {
        this.repositorio = repositorio;
    }

    public void AgregarPago(Pago pago)
    {
        repositorio.AgregarPago(pago);
    }

    public List<Pago> ObtenerPagos()
    {
        return repositorio.ObtenerPagos();
    }

    public List<Pago> ObtenerPagosPorReserva(int idReserva)
    {
        return repositorio.ObtenerPagosPorReserva(idReserva);
    }
}