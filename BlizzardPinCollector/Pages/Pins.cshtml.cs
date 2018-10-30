using System.Collections.Generic;
using System.Threading.Tasks;
using BlizzardPinCollector.API.Models;
using BlizzardPinCollector.UI.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BlizzardPinCollector.UI.Pages
{
    public class PinsModel : PageModel
    {
        private readonly IApiClient client;

        public PinsModel(IApiClient client)
        {
            this.client = client;
        }

        public List<Pin> Pins { get; set; }

        public async Task<IActionResult> OnGetAsync()
        {
            Pins = await client.GetPinsAsync();

            return Page();
        }
    }
}