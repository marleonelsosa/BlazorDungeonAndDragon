using BlazorDungeonAndDragon.Shared;
using Microsoft.AspNetCore.Components;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace BlazorDungeonAndDragon.Client.Pages
{
    public partial class FetchData
    {
        [Inject] HttpClient Http { get; set; }

        private WeatherForecast[] forecasts;

        protected override async Task OnInitializedAsync()
        {
            forecasts = await Http.GetFromJsonAsync<WeatherForecast[]>("WeatherForecast");
        }

    }
}
