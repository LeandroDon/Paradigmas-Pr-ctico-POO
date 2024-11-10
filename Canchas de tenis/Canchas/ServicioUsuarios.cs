public class ServicioUsuarios
{
    private RepositorioUsuarios _repositorioUsuarios;

    public ServicioUsuarios(RepositorioUsuarios repositorioUsuarios)
    {
        this._repositorioUsuarios = repositorioUsuarios;
    }

    public void AgregarUsuario(Usuario usuario)
    {
        _repositorioUsuarios.AgregarUsuario(usuario);
    }

    public void EliminarUsuario(int id)
    {
        _repositorioUsuarios.EliminarUsuario(id);
    }

    public List<Usuario> ObtenerUsuarios()
    {
        return _repositorioUsuarios.ObtenerUsuarios();
    }
    public Usuario? ObtenerUsuarioPorId(int id)
    {
        return _repositorioUsuarios.ObtenerUsuarios().FirstOrDefault(c => c.Id == id);
    }
}

public class ServicioClientes
{
    private RepositorioClientes _repositorioClientes;

    public ServicioClientes(RepositorioClientes repositorioClientes)
    {
        this._repositorioClientes = repositorioClientes;
    }

    public void AgregarCliente(Cliente cliente)
    {
        _repositorioClientes.AgregarCliente(cliente);
    }

    public void EliminarCliente(int id)
    {
        _repositorioClientes.EliminarCliente(id);
    }

    public List<Cliente> ObtenerClientes()
    {
        return _repositorioClientes.ObtenerClientes();
    }

    public Cliente? ObtenerClientePorId(int id)
    {
        return _repositorioClientes.ObtenerClientes().FirstOrDefault(c => c.Id == id);
    }
}