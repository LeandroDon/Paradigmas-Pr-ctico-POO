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
            Console.ReadKey();
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
                    GestionarPagos(servicioPagos, servicioReservas, servicioCanchas, servicioClientes);
                    break;
                case "7":
                    GestionarReportes(servicioUsuarios, servicioClientes, servicioCanchas, servicioReservas, servicioPagos);
                    break;
                case "0":
                    return;
                default:
                    Console.WriteLine("Opción no válida. Inténtelo de nuevo.");
                    Console.ReadKey();
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
            Console.ReadKey();
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
                    Console.ReadKey();
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
            Console.ReadKey();
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
                    Console.ReadKey();
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
            Console.ReadKey();
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
                    Console.ReadKey();
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
            Console.ReadKey();
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
                Console.ReadKey();
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
            Console.ReadKey();
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
                    Console.ReadKey();
                    break;
            }
        }
    }
    static void GestionarPagos(ServicioPagos servicioPagos, ServicioReservas servicioReservas, ServicioCanchas servicioCanchas, ServicioClientes servicioClientes)
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
            Console.ReadKey();
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
                AgregarPago(servicioPagos, servicioReservas, servicioCanchas, servicioClientes); // Asegúrate de que este método exista
                break;
            case "2":
                ListarPagos(servicioPagos); // Asegúrate de que este método exista
                break;
            case "0":
                return; // Regresar al menú principal
            default:
                Console.WriteLine("Opción no válida. Inténtelo de nuevo.");
                Console.ReadKey();
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
            Console.ReadKey();
        }
        Console.WriteLine("Reportes");
        Console.WriteLine("1. Cantidad de Clientes por Cancha");
        Console.WriteLine("2. Cantidad de Clientes por Tipo de Cancha");
        Console.WriteLine("3. Ingresos Mensuales por Cancha");
        Console.WriteLine("4. Cantidad de Clientes Totales Mensuales");
        Console.WriteLine("5. Cantidad Promedio de Clientes por Rango Horario");
        Console.WriteLine("0. Volver al Menú Principal");
        Console.Write("Seleccione una opción: ");
        
        var opcion = Console.ReadLine();
        
        switch (opcion)
        {
            case "1":
                ReporteClientesPorCancha(servicioReservas, servicioCanchas);
                break;
            case "2":
                ReporteClientesPorTipoCancha(servicioReservas, servicioCanchas);
                break;
            case "3":
                ReporteIngresosMensualesPorCancha(servicioReservas, servicioCanchas, servicioPagos);
                break;
            case "4":
                ReporteClientesTotalesMensuales(servicioReservas);
                break;
            case "5":
                ReportePromedioClientesPorRangoHorario(servicioReservas);
                break;
            case "0":
                return;
            default:
                Console.WriteLine("Opción no válida. Inténtelo de nuevo.");
                Console.ReadKey();
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
        Console.ReadKey();
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
        var usuario = servicio.ObtenerUsuarioPorId(id);
        if (usuario != null)
        {
            servicio.EliminarUsuario(id);
            Console.WriteLine("Usuario eliminado exitosamente.");
        }
        else
        {
            Console.WriteLine("Usuario no encontrado.");
        }
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
        Console.ReadKey();
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
        var cliente = servicio.ObtenerClientePorId(id);
        if (cliente != null)
        {
            servicio.EliminarCliente(id);
            Console.WriteLine("Cliente eliminado exitosamente.");
        }
        else
        {
            Console.WriteLine("Cliente no encontrado.");
        }
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
            if (nombre == null)
            {
                throw new ArgumentNullException(nameof(nombre), "El nombre no puede ser null");
            }
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
        var cancha = servicio.ObtenerCanchaPorId(id);
        if (cancha != null)
        {
            servicio.EliminarCancha(id);
            Console.WriteLine("Cancha eliminada exitosamente.");
        }
        else
        {
            Console.WriteLine("Cancha no encontrada.");
        }
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
            if (string.IsNullOrEmpty(nombre))
            {
                throw new ArgumentNullException(nameof(nombre), "El nombre no puede ser null o vacío.");
            }
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
        var tipoCancha = servicio.ObtenerTiposCanchasPorId(id);
        if (tipoCancha != null)
        {
            servicio.EliminarTipoCancha(id);
            Console.WriteLine("Tipo de cancha eliminado exitosamente.");
        }
        else
        {
            Console.WriteLine("Tipo de cancha no encontrado.");
        }
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

                Console.Write("Fecha de la reserva (dd/MM/yyyy): ");
                if (DateTime.TryParseExact(Console.ReadLine(), "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out var fecha))
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
                                HoraFin = horaFin,
                                MontoTotal = cancha.Tipo.PrecioHora * (decimal)(horaFin - horaInicio).TotalHours
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
        var reserva = servicio.ObtenerReservaPorId(id);
        if (reserva != null)
        {
            servicio.EliminarReserva(id);
            Console.WriteLine("Reserva eliminada exitosamente.");
        }
        else
        {
            Console.WriteLine("Reserva no encontrada.");
        }
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
            Console.WriteLine($"ID: {reserva.Id}, Cliente ID: {reserva.IdCliente}, Cancha ID: {reserva.IdCancha}, Fecha: {reserva.Fecha.ToShortDateString()}, Hora Inicio: {reserva.HoraInicio}, Hora Fin: {reserva.HoraFin}, Monto total: {reserva.MontoTotal:C}");
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
                Console.WriteLine($"ID: {reserva.Id}, Cancha ID: {reserva.IdCancha}, Fecha: {reserva.Fecha.ToShortDateString()}, Hora Inicio: {reserva.HoraInicio}, Hora Fin: {reserva.HoraFin}, Monto total: {reserva.MontoTotal:C}");
            }
        }
        else
        {
            Console.WriteLine("Cliente no válido.");
        }
        Console.ReadKey();
    }
   
static void AgregarPago(ServicioPagos servicioPagos, ServicioReservas servicioReservas, ServicioCanchas servicioCanchas, ServicioClientes servicioClientes)
{
        var reservas = servicioReservas.ObtenerReservas().ToList();
        Console.WriteLine($"Total de reservas encontradas: {reservas.Count}");

        var reservasNoPagadas = reservas.Where(reserva => !servicioPagos.ExistePagoPorReserva(reserva.Id)).ToList();

        if (reservasNoPagadas.Any())
        {
            Console.WriteLine("Reservas pendientes de pago:");
            for (int i = 0; i < reservasNoPagadas.Count; i++)
            {
                var reserva = reservasNoPagadas[i];
                var cliente = servicioClientes.ObtenerClientePorId(reserva.IdCliente);
                Console.WriteLine($"{i + 1}. ID: {reserva.Id}, Cliente ID: {reserva.IdCliente}, Fecha: {reserva.Fecha.ToShortDateString()}, " +
                                  $"Hora Inicio: {reserva.HoraInicio}, Hora Fin: {reserva.HoraFin}, Monto total: {reserva.MontoTotal:C}");
            }

            Console.Write("Seleccione una reserva para pagar: ");
            if (int.TryParse(Console.ReadLine(), out var reservaIndex) && reservaIndex > 0 && reservaIndex <= reservasNoPagadas.Count)
            {
                var reserva = reservasNoPagadas[reservaIndex - 1];
                var clienteSeleccionado = servicioClientes.ObtenerClientePorId(reserva.IdCliente);
                var cancha = servicioCanchas.ObtenerCanchaPorId(reserva.IdCancha);
                decimal precioPorHora = 0;
                if (cancha != null)
                {
                    precioPorHora = cancha.Tipo.PrecioHora;
                }
                else
                {
                Console.WriteLine($"No se encontró la cancha con ID: {reserva.IdCancha}");
                }
                var duracionHoras = (decimal)(reserva.HoraFin - reserva.HoraInicio).TotalHours;
                var montoTotal = precioPorHora * duracionHoras;
                var pago = new Pago(reserva.IdCliente, reserva.Id, montoTotal, DateTime.Now);
                servicioPagos.AgregarPago(pago);
                
                Console.WriteLine($"El pago de {montoTotal:C} para el cliente con ID {reserva.IdCliente} se ha registrado exitosamente.");
            }
            else
            {
                Console.WriteLine("Opción no válida.");
            }
        }
        else
        {
            Console.WriteLine("No hay reservas pendientes de pago.");
        }
        Console.ReadKey();
    }
    static void ListarPagos(ServicioPagos servicioPagos)
{
    var pagos = servicioPagos.ObtenerPagos();
    if (pagos.Any())
    {
        Console.WriteLine("Listado de Pagos:");
        foreach (var pago in pagos)
        {
            Console.WriteLine($"ID Pago: {pago.Id}, Reserva ID: {pago.IdReserva}, Cliente ID: {pago.IdCliente}, Monto: {pago.Monto:C}, Fecha Pago: {pago.FechaPago}");
        }
    }
    else
    {
        Console.WriteLine("No hay pagos registrados.");
    }
    Console.ReadKey();
}
    static void ReporteClientesPorCancha(ServicioReservas servicioReservas, ServicioCanchas servicioCanchas)
{
    var reservas = servicioReservas.ObtenerReservas();

    var clientesPorCancha = reservas.GroupBy(r => r.IdCancha)
                                     .Select(g => new
                                     {
                                         Cancha = servicioCanchas.ObtenerCancha(g.Key)?.Nombre ?? "Cancha desconocida",
                                         CantidadClientes = g.Select(r => r.IdCliente).Distinct().Count()
                                     })
                                     .ToList();

    foreach (var item in clientesPorCancha)
    {
        Console.WriteLine($"Cancha: {item.Cancha}, Clientes: {item.CantidadClientes}");
    }
    Console.ReadKey();
}

static void ReporteClientesPorTipoCancha(ServicioReservas servicioReservas, ServicioCanchas servicioCanchas)
{
    var reservas = servicioReservas.ObtenerReservas();

    var clientesPorTipo = reservas
        .Select(r => new
        {
            Reserva = r,
            Cancha = servicioCanchas.ObtenerCancha(r.IdCancha)
        })
        .Where(rc => rc.Cancha != null)
        .GroupBy(rc => rc.Cancha!.Tipo.Nombre)
        .Select(g => new
        {
            TipoCancha = g.Key,
            CantidadClientes = g.Select(rc => rc.Reserva.IdCliente).Distinct().Count()
        })
        .ToList();

    foreach (var item in clientesPorTipo)
    {
        Console.WriteLine($"Tipo de Cancha: {item.TipoCancha}, Clientes: {item.CantidadClientes}");
    }
    Console.ReadKey();
}

static void ReporteIngresosMensualesPorCancha(ServicioReservas servicioReservas, ServicioCanchas servicioCanchas, ServicioPagos servicioPagos)
{
    Console.Write("Ingrese el año (YYYY): ");
    if (!int.TryParse(Console.ReadLine(), out int year) || year < 1)
    {
        Console.WriteLine("Año no válido.");
        return;
    }

    Console.Write("Ingrese el mes (MM): ");
    if (!int.TryParse(Console.ReadLine(), out int month) || month < 1 || month > 12)
    {
        Console.WriteLine("Mes no válido.");
        return;
    }

    var ingresosPorCancha = new Dictionary<int, decimal>();
    var pagos = servicioPagos.ObtenerPagos();

    var pagosDelMes = pagos.Where(p => p.FechaPago.Month == month && p.FechaPago.Year == year).ToList();

    Console.WriteLine($"Pagos del mes {month}/{year}: {pagosDelMes.Count}");
        
    if (!pagosDelMes.Any())
    {
        Console.WriteLine($"No hay ingresos en el mes {month}/{year}.");
        Console.ReadKey();
        return;
    }

    foreach (var pago in pagosDelMes)
    {
        var reserva = servicioReservas.ObtenerReservaPorId(pago.IdReserva);

        if (reserva != null)
        {
            if (!ingresosPorCancha.ContainsKey(reserva.IdCancha))
            {
                ingresosPorCancha[reserva.IdCancha] = 0;
            }
            ingresosPorCancha[reserva.IdCancha] += pago.Monto;
        }
        else
        {
            Console.WriteLine($"No se encontró la reserva con ID: {pago.IdReserva}");
        }
    }
   
    foreach (var ingreso in ingresosPorCancha)
    {
        var cancha = servicioCanchas.ObtenerCanchaPorId(ingreso.Key);
        if (cancha != null)
        {
            Console.WriteLine($"Cancha: {cancha.Nombre}, Ingresos: {ingreso.Value:C}");
        }
        else
        {
            Console.WriteLine($"No se encontró la cancha con ID: {ingreso.Key}");
        }
    }
    Console.ReadKey();
}

static void ReporteClientesTotalesMensuales(ServicioReservas servicioReservas)
{
    Console.Write("Ingrese el año (YYYY): ");
    if (!int.TryParse(Console.ReadLine(), out int year) || year < 1)
    {
        Console.WriteLine("Año no válido.");
        return;
    }

    Console.Write("Ingrese el mes (1-12): ");
    if (!int.TryParse(Console.ReadLine(), out int month) || month < 1 || month > 12)
    {
        Console.WriteLine("Mes no válido.");
        return;
    }

    var totalClientes = servicioReservas.ObtenerReservas()
                          .Where(r => r.Fecha.Year == year && r.Fecha.Month == month)
                          .Select(r => r.IdCliente)
                          .Distinct()
                          .Count();

    Console.WriteLine($"Total de clientes en el mes {month}/{year}: {totalClientes}");
    Console.ReadKey();
}

static void ReportePromedioClientesPorRangoHorario(ServicioReservas servicioReservas)
{
    Console.Write("Ingrese la hora de inicio (HH:mm): ");
    var inputHoraInicio = Console.ReadLine();

    if (string.IsNullOrWhiteSpace(inputHoraInicio) || !TimeSpan.TryParse(inputHoraInicio, out TimeSpan horaInicio))
    {
        Console.WriteLine("Hora de inicio no válida.");
        return;
    }

    Console.Write("Ingrese la hora de fin (HH:mm): ");
    var inputHoraFin = Console.ReadLine();

    if (string.IsNullOrWhiteSpace(inputHoraFin) || !TimeSpan.TryParse(inputHoraFin, out TimeSpan horaFin))
    {
        Console.WriteLine("Hora de fin no válida.");
        return;
    }

    var reservasEnRango = servicioReservas.ObtenerReservas()
                            .Where(r => (r.HoraInicio >= horaInicio && r.HoraInicio < horaFin) || 
                                         (r.HoraFin > horaInicio && r.HoraFin <= horaFin));

    var totalClientes = reservasEnRango.Select(r => r.IdCliente).Distinct().Count();
    
    double promedioClientes = totalClientes / (horaFin - horaInicio).TotalHours;

    Console.WriteLine($"Promedio de clientes entre {horaInicio} y {horaFin}: {promedioClientes:F2}");
    Console.ReadKey();
}
}