public class ServicioTiposCanchas
{
    private RepositorioTiposCanchas repositorio;

    public ServicioTiposCanchas(RepositorioTiposCanchas repositorio)
    {
        this.repositorio = repositorio;
    }

    public void AgregarTipoCancha(TipoCancha tipoCancha)
    {
        repositorio.AgregarTipoCancha(tipoCancha);
    }

    public List<TipoCancha> ObtenerTiposCanchas()
    {
        return repositorio.ObtenerTiposCanchas();
    }

    public void EliminarTipoCancha(int id)
    {
        repositorio.EliminarTipoCancha(id);
    }
}