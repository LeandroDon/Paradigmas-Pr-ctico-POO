using Newtonsoft.Json;

public class RepositorioReservas
{
    private const string RutaArchivo = "reservas.json";
    private List<Reserva> _reservas;

    public RepositorioReservas()
    {
        _reservas = CargarReservas();
    }

    public void AgregarReserva(Reserva reserva)
    {
        reserva.Id = GeneradorId.ObtenerNuevoId();
        _reservas.Add(reserva);
        GuardarReservas();
    }

    public void EliminarReserva(int id)
    {
        var reserva = _reservas.FirstOrDefault(r => r.Id == id);
        if (reserva != null)
        {
            _reservas.Remove(reserva);
            GuardarReservas();
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

    public Reserva? ObtenerReservaPorId(int id)
    {
        return _reservas.FirstOrDefault(r => r.Id == id);
    }

    private void GuardarReservas()
    {
        var jsonData = JsonConvert.SerializeObject(_reservas, Formatting.Indented);
        File.WriteAllText(RutaArchivo, jsonData);
    }

    private List<Reserva> CargarReservas()
    {
        if (!File.Exists(RutaArchivo))
            return new List<Reserva>();

        var jsonData = File.ReadAllText(RutaArchivo);
        return JsonConvert.DeserializeObject<List<Reserva>>(jsonData) ?? new List<Reserva>();
    }
}