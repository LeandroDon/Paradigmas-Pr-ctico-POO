public class ServicioPagos
{
    private readonly RepositorioPagos _repositorio;

    public ServicioPagos(RepositorioPagos repositorio)
    {
        _repositorio = repositorio;
    }

    public void AgregarPago(Pago pago)
    {
        pago.Id = GeneradorId.ObtenerNuevoId();
        _repositorio.AgregarPago(pago);
    }

    public List<Pago> ObtenerPagos()
    {
        return _repositorio.ObtenerPagos();
    }

    public bool ExistePagoPorReserva(int idReserva)
    {
        return _repositorio.ObtenerPagos().Any(pago => pago.IdReserva == idReserva);
    }
}