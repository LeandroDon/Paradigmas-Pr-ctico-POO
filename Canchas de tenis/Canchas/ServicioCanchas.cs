public class ServicioCanchas
{
    private RepositorioCanchas repositorioCanchas;
    private RepositorioTiposCanchas repositorioTiposCanchas;

    public ServicioCanchas(RepositorioCanchas repositorioCanchas, RepositorioTiposCanchas repositorioTiposCanchas)
    {
        this.repositorioCanchas = repositorioCanchas;
        this.repositorioTiposCanchas = repositorioTiposCanchas;
    }

    public void AgregarCancha(Cancha cancha)
    {
        repositorioCanchas.AgregarCancha(cancha);
    }

    public void EliminarCancha(int id)
    {
        repositorioCanchas.EliminarCancha(id);
    }

    public List<Cancha> ObtenerCanchas()
    {
        return repositorioCanchas.ObtenerCanchas();
    }

    public List<TipoCancha> ObtenerTiposCanchas()
    {
        return repositorioTiposCanchas.ObtenerTiposCanchas();
    }
}