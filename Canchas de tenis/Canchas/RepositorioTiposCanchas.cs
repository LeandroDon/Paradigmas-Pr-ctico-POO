using Newtonsoft.Json;

public class RepositorioTiposCanchas
{
    private const string RutaArchivo = "tiposCanchas.json";
    private List<TipoCancha> _tiposCanchas;

    public RepositorioTiposCanchas()
    {
        _tiposCanchas = CargarTiposCanchas();
    }

    public void AgregarTipoCancha(TipoCancha tipoCancha)
    {
        tipoCancha.Id = GeneradorId.ObtenerNuevoId();
        _tiposCanchas.Add(tipoCancha);
        GuardarTiposCanchas();
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
            GuardarTiposCanchas();
        }
    }

    private void GuardarTiposCanchas()
    {
        var jsonData = JsonConvert.SerializeObject(_tiposCanchas, Formatting.Indented);
        File.WriteAllText(RutaArchivo, jsonData);
    }

    private List<TipoCancha> CargarTiposCanchas()
    {
        if (!File.Exists(RutaArchivo))
            return new List<TipoCancha>();

        var jsonData = File.ReadAllText(RutaArchivo);
        return JsonConvert.DeserializeObject<List<TipoCancha>>(jsonData) ?? new List<TipoCancha>();
    }
}