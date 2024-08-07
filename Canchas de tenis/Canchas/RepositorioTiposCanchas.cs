public class RepositorioTiposCanchas
{
    private List<TipoCancha> _tiposCanchas = new List<TipoCancha>();

    public void AgregarTipoCancha(TipoCancha tipoCancha)
    {
        tipoCancha.Id = GeneradorId.ObtenerNuevoId();
        _tiposCanchas.Add(tipoCancha);
    }

    public List<TipoCancha> ObtenerTiposCanchas()
    {
        return _tiposCanchas;
    }

    public void EliminarTipoCancha(int id)
    {
        var tipoCancha = _tiposCanchas.FirstOrDefault(tc => tc.Id == id);
        if (tipoCancha != null)
        {
            _tiposCanchas.Remove(tipoCancha);
        }
    }
}