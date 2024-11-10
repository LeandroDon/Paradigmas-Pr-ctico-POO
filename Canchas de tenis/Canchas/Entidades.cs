using Newtonsoft.Json;

public abstract class EntidadBase
{
    public int Id { get; set; }
}

public class GeneradorId
{
    private const string RutaArchivo = "ultimoId.json";
    private static int _ultimoId;

    static GeneradorId()
    {
        CargarUltimoId();
    }

    public static int ObtenerNuevoId()
    {
        _ultimoId++;
        GuardarUltimoId();
        return _ultimoId;
    }

    private static void CargarUltimoId()
    {
        if (File.Exists(RutaArchivo))
        {
            var jsonData = File.ReadAllText(RutaArchivo);
            _ultimoId = JsonConvert.DeserializeObject<int>(jsonData);
        }
        else
        {
            _ultimoId = 0;
        }
    }

    public static void GuardarUltimoId()
    {
        var jsonData = JsonConvert.SerializeObject(_ultimoId);
        File.WriteAllText(RutaArchivo, jsonData);
    }
}

public class Usuario : EntidadBase
{
    public string Nombre { get; }
    public string Email { get; }

    public Usuario(string nombre, string email)
    {
        if (string.IsNullOrWhiteSpace(nombre) || string.IsNullOrWhiteSpace(email))
            throw new ArgumentException("Nombre e Email no pueden ser nulos o vacíos.");

        Nombre = nombre ?? throw new ArgumentNullException(nameof(nombre));
        Email = email ?? throw new ArgumentNullException(nameof(email));
    }
}

public class Cliente : Usuario
{
    public string Telefono { get; }

    public Cliente(string nombre, string email, string telefono) : base(nombre, email)
    {
        if (string.IsNullOrWhiteSpace(telefono))
            throw new ArgumentException("Telefono no puede ser nulo o vacío.");

        Telefono = telefono;
    }
}

public class Cancha : EntidadBase
{
    public required string Nombre { get; set; }
    public required TipoCancha Tipo { get; set; }
    public bool EstaDisponible { get; set; }
}

public class TipoCancha : EntidadBase
{
    public required string Nombre { get; set; }
    public decimal PrecioHora { get; set; }
}

public class Reserva : EntidadBase
{
    public int IdCancha { get; set; }
    public int IdCliente { get; set; }
    public DateTime Fecha { get; set; }
    public TimeSpan HoraInicio { get; set; }
    public TimeSpan HoraFin { get; set; }
    public decimal MontoTotal { get; set; }
}

public class Pago : EntidadBase
{
    public int IdCliente { get; set; }
    public int IdReserva { get; set; }
    public decimal Monto { get; set; }
    public DateTime FechaPago { get; set; }

    public Pago(int idCliente, int idReserva, decimal monto, DateTime fechaPago)
    {
        IdCliente = idCliente;
        IdReserva = idReserva;
        Monto = monto;
        FechaPago = fechaPago;
    }
}