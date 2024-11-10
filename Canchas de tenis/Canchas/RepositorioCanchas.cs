using Newtonsoft.Json;

public class RepositorioCanchas
{
    private const string RutaArchivo = "canchas.json";
    private List<Cancha> _canchas;

    public RepositorioCanchas()
    {
        _canchas = CargarCanchas();
    }

    public void AgregarCancha(Cancha cancha)
    {
        cancha.Id = GeneradorId.ObtenerNuevoId();
        _canchas.Add(cancha);
        GuardarCanchas();
    }

    public void EliminarCancha(int id)
    {
        var cancha = _canchas.FirstOrDefault(c => c.Id == id);
        if (cancha != null)
        {
            _canchas.Remove(cancha);
            GuardarCanchas();
        }
    }

    public List<Cancha> ObtenerCanchas()
    {
        return _canchas;
    }

    private void GuardarCanchas()
    {
        var jsonData = JsonConvert.SerializeObject(_canchas, Formatting.Indented);
        File.WriteAllText(RutaArchivo, jsonData);
    }

    private List<Cancha> CargarCanchas()
    {
        if (!File.Exists(RutaArchivo))
            return new List<Cancha>();

        var jsonData = File.ReadAllText(RutaArchivo);
        return JsonConvert.DeserializeObject<List<Cancha>>(jsonData) ?? new List<Cancha>();
    }
}