// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace P9.Client.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "c:\git\AP99002\FinalProject\P9\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "c:\git\AP99002\FinalProject\P9\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "c:\git\AP99002\FinalProject\P9\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "c:\git\AP99002\FinalProject\P9\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "c:\git\AP99002\FinalProject\P9\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "c:\git\AP99002\FinalProject\P9\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "c:\git\AP99002\FinalProject\P9\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "c:\git\AP99002\FinalProject\P9\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "c:\git\AP99002\FinalProject\P9\Client\_Imports.razor"
using P9.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "c:\git\AP99002\FinalProject\P9\Client\_Imports.razor"
using P9.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "c:\git\AP99002\FinalProject\P9\Client\Pages\FetchData.razor"
using P9.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "c:\git\AP99002\FinalProject\P9\Client\Pages\FetchData.razor"
using p9.client.Mydata;

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
#line 84 "c:\git\AP99002\FinalProject\P9\Client\Pages\FetchData.razor"
       
    public void result ()
    {
        navigationManager.NavigateTo("/A");
    }
    
    public void add1(Clothe a )
    {
        if (!(cart.kala.Contains(a)))
        {
            a.number++;
            cart.kala.Add(a);
        }
        else
        {
            a.number++;
        }
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 101 "c:\git\AP99002\FinalProject\P9\Client\Pages\FetchData.razor"
                        
    }

    public async Task update()
    {
        HttpClient client = new HttpClient();
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 107 "c:\git\AP99002\FinalProject\P9\Client\Pages\FetchData.razor"
                                                                                      
        foreach (var item in cart.kala)
        {
            item.count = item.count - item.number;
        }
        await client.PutAsJsonAsync("http://localhost:5000/api/Clothe/reducecount",cart.kala); 
        StateHasChanged(); 
        navigationManager.NavigateTo("/counter");
    }
    protected override async Task OnInitializedAsync()
    {
        HttpClient client = new HttpClient();
        anbar.forecasts = await Http.GetFromJsonAsync<Clothe[]>("http://localhost:5000/api/Clothe/getallclothe");
        StateHasChanged();
    }
    public void remove(Clothe v)
    {
        if (cart.kala.Contains(v))
        {
            v.number--;
            if (v.number == 0)
            {
                cart.kala.Remove(v);
            }
        }
        
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Microsoft.AspNetCore.Components.NavigationManager navigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
