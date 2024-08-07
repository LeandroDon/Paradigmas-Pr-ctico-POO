public class ServicioUsuarios
{
    private RepositorioUsuarios repositorioUsuarios;

    public ServicioUsuarios(RepositorioUsuarios repositorioUsuarios)
    {
        this.repositorioUsuarios = repositorioUsuarios;
    }

    public void AgregarUsuario(Usuario usuario)
    {
        repositorioUsuarios.AgregarUsuario(usuario);
    }

    public void EliminarUsuario(int id)
    {
        repositorioUsuarios.EliminarUsuario(id);
    }

    public List<Usuario> ObtenerUsuarios()
    {
        return repositorioUsuarios.ObtenerUsuarios();
    }
}

public class ServicioClientes
{
    private RepositorioClientes repositorioClientes;

    public ServicioClientes(RepositorioClientes repositorioClientes)
    {
        this.repositorioClientes = repositorioClientes;
    }

    public void AgregarCliente(Cliente cliente)
    {
        repositorioClientes.AgregarCliente(cliente);
    }

    public void EliminarCliente(int id)
    {
        repositorioClientes.EliminarCliente(id);
    }

    public List<Cliente> ObtenerClientes()
    {
        return repositorioClientes.ObtenerClientes();
    }
}