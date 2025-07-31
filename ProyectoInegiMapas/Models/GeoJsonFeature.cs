namespace ProyectoInegiMapas.Models
{
    public class GeoJsonFeature
    {
        public string Type { get; set; }
        public Geometry Geometry { get; set; }
        public Dictionary<string, object> Properties { get; set; }
    }

}
