using System;
using System.Collections.Generic;
using System.Linq;

public abstract class EntidadBase
{
    public int Id { get; set; }
}

public class GeneradorId
{
    private static int _ultimoId = 0;

    public static int ObtenerNuevoId()
    {
        return ++_ultimoId;
    }
}
public class Usuario : EntidadBase
{
    public string Nombre { get; }
    public string Email { get; }

    public Usuario(string nombre, string email)
    {
        if (string.IsNullOrWhiteSpace(nombre) || string.IsNullOrWhiteSpace(email))
            throw new ArgumentException("Nombre y Email no pueden ser nulos o vacíos.");

        Nombre = nombre ?? throw new ArgumentNullException(nameof(nombre));
        Email = email ?? throw new ArgumentNullException(nameof(email));
    }
}

public class Cliente : Usuario
{
    // La propiedad Telefono debe estar en esta clase, no en Usuario
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
    public Pago? Pago { get; set; }
}

public class Pago : EntidadBase
{
    public int IdReserva { get; set; }
    public decimal Monto { get; set; }
    public DateTime FechaPago { get; set; }
public Pago()
    {
    }

    // O un constructor que inicialice todos los campos
    public Pago(int idReserva, decimal monto, DateTime fechaPago)
    {
        IdReserva = idReserva;
        Monto = monto;
        FechaPago = fechaPago;
    }
}