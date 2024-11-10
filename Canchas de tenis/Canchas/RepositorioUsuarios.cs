using Newtonsoft.Json;

public class RepositorioUsuarios
{
    private const string RutaArchivo = "usuarios.json";
    private List<Usuario> _usuarios;

    public RepositorioUsuarios()
    {
        _usuarios = CargarUsuarios();
    }

    public void AgregarUsuario(Usuario usuario)
    {
        usuario.Id = GeneradorId.ObtenerNuevoId();
        _usuarios.Add(usuario);
        GuardarUsuarios();
    }

    public void EliminarUsuario(int id)
    {
        var usuario = _usuarios.FirstOrDefault(u => u.Id == id);
        if (usuario != null)
        {
            _usuarios.Remove(usuario);
            GuardarUsuarios();
        }
    }

    public List<Usuario> ObtenerUsuarios()
    {
        return _usuarios;
    }

    private void GuardarUsuarios()
    {
        var jsonData = JsonConvert.SerializeObject(_usuarios, Formatting.Indented);
        File.WriteAllText(RutaArchivo, jsonData);
    }

    private List<Usuario> CargarUsuarios()
    {
        if (!File.Exists(RutaArchivo))
            return new List<Usuario>();

        var jsonData = File.ReadAllText(RutaArchivo);
        return JsonConvert.DeserializeObject<List<Usuario>>(jsonData) ?? new List<Usuario>();
    }
}

public class RepositorioClientes
{
    private const string RutaArchivo = "clientes.json";
    private List<Cliente> _clientes;

    public RepositorioClientes()
    {
        _clientes = CargarClientes();
    }

    public void AgregarCliente(Cliente cliente)
    {
        cliente.Id = GeneradorId.ObtenerNuevoId();
        _clientes.Add(cliente);
        GuardarClientes();
    }

    public void EliminarCliente(int id)
    {
        var cliente = _clientes.FirstOrDefault(c => c.Id == id);
        if (cliente != null)
        {
            _clientes.Remove(cliente);
            GuardarClientes();
        }
    }

    public List<Cliente> ObtenerClientes()
    {
        return _clientes;
    }

    private void GuardarClientes()
    {
        var jsonData = JsonConvert.SerializeObject(_clientes, Formatting.Indented);
        File.WriteAllText(RutaArchivo, jsonData);
    }

    private List<Cliente> CargarClientes()
    {
        if (!File.Exists(RutaArchivo))
            return new List<Cliente>();

        var jsonData = File.ReadAllText(RutaArchivo);
        return JsonConvert.DeserializeObject<List<Cliente>>(jsonData) ?? new List<Cliente>();
    }
}