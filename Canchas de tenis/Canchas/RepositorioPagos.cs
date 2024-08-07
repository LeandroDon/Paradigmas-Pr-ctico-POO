public class RepositorioPagos
{
    private List<Pago> pagos;

    public RepositorioPagos()
    {
        pagos = new List<Pago>();
    }

    public void AgregarPago(Pago pago)
    {
        pagos.Add(pago);
    }

    public void EliminarPago(int id)
    {
        var pago = pagos.SingleOrDefault(p => p.Id == id);
        if (pago != null)
        {
            pagos.Remove(pago);
        }
    }

    public List<Pago> ObtenerPagos()
    {
        return pagos;
    }

    public List<Pago> ObtenerPagosPorReserva(int idReserva)
    {
        return pagos.Where(p => p.IdReserva == idReserva).ToList();
    }
}