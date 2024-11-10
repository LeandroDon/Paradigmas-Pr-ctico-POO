using Newtonsoft.Json;

public class RepositorioPagos
{
    private const string RutaArchivo = "pagos.json";
    private List<Pago> _pagos;

    public RepositorioPagos()
    {
        _pagos = CargarPagos();
    }

    public void AgregarPago(Pago pago)
    {
        _pagos.Add(pago);
        GuardarPagos();
    }

    public List<Pago> ObtenerPagos()
    {
        return _pagos;
    }

    private void GuardarPagos()
    {
        var jsonData = JsonConvert.SerializeObject(_pagos, Formatting.Indented);
        File.WriteAllText(RutaArchivo, jsonData);
    }

    private List<Pago> CargarPagos()
    {
        if (!File.Exists(RutaArchivo))
            return new List<Pago>();

        var jsonData = File.ReadAllText(RutaArchivo);
        return JsonConvert.DeserializeObject<List<Pago>>(jsonData) ?? new List<Pago>();
    }
}