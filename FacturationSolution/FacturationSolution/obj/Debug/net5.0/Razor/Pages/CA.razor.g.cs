#pragma checksum "C:\Users\mondo\OneDrive\Documents\GitHub\ExerciceFacturationMoevaMondoha\FacturationSolution\FacturationSolution\Pages\CA.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "03c67c29df72d888e64f1b742b977bd53a5fb75c"
// <auto-generated/>
#pragma warning disable 1591
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
#line 2 "C:\Users\mondo\OneDrive\Documents\GitHub\ExerciceFacturationMoevaMondoha\FacturationSolution\FacturationSolution\Pages\CA.razor"
using FacturationSolution.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/CA")]
    public partial class CA : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Chiffre d\'afaire</h3>\r\n\r\n");
            __builder.AddMarkupContent(1, "<p> Voici une aperçu des chiffres d\'affaires réels et attendus </p>\r\n\r\n");
            __builder.OpenElement(2, "p");
            __builder.AddMarkupContent(3, "  Chiffre d\'affaire réel : ");
            __builder.AddContent(4, 
#nullable restore
#line 8 "C:\Users\mondo\OneDrive\Documents\GitHub\ExerciceFacturationMoevaMondoha\FacturationSolution\FacturationSolution\Pages\CA.razor"
                               IncrementCADu()

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(5, "\r\n");
            __builder.OpenElement(6, "p");
            __builder.AddMarkupContent(7, "  Chiffre d\'affaire supposé : ");
            __builder.AddContent(8, 
#nullable restore
#line 9 "C:\Users\mondo\OneDrive\Documents\GitHub\ExerciceFacturationMoevaMondoha\FacturationSolution\FacturationSolution\Pages\CA.razor"
                                  IncrementCAReel()

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 10 "C:\Users\mondo\OneDrive\Documents\GitHub\ExerciceFacturationMoevaMondoha\FacturationSolution\FacturationSolution\Pages\CA.razor"
       
    private int caDû = 0;
    private int caSupposé = 0;
    private int IncrementCADu()
    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\mondo\OneDrive\Documents\GitHub\ExerciceFacturationMoevaMondoha\FacturationSolution\FacturationSolution\Pages\CA.razor"
         foreach (var factures in data.Factures)
        {
            caDû += @factures.montants_dû;

        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "C:\Users\mondo\OneDrive\Documents\GitHub\ExerciceFacturationMoevaMondoha\FacturationSolution\FacturationSolution\Pages\CA.razor"
         
        return caDû;
    }
    private int IncrementCAReel()
    {
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 24 "C:\Users\mondo\OneDrive\Documents\GitHub\ExerciceFacturationMoevaMondoha\FacturationSolution\FacturationSolution\Pages\CA.razor"
     foreach (var factures in data.Factures)
    {
        caSupposé += @factures.montants_regler;
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 27 "C:\Users\mondo\OneDrive\Documents\GitHub\ExerciceFacturationMoevaMondoha\FacturationSolution\FacturationSolution\Pages\CA.razor"
     
        return caSupposé;
    }
    

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IBusinessData data { get; set; }
    }
}
#pragma warning restore 1591
