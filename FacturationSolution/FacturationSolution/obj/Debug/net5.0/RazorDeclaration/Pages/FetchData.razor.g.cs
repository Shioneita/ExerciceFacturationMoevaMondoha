// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace FacturationSolution.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\mondo\OneDrive\Documents\GitHub\ExerciceFacturationMoevaMondoha\FacturationSolution\FacturationSolution\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\mondo\OneDrive\Documents\GitHub\ExerciceFacturationMoevaMondoha\FacturationSolution\FacturationSolution\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\mondo\OneDrive\Documents\GitHub\ExerciceFacturationMoevaMondoha\FacturationSolution\FacturationSolution\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\mondo\OneDrive\Documents\GitHub\ExerciceFacturationMoevaMondoha\FacturationSolution\FacturationSolution\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\mondo\OneDrive\Documents\GitHub\ExerciceFacturationMoevaMondoha\FacturationSolution\FacturationSolution\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\mondo\OneDrive\Documents\GitHub\ExerciceFacturationMoevaMondoha\FacturationSolution\FacturationSolution\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\mondo\OneDrive\Documents\GitHub\ExerciceFacturationMoevaMondoha\FacturationSolution\FacturationSolution\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\mondo\OneDrive\Documents\GitHub\ExerciceFacturationMoevaMondoha\FacturationSolution\FacturationSolution\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\mondo\OneDrive\Documents\GitHub\ExerciceFacturationMoevaMondoha\FacturationSolution\FacturationSolution\_Imports.razor"
using FacturationSolution;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\mondo\OneDrive\Documents\GitHub\ExerciceFacturationMoevaMondoha\FacturationSolution\FacturationSolution\_Imports.razor"
using FacturationSolution.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/fetchdata")]
    public partial class FetchData : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 43 "C:\Users\mondo\OneDrive\Documents\GitHub\ExerciceFacturationMoevaMondoha\FacturationSolution\FacturationSolution\Pages\FetchData.razor"
       
    private FactureClient[] forecasts;

    protected override async Task OnInitializedAsync()
    {
        forecasts = await Http.GetFromJsonAsync<FactureClient[]>("sample-data/weather.json");
    }

    public class FactureClient
    {
        public string client { get; set; }
        public DateTime emission { get; set; }
        
        public DateTime reglementation { get; set; }
        
        public int numero { get; set; }
        public int montants_dû { get; set; }
        public int montants_regler { get; set; }

        public FactureClient(String client, DateTime emssion, DateTime reglementation, int numero, int montants_dû, int montantsRegler)
        {
            this.client = client;
            this.emission = emission;
            this.reglementation = reglementation;
            this.numero = numero;
            this.montants_dû = montants_dû;
            this.montants_regler = montantsRegler;
        }
        
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
