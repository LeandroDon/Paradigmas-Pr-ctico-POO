using System;
using System.Collections.Generic;
using System.Linq;
class Program
{
    static void Main(string[] args)
    {
        var repositorioUsuarios = new RepositorioUsuarios();
        var repositorioClientes = new RepositorioClientes();
        var repositorioCanchas = new RepositorioCanchas();
        var repositorioTiposCanchas = new RepositorioTiposCanchas();
        var repositorioReservas = new RepositorioReservas();
        var repositorioPagos = new RepositorioPagos();

        var servicioUsuarios = new ServicioUsuarios(repositorioUsuarios);
        var servicioClientes = new ServicioClientes(repositorioClientes);
        var servicioCanchas = new ServicioCanchas(repositorioCanchas, repositorioTiposCanchas);
        var servicioTiposCanchas = new ServicioTiposCanchas(repositorioTiposCanchas);
        var servicioReservas = new ServicioReservas(repositorioReservas);
        var servicioPagos = new ServicioPagos(repositorioPagos);

        while (true)
        {
            try
            {
            Console.Clear();
            }
            catch (IOException ex)
            {
            Console.WriteLine("No se pudo limpiar la consola: " + ex.Message);
            }
            Console.WriteLine("Menú Principal");
            Console.WriteLine("1. Gestionar Usuarios");
            Console.WriteLine("2. Gestionar Clientes");
            Console.WriteLine("3. Gestionar Canchas");
            Console.WriteLine("4. Gestionar Tipos de Canchas");
            Console.WriteLine("5. Gestionar Reservas");
            Console.WriteLine("6. Gestionar Pagos");
            Console.WriteLine("7. Reportes");
            Console.WriteLine("0. Salir");
            Console.Write("Seleccione una opción: ");

            var opcion = Console.ReadLine();

            switch (opcion)
            {
                case "1":
                    GestionarUsuarios(servicioUsuarios);
                    break;
                case "2":
                    GestionarClientes(servicioClientes);
                    break;
                case "3":
                    GestionarCanchas(servicioCanchas);
                    break;
                case "4":
                    GestionarTiposCanchas(servicioTiposCanchas);
                    break;
                case "5":
                    GestionarReservas(servicioReservas, servicioClientes, servicioCanchas);
                    break;
                case "6":
                    GestionarPagos(servicioPagos, servicioReservas);
                    break;
                case "7":
                    GestionarReportes(servicioUsuarios, servicioClientes, servicioCanchas, servicioReservas, servicioPagos);
                    break;
                case "0":
                    return;
                default:
                    Console.WriteLine("Opción no válida. Inténtelo de nuevo.");
                    break;
            }
        }
    }

    static void GestionarUsuarios(ServicioUsuarios servicio)
    {
        while (true)
        {
            try
            {
            Console.Clear();
            }
            catch (IOException ex)
            {
            Console.WriteLine("No se pudo limpiar la consola: " + ex.Message);
            }
            Console.WriteLine("Gestión de Usuarios");
            Console.WriteLine("1. Agregar Usuario");
            Console.WriteLine("2. Eliminar Usuario");
            Console.WriteLine("3. Listar Usuarios");
            Console.WriteLine("0. Volver al Menú Principal");
            Console.Write("Seleccione una opción: ");

            var opcion = Console.ReadLine();

            switch (opcion)
            {
                case "1":
                    AgregarUsuario(servicio);
                    break;
                case "2":
                    EliminarUsuario(servicio);
                    break;
                case "3":
                    ListarUsuarios(servicio);
                    break;
                case "0":
                    return;
                default:
                    Console.WriteLine("Opción no válida. Inténtelo de nuevo.");
                    break;
            }
        }
    }
    static void GestionarClientes(ServicioClientes servicio)
    {
        while (true)
        {
            try
            {
            Console.Clear();
            }
            catch (IOException ex)
            {
            Console.WriteLine("No se pudo limpiar la consola: " + ex.Message);
            }
            Console.WriteLine("Gestión de Clientes");
            Console.WriteLine("1. Agregar Cliente");
            Console.WriteLine("2. Eliminar Cliente");
            Console.WriteLine("3. Listar Clientes");
            Console.WriteLine("0. Volver al Menú Principal");
            Console.Write("Seleccione una opción: ");

            var opcion = Console.ReadLine();

            switch (opcion)
            {
                case "1":
                    AgregarCliente(servicio);
                    break;
                case "2":
                    EliminarCliente(servicio);
                    break;
                case "3":
                    ListarClientes(servicio);
                    break;
                case "0":
                    return;
                default:
                    Console.WriteLine("Opción no válida. Inténtelo de nuevo.");
                    break;
            }
        }
    }
    static void GestionarCanchas(ServicioCanchas servicio)
    {
        while (true)
        {
            try
            {
            Console.Clear();
            }
            catch (IOException ex)
            {
            Console.WriteLine("No se pudo limpiar la consola: " + ex.Message);
            }
            Console.WriteLine("Gestión de Canchas");
            Console.WriteLine("1. Agregar Cancha");
            Console.WriteLine("2. Eliminar Cancha");
            Console.WriteLine("3. Listar Canchas");
            Console.WriteLine("0. Volver al Menú Principal");
            Console.Write("Seleccione una opción: ");

            var opcion = Console.ReadLine();

            switch (opcion)
            {
                case "1":
                    AgregarCancha(servicio);
                    break;
                case "2":
                    EliminarCancha(servicio);
                    break;
                case "3":
                    ListarCanchas(servicio);
                    break;
                case "0":
                    return;
                default:
                    Console.WriteLine("Opción no válida. Inténtelo de nuevo.");
                    break;
            }
        }
    }
    static void GestionarTiposCanchas(ServicioTiposCanchas servicio)
{
    while (true)
    {
        try
        {
            Console.Clear();
        }
        catch (IOException ex)
        {
            Console.WriteLine("No se pudo limpiar la consola: " + ex.Message);
        }
        Console.WriteLine("Gestión de Tipos de Canchas");
        Console.WriteLine("1. Agregar Tipo de Cancha");
        Console.WriteLine("2. Eliminar Tipo de Cancha");
        Console.WriteLine("3. Listar Tipos de Canchas");
        Console.WriteLine("0. Volver al Menú Principal");
        Console.Write("Seleccione una opción: ");

        var opcion = Console.ReadLine();

        switch (opcion)
        {
            case "1":
                AgregarTipoCancha(servicio);
                break;
            case "2":
                EliminarTipoCancha(servicio);
                break;
            case "3":
                ListarTiposCanchas(servicio);
                break;
            case "0":
                return;
            default:
                Console.WriteLine("Opción no válida. Inténtelo de nuevo.");
                break;
        }
    }
}

    static void GestionarReservas(ServicioReservas servicio, ServicioClientes servicioClientes, ServicioCanchas servicioCanchas)
    {
        while (true)
        {
            try
            {
            Console.Clear();
            }
            catch (IOException ex)
            {
            Console.WriteLine("No se pudo limpiar la consola: " + ex.Message);
            }
            Console.WriteLine("Gestión de Reservas");
            Console.WriteLine("1. Agregar Reserva");
            Console.WriteLine("2. Eliminar Reserva");
            Console.WriteLine("3. Listar Reservas");
            Console.WriteLine("4. Listar Reservas por Cliente");
            Console.WriteLine("0. Volver al Menú Principal");
            Console.Write("Seleccione una opción: ");

            var opcion = Console.ReadLine();

            switch (opcion)
            {
                case "1":
                    AgregarReserva(servicio, servicioClientes, servicioCanchas);
                    break;
                case "2":
                    EliminarReserva(servicio);
                    break;
                case "3":
                    ListarReservas(servicio);
                    break;
                case "4":
                    ListarReservasPorCliente(servicio, servicioClientes);
                    break;
                case "0":
                    return;
                default:
                    Console.WriteLine("Opción no válida. Inténtelo de nuevo.");
                    break;
            }
        }
    }
    static void GestionarPagos(ServicioPagos servicio, ServicioReservas servicioReservas)
    {
        while (true)
        {
            try
            {
            Console.Clear();
            }
            catch (IOException ex)
            {
            Console.WriteLine("No se pudo limpiar la consola: " + ex.Message);
            }
            Console.WriteLine("Gestión de Pagos");
            Console.WriteLine("1. Agregar Pago");
            Console.WriteLine("2. Listar Pagos");
            Console.WriteLine("0. Volver al Menú Principal");
            Console.Write("Seleccione una opción: ");

            var opcion = Console.ReadLine();

            switch (opcion)
            {
                case "1":
                    AgregarPago(servicio, servicioReservas);
                    break;
                case "2":
                    ListarPagos(servicio);
                    break;
                case "0":
                    return;
                default:
                    Console.WriteLine("Opción no válida. Inténtelo de nuevo.");
                    break;
            }
        }
    }

    static void GestionarReportes(ServicioUsuarios servicioUsuarios, ServicioClientes servicioClientes, ServicioCanchas servicioCanchas, ServicioReservas servicioReservas, ServicioPagos servicioPagos)
    {
        while (true)
        {
            try
            {
                Console.Clear();
            }
            catch (IOException ex)
            {
                Console.WriteLine("No se pudo limpiar la consola: " + ex.Message);
            }
            Console.WriteLine("Reportes");
            Console.WriteLine("1. Reporte de Usuarios");
            Console.WriteLine("2. Reporte de Clientes");
            Console.WriteLine("3. Reporte de Canchas");
            Console.WriteLine("4. Reporte de Reservas");
            Console.WriteLine("5. Reporte de Pagos");
            Console.WriteLine("0. Volver al Menú Principal");
            Console.Write("Seleccione una opción: ");

            var opcion = Console.ReadLine();

            switch (opcion)
            {
                case "1":
                    ReporteUsuarios(servicioUsuarios);
                    break;
                case "2":
                    ReporteClientes(servicioClientes);
                    break;
                case "3":
                    ReporteCanchas(servicioCanchas);
                    break;
                case "4":
                    ReporteReservas(servicioReservas);
                    break;
                case "5":
                    ReportePagos(servicioPagos);
                    break;
                case "0":
                    return;
                default:
                    Console.WriteLine("Opción no válida. Inténtelo de nuevo.");
                    break;
            }
        }
    }
    static void AgregarUsuario(ServicioUsuarios servicio)
{
    Console.Write("Nombre del usuario: ");
    var nombre = Console.ReadLine();
    Console.Write("Email del usuario: ");
    var email = Console.ReadLine();

    if (string.IsNullOrWhiteSpace(nombre) || string.IsNullOrWhiteSpace(email))
    {
        Console.WriteLine("Nombre y email no pueden ser nulos o vacíos.");
        return;
    }

    var usuario = new Usuario(nombre, email);
    servicio.AgregarUsuario(usuario);
    Console.WriteLine("Usuario agregado exitosamente.");
    Console.ReadKey();
}
    static void EliminarUsuario(ServicioUsuarios servicio)
    {
        Console.Write("ID del usuario a eliminar: ");
        if (int.TryParse(Console.ReadLine(), out var id))
        {
            servicio.EliminarUsuario(id);
            Console.WriteLine("Usuario eliminado exitosamente.");
        }
        else
        {
            Console.WriteLine("ID no válido.");
        }
        Console.ReadKey();
    }
    static void ListarUsuarios(ServicioUsuarios servicio)
    {
        var usuarios = servicio.ObtenerUsuarios();
        foreach (var usuario in usuarios)
        {
            Console.WriteLine($"ID: {usuario.Id}, Nombre: {usuario.Nombre}, Email: {usuario.Email}");
        }
        Console.ReadKey();
    }
    static void AgregarCliente(ServicioClientes servicio)
{
    Console.Write("Nombre del cliente: ");
    var nombre = Console.ReadLine();
    Console.Write("Email del cliente: ");
    var email = Console.ReadLine();
    Console.Write("Teléfono del cliente: ");
    var telefono = Console.ReadLine();

    if (string.IsNullOrWhiteSpace(nombre) || string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(telefono))
    {
        Console.WriteLine("Nombre, email y teléfono no pueden ser nulos o vacíos.");
        return;
    }

    var cliente = new Cliente(nombre, email, telefono);
    servicio.AgregarCliente(cliente);
    Console.WriteLine("Cliente agregado exitosamente.");
    Console.ReadKey();
}
    static void EliminarCliente(ServicioClientes servicio)
    {
        Console.Write("ID del cliente a eliminar: ");
        if (int.TryParse(Console.ReadLine(), out var id))
        {
            servicio.EliminarCliente(id);
            Console.WriteLine("Cliente eliminado exitosamente.");
        }
        else
        {
            Console.WriteLine("ID no válido.");
        }
        Console.ReadKey();
    }
    static void ListarClientes(ServicioClientes servicio)
    {
        var clientes = servicio.ObtenerClientes();
        foreach (var cliente in clientes)
        {
            Console.WriteLine($"ID: {cliente.Id}, Nombre: {cliente.Nombre}, Email: {cliente.Email}, Teléfono: {cliente.Telefono}");
        }
        Console.ReadKey();
    }
    static void AgregarCancha(ServicioCanchas servicio)
    {
        Console.Write("Nombre de la cancha: ");
        var nombre = Console.ReadLine();

        Console.WriteLine("Seleccione el tipo de cancha:");
        var tiposCanchas = servicio.ObtenerTiposCanchas();
        for (int i = 0; i < tiposCanchas.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {tiposCanchas[i].Nombre}");
        }
        if (int.TryParse(Console.ReadLine(), out var tipoIndex) && tipoIndex > 0 && tipoIndex <= tiposCanchas.Count)
        {
            var tipoCancha = tiposCanchas[tipoIndex - 1];
            var cancha = new Cancha { Nombre = nombre, Tipo = tipoCancha, EstaDisponible = true };
            servicio.AgregarCancha(cancha);
            Console.WriteLine("Cancha agregada exitosamente.");
        }
        else
        {
            Console.WriteLine("Tipo de cancha no válido.");
        }
        Console.ReadKey();
    }
    static void EliminarCancha(ServicioCanchas servicio)
    {
        Console.Write("ID de la cancha a eliminar: ");
        if (int.TryParse(Console.ReadLine(), out var id))
        {
            servicio.EliminarCancha(id);
            Console.WriteLine("Cancha eliminada exitosamente.");
        }
        else
        {
            Console.WriteLine("ID no válido.");
        }
        Console.ReadKey();
    }
    static void ListarCanchas(ServicioCanchas servicio)
    {
        var canchas = servicio.ObtenerCanchas();
        foreach (var cancha in canchas)
        {
            Console.WriteLine($"ID: {cancha.Id}, Nombre: {cancha.Nombre}, Tipo: {cancha.Tipo.Nombre}, Disponible: {cancha.EstaDisponible}");
        }
        Console.ReadKey();
    }
    static void AgregarTipoCancha(ServicioTiposCanchas servicio)
    {
        Console.Write("Nombre del tipo de cancha: ");
        var nombre = Console.ReadLine();
        Console.Write("Precio por hora: ");
        if (decimal.TryParse(Console.ReadLine(), out var precioHora))
        {
            var tipoCancha = new TipoCancha { Nombre = nombre, PrecioHora = precioHora };
            servicio.AgregarTipoCancha(tipoCancha);
            Console.WriteLine("Tipo de cancha agregado exitosamente.");
        }
        else
        {
            Console.WriteLine("Precio no válido.");
        }
        Console.ReadKey();
    }

    static void EliminarTipoCancha(ServicioTiposCanchas servicio)
{
    Console.Write("ID del tipo de cancha a eliminar: ");
    if (int.TryParse(Console.ReadLine(), out var id))
    {
        servicio.EliminarTipoCancha(id);
        Console.WriteLine("Tipo de cancha eliminado exitosamente.");
    }
    else
    {
        Console.WriteLine("ID no válido.");
    }
    Console.ReadKey();
}

    static void ListarTiposCanchas(ServicioTiposCanchas servicio)
    {
        var tiposCanchas = servicio.ObtenerTiposCanchas();
        foreach (var tipoCancha in tiposCanchas)
        {
            Console.WriteLine($"ID: {tipoCancha.Id}, Nombre: {tipoCancha.Nombre}, Precio por Hora: {tipoCancha.PrecioHora}");
        }
        Console.ReadKey();
    }
    static void AgregarReserva(ServicioReservas servicio, ServicioClientes servicioClientes, ServicioCanchas servicioCanchas)
    {
        Console.WriteLine("Seleccione el cliente:");
        var clientes = servicioClientes.ObtenerClientes();
        for (int i = 0; i < clientes.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {clientes[i].Nombre}");
        }
        if (int.TryParse(Console.ReadLine(), out var clienteIndex) && clienteIndex > 0 && clienteIndex <= clientes.Count)
        {
            var cliente = clientes[clienteIndex - 1];

            Console.WriteLine("Seleccione la cancha:");
            var canchas = servicioCanchas.ObtenerCanchas();
            for (int i = 0; i < canchas.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {canchas[i].Nombre}");
            }
            if (int.TryParse(Console.ReadLine(), out var canchaIndex) && canchaIndex > 0 && canchaIndex <= canchas.Count)
            {
                var cancha = canchas[canchaIndex - 1];

                Console.Write("Fecha de la reserva (YYYY-MM-DD): ");
                if (DateTime.TryParse(Console.ReadLine(), out var fecha))
                {
                    Console.Write("Hora de inicio (HH:MM): ");
                    if (TimeSpan.TryParse(Console.ReadLine(), out var horaInicio))
                    {
                        Console.Write("Hora de fin (HH:MM): ");
                        if (TimeSpan.TryParse(Console.ReadLine(), out var horaFin))
                        {
                            var reserva = new Reserva
                            {
                                IdCliente = cliente.Id,
                                IdCancha = cancha.Id,
                                Fecha = fecha,
                                HoraInicio = horaInicio,
                                HoraFin = horaFin
                            };
                            servicio.AgregarReserva(reserva);
                            Console.WriteLine("Reserva agregada exitosamente.");
                        }
                        else
                        {
                            Console.WriteLine("Hora de fin no válida.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Hora de inicio no válida.");
                    }
                }
                else
                {
                    Console.WriteLine("Fecha no válida.");
                }
            }
            else
            {
                Console.WriteLine("Cancha no válida.");
            }
        }
        else
        {
            Console.WriteLine("Cliente no válido.");
        }
        Console.ReadKey();
    }
    static void EliminarReserva(ServicioReservas servicio)
    {
        Console.Write("ID de la reserva a eliminar: ");
        if (int.TryParse(Console.ReadLine(), out var id))
        {
            servicio.EliminarReserva(id);
            Console.WriteLine("Reserva eliminada exitosamente.");
        }
        else
        {
            Console.WriteLine("ID no válido.");
        }
        Console.ReadKey();
    }
    static void ListarReservas(ServicioReservas servicio)
    {
        var reservas = servicio.ObtenerReservas();
        foreach (var reserva in reservas)
        {
            Console.WriteLine($"ID: {reserva.Id}, Cliente ID: {reserva.IdCliente}, Cancha ID: {reserva.IdCancha}, Fecha: {reserva.Fecha.ToShortDateString()}, Hora Inicio: {reserva.HoraInicio}, Hora Fin: {reserva.HoraFin}");
        }
        Console.ReadKey();
    }
    static void ListarReservasPorCliente(ServicioReservas servicio, ServicioClientes servicioClientes)
    {
        Console.WriteLine("Seleccione el cliente:");
        var clientes = servicioClientes.ObtenerClientes();
        for (int i = 0; i < clientes.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {clientes[i].Nombre}");
        }
        if (int.TryParse(Console.ReadLine(), out var clienteIndex) && clienteIndex > 0 && clienteIndex <= clientes.Count)
        {
            var cliente = clientes[clienteIndex - 1];
            var reservas = servicio.ObtenerReservasPorCliente(cliente.Id);
            foreach (var reserva in reservas)
            {
                Console.WriteLine($"ID: {reserva.Id}, Cancha ID: {reserva.IdCancha}, Fecha: {reserva.Fecha.ToShortDateString()}, Hora Inicio: {reserva.HoraInicio}, Hora Fin: {reserva.HoraFin}");
            }
        }
        else
        {
            Console.WriteLine("Cliente no válido.");
        }
        Console.ReadKey();
    }
    static void AgregarPago(ServicioPagos servicio, ServicioReservas servicioReservas)
    {
        Console.WriteLine("Seleccione la reserva:");
        var reservas = servicioReservas.ObtenerReservas();
        for (int i = 0; i < reservas.Count; i++)
        {
            Console.WriteLine($"{i + 1}. Reserva ID: {reservas[i].Id}, Fecha: {reservas[i].Fecha.ToShortDateString()}, Hora Inicio: {reservas[i].HoraInicio}, Hora Fin: {reservas[i].HoraFin}");
        }
        if (int.TryParse(Console.ReadLine(), out var reservaIndex) && reservaIndex > 0 && reservaIndex <= reservas.Count)
        {
            var reserva = reservas[reservaIndex - 1];

            Console.Write("Monto del pago: ");
            if (decimal.TryParse(Console.ReadLine(), out var monto))
            {
                var pago = new Pago
                {
                    IdReserva = reserva.Id,
                    Monto = monto,
                    FechaPago = DateTime.Now
                };
                servicio.AgregarPago(pago);
                Console.WriteLine("Pago agregado exitosamente.");
            }
            else
            {
                Console.WriteLine("Monto no válido.");
            }
        }
        else
        {
            Console.WriteLine("Reserva no válida.");
        }
        Console.ReadKey();
    }
    static void ListarPagos(ServicioPagos servicio)
    {
        var pagos = servicio.ObtenerPagos();
        foreach (var pago in pagos)
        {
            Console.WriteLine($"ID: {pago.Id}, Reserva ID: {pago.IdReserva}, Monto: {pago.Monto}, Fecha de Pago: {pago.FechaPago}");
        }
        Console.ReadKey();
    }
    static void ReporteUsuarios(ServicioUsuarios servicio)
    {
        var usuarios = servicio.ObtenerUsuarios();
        Console.WriteLine("Reporte de Usuarios:");
        foreach (var usuario in usuarios)
        {
            Console.WriteLine($"ID: {usuario.Id}, Nombre: {usuario.Nombre}, Email: {usuario.Email}");
        }
        Console.ReadKey();
    }

    static void ReporteClientes(ServicioClientes servicio)
    {
        var clientes = servicio.ObtenerClientes();
        Console.WriteLine("Reporte de Clientes:");
        foreach (var cliente in clientes)
        {
            Console.WriteLine($"ID: {cliente.Id}, Nombre: {cliente.Nombre}, Email: {cliente.Email}, Teléfono: {cliente.Telefono}");
        }
        Console.ReadKey();
    }

    static void ReporteCanchas(ServicioCanchas servicio)
    {
        var canchas = servicio.ObtenerCanchas();
        Console.WriteLine("Reporte de Canchas:");
        foreach (var cancha in canchas)
        {
            Console.WriteLine($"ID: {cancha.Id}, Nombre: {cancha.Nombre}, Tipo: {cancha.Tipo.Nombre}, Disponible: {cancha.EstaDisponible}");
        }
        Console.ReadKey();
    }

    static void ReporteReservas(ServicioReservas servicio)
    {
        var reservas = servicio.ObtenerReservas();
        Console.WriteLine("Reporte de Reservas:");
        foreach (var reserva in reservas)
        {
            Console.WriteLine($"ID: {reserva.Id}, Cliente ID: {reserva.IdCliente}, Cancha ID: {reserva.IdCancha}, Fecha: {reserva.Fecha.ToShortDateString()}, Hora Inicio: {reserva.HoraInicio}, Hora Fin: {reserva.HoraFin}");
        }
        Console.ReadKey();
    }

    static void ReportePagos(ServicioPagos servicio)
    {
        var pagos = servicio.ObtenerPagos();
        Console.WriteLine("Reporte de Pagos:");
        foreach (var pago in pagos)
        {
            Console.WriteLine($"ID: {pago.Id}, Reserva ID: {pago.IdReserva}, Monto: {pago.Monto}, Fecha de Pago: {pago.FechaPago}");
        }
        Console.ReadKey();
    }
}