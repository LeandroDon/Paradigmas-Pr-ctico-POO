public class ServicioTiposCanchas
{
    private RepositorioTiposCanchas _repositorio;

    public ServicioTiposCanchas(RepositorioTiposCanchas repositorio)
    {
        this._repositorio = repositorio;
    }

    public void AgregarTipoCancha(TipoCancha tipoCancha)
    {
        _repositorio.AgregarTipoCancha(tipoCancha);
    }

    public List<TipoCancha> ObtenerTiposCanchas()
    {
        return _repositorio.ObtenerTiposCanchas();
    }

    public void EliminarTipoCancha(int id)
    {
    _repositorio.EliminarTipoCancha(id);
    }

     public TipoCancha? ObtenerTiposCanchasPorId(int id)
    {
        return _repositorio.ObtenerTiposCanchas().FirstOrDefault(c => c.Id == id);
    }
}