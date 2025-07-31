namespace ProyectoInegiMapas.Services
{
    using ProyectoInegiMapas.Models;
    using System.Net.Http;
    using System.Text.Json;
    using System.Threading.Tasks;

    public class InegiApiService
    {
        private readonly HttpClient _httpClient;

        public InegiApiService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<List<Estado>> ObtenerEstadosAsync()
        {
            var response = await _httpClient.GetAsync("https://gaia.inegi.org.mx/wscatgeo/v2/mgee/");
            response.EnsureSuccessStatusCode();

            var json = await response.Content.ReadAsStringAsync();
            var resultado = JsonSerializer.Deserialize<RespuestaEstado>(json);

            return resultado?.Datos ?? new List<Estado>();
        }

        // Puedes seguir con Municipios, Localidades, etc. según el modelo
    }

}
