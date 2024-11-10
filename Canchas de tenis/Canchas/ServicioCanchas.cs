public class ServicioCanchas
{
    private readonly RepositorioCanchas repositorioCanchas;
    private readonly RepositorioTiposCanchas repositorioTiposCanchas;

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

    public Cancha? ObtenerCancha(int id)
    {
        return repositorioCanchas.ObtenerCanchas().FirstOrDefault(c => c.Id == id);
    }

    public Cancha? ObtenerCanchaPorId(int canchaId)
    {
        return repositorioCanchas.ObtenerCanchas().FirstOrDefault(c => c.Id == canchaId);
    }
}