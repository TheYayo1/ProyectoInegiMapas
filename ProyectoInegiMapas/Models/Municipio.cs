namespace ProyectoInegiMapas.Models
{
    public class Municipio
    {
        public string CveMunicipio { get; set; }
        public string NomMunicipio { get; set; }
        public string CveEntidad { get; set; } // FK al estado
    }

}
