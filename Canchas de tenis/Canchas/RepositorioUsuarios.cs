public class RepositorioUsuarios
{
    private List<Usuario> _usuarios = new List<Usuario>();

    public void AgregarUsuario(Usuario usuario)
    {
        usuario.Id = GeneradorId.ObtenerNuevoId();
        _usuarios.Add(usuario);
    }

    public void EliminarUsuario(int id)
    {
        var usuario = _usuarios.FirstOrDefault(u => u.Id == id);
        if (usuario != null)
        {
            _usuarios.Remove(usuario);
        }
    }

    public List<Usuario> ObtenerUsuarios()
    {
        return _usuarios;
    }
}

public class RepositorioClientes
{
    private List<Cliente> _clientes = new List<Cliente>();

    public void AgregarCliente(Cliente cliente)
    {
        cliente.Id = GeneradorId.ObtenerNuevoId();
        _clientes.Add(cliente);
    }

    public void EliminarCliente(int id)
    {
        var cliente = _clientes.FirstOrDefault(c => c.Id == id);
        if (cliente != null)
        {
            _clientes.Remove(cliente);
        }
    }

    public List<Cliente> ObtenerClientes()
    {
        return _clientes;
    }
}