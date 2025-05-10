using System.Text.Json;
using System.Text.Json.Serialization;

using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.IO;

namespace ConsumodeAPIs
{
    public partial class Form1 : Form
    {
        private readonly HttpClient _httpClient = new HttpClient();
        public Form1()
        {
            InitializeComponent();
        }

        private async void btnBuscar_Click(object sender, EventArgs e)
        {
            string nombre = txtBuscar.Text.Trim().ToLower();

            if (string.IsNullOrWhiteSpace(nombre))
            {
                MessageBox.Show("Ingresa un nombre de Pokémon.");
                return;
            }

            try
            {
                string url = $"https://pokeapi.co/api/v2/pokemon/{nombre}";
                string respuesta = await _httpClient.GetStringAsync(url);

                var pokemon = JsonSerializer.Deserialize<PokemonResponse>(respuesta);

                lblNombre.Text = $"Nombre: {pokemon.Name.ToUpper()}";
                Estd.Text = "Estadísticas:\n";

                foreach (var stat in pokemon.Stats)
                {
                    Estd.Text += $"{stat.Stat.Name}: {stat.BaseStat}\n";
                }

                picPokemon.Load(pokemon.Sprites.FrontDefault);
            }
            catch (HttpRequestException)
            {
                MessageBox.Show("No se pudo conectar a la API.");
            }
            catch (JsonException)
            {
                MessageBox.Show("No se pudo interpretar la respuesta de la API.");
            }
            catch (Exception)
            {
                MessageBox.Show("El Pokémon no fue encontrado o ocurrió un error.");
            }
        }

        private async void BuscarGato_Click(object sender, EventArgs e)
        {
            string texto = txtBuscar.Text.Trim().ToLower();

            if (string.IsNullOrWhiteSpace(texto))
            {
                MessageBox.Show("Ingresa un ID.");
                return;
            }

            try
            {
                // Verificar si el texto es un ID
                bool esId = texto.Length > 2; // Puedes adaptar esta lógica según tus necesidades

                if (esId)
                {
                    // Buscar por ID
                    string urlImagen = $"https://api.thecatapi.com/v1/images/{texto}?api_key=FK2ILSlm0QFqO0peLfX24G5qDF8LI2MWgmTHCYzpdK8v4M9G0M7nPmWrh9fm5AZp";
                    string respuestaImagen = await _httpClient.GetStringAsync(urlImagen);
                    var gato = JsonSerializer.Deserialize<CatImage>(respuestaImagen);

                    if (gato != null)
                    {
                        picPokemon.Load(gato.Url);
                        lblNombre.Text = "Gato encontrado";
                        Estd.Text = "Estadistica no disponible para este resultado.";
                    }
                    else
                    {
                        MessageBox.Show("No se encontró un gato con ese ID.");
                    }
                }
                else
                {
                    // Buscar por raza
                    string urlBusqueda = $"https://api.thecatapi.com/v1/breeds/search?q={texto}";
                    string respuestaBusqueda = await _httpClient.GetStringAsync(urlBusqueda);
                    var razas = JsonSerializer.Deserialize<List<RazaGato>>(respuestaBusqueda);

                    if (razas == null || razas.Count == 0)
                    {
                        MessageBox.Show("No se encontró una raza con ese nombre.");
                        return;
                    }

                    string idRaza = razas[0].Id;

                    // Buscar una imagen de esa raza
                    string urlImagen = $"https://api.thecatapi.com/v1/images/search?breed_ids={idRaza}&api_key=FK2ILSlm0QFqO0peLfX24G5qDF8LI2MWgmTHCYzpdK8v4M9G0M7nPmWrh9fm5AZp";
                    string respuestaImagen = await _httpClient.GetStringAsync(urlImagen);
                    var gatos = JsonSerializer.Deserialize<List<CatImage>>(respuestaImagen);

                    if (gatos != null && gatos.Count > 0)
                    {
                        picPokemon.Load(gatos[0].Url);
                        lblNombre.Text = $"Raza: {razas[0].Name}";
                        Estd.Text = $"Origen: {razas[0].Origin}\nDescripción: {razas[0].Description}";
                    }
                    else
                    {
                        MessageBox.Show("No se encontró una imagen para esa raza.");
                    }
                }
            }
            catch (HttpRequestException)
            {
                MessageBox.Show("No se pudo conectar a la API.");
            }
            catch (JsonException)
            {
                MessageBox.Show("No se pudo interpretar la respuesta de la API.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error: {ex.Message}");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nombre = lblNombre.Text.Trim();

            // obtiene los datos del datagridview
            string estadisticas = Estd.Text.Trim();

            // 2. Guardar en archivo .txt
            try
            {
                using (StreamWriter archivo = new StreamWriter("InformacionApi.txt", append: true))
                {
                    archivo.WriteLine("Nombre: " + nombre);
                    archivo.WriteLine("Estadísticas" + estadisticas);

                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar el archivo: " + ex.Message);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblNombre_Click(object sender, EventArgs e)
        {

        }

        private void Estd_Click(object sender, EventArgs e)
        {

        }

        private void Limpiar_Click(object sender, EventArgs e)
        {
            txtBuscar.Clear();
            lblNombre.Text = "Nombre: ";
            Estd.Text = "Estadísticas:\n";
            picPokemon.Image = null;
        }
    }
}
    

    public class RazaGato
    {
        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("origin")]
        public string Origin { get; set; }

        [JsonPropertyName("description")]
        public string Description { get; set; }
    }

    public class CatImage
    {
        [JsonPropertyName("url")]
        public string Url { get; set; }
    }

    public class PokemonResponse
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("sprites")]
        public Sprites Sprites { get; set; }

        [JsonPropertyName("stats")]
        public StatEntry[] Stats { get; set; }
    }

    public class Sprites
    {
        [JsonPropertyName("front_default")]
        public string FrontDefault { get; set; }
    }

    public class StatEntry
    {
        [JsonPropertyName("base_stat")]
        public int BaseStat { get; set; }

        [JsonPropertyName("stat")]
        public StatName Stat { get; set; }
    }

    public class StatName
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }
    }