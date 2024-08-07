public class RepositorioCanchas
{
    private List<Cancha> _canchas = new List<Cancha>();

    public void AgregarCancha(Cancha cancha)
    {
        cancha.Id = GeneradorId.ObtenerNuevoId();
        _canchas.Add(cancha);
    }

    public void EliminarCancha(int id)
    {
        var cancha = _canchas.FirstOrDefault(c => c.Id == id);
        if (cancha != null)
        {
            _canchas.Remove(cancha);
        }
    }

    public List<Cancha> ObtenerCanchas()
    {
        return _canchas;
    }
}