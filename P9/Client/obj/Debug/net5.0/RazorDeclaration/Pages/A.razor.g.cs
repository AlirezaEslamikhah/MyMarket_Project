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
#line 11 "c:\git\AP99002\FinalProject\P9\Client\_Imports.razor"
using P9.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "c:\git\AP99002\FinalProject\P9\Client\Pages\A.razor"
using p9.client.Mydata;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "c:\git\AP99002\FinalProject\P9\Client\Pages\A.razor"
using Microsoft.AspNetCore.Components;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/A")]
    public partial class A : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 45 "c:\git\AP99002\FinalProject\P9\Client\Pages\A.razor"
 
    Clothe f = new Clothe();
    protected  async Task ezafee()
    {
        HttpClient b = new HttpClient();
        await b.PostAsJsonAsync("http://localhost:5000/api/Clothe/addclothe",f);
        StateHasChanged();
        
    }
    

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
