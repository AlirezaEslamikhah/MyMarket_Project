#pragma checksum "C:\git\AP99002\Project\P9\Client\Pages\Counter.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2d9b91b92e6739c3e04c6c8fc9b2235ab8a57b79"
// <auto-generated/>
#pragma warning disable 1591
namespace P9.Client.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\git\AP99002\Project\P9\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\git\AP99002\Project\P9\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\git\AP99002\Project\P9\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\git\AP99002\Project\P9\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\git\AP99002\Project\P9\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\git\AP99002\Project\P9\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\git\AP99002\Project\P9\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\git\AP99002\Project\P9\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\git\AP99002\Project\P9\Client\_Imports.razor"
using P9.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\git\AP99002\Project\P9\Client\_Imports.razor"
using P9.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\git\AP99002\Project\P9\Client\_Imports.razor"
using P9.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\git\AP99002\Project\P9\Client\Pages\Counter.razor"
using p9.client.Mydata;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/counter")]
    public partial class Counter : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, @"<style>
    #wrapper {width: 900px;margin:manual}
    #content{background-color:Yellow}
    body {
    background-image: url('https://coolbackgrounds.io/images/backgrounds/index/disco-dba865f1.png');
    background-repeat: no-repeat;
    background-attachment: fixed;
    background-size: cover;
    }
</style>
");
            __builder.OpenElement(1, "button");
            __builder.AddAttribute(2, "style", "color:black");
            __builder.AddAttribute(3, "type", "submit");
            __builder.AddAttribute(4, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 14 "C:\git\AP99002\Project\P9\Client\Pages\Counter.razor"
                                                      result

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(5, "??????????????????????????REMOVE YOUR OWN ACCOUNT??????????????????????????");
            __builder.CloseElement();
            __builder.AddMarkupContent(6, "\r\n\r\n");
            __builder.AddMarkupContent(7, "<h1>\r\n    THANKS FOR YOU SHOPPING\r\n</h1>\r\nName: ");
            __builder.AddContent(8, 
#nullable restore
#line 19 "C:\git\AP99002\Project\P9\Client\Pages\Counter.razor"
       karbar.user2.FirstName

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(9, " <br><br>\r\nLast Name: ");
            __builder.AddContent(10, 
#nullable restore
#line 20 "C:\git\AP99002\Project\P9\Client\Pages\Counter.razor"
            karbar.user2.LastName

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(11, " <br><br>\r\nYour ID: ");
            __builder.AddContent(12, 
#nullable restore
#line 21 "C:\git\AP99002\Project\P9\Client\Pages\Counter.razor"
          karbar.user2.ID

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(13, " <br><br>\r\n\r\n");
            __builder.OpenElement(14, "table");
            __builder.AddAttribute(15, "class", "table");
            __builder.AddMarkupContent(16, "<thead><tr><th>Pic</th>\r\n                <th>Name</th>\r\n                <th>Price</th>\r\n                <th>Number</th></tr></thead>\r\n        ");
            __builder.OpenElement(17, "tbody");
#nullable restore
#line 34 "C:\git\AP99002\Project\P9\Client\Pages\Counter.razor"
             foreach (var forecast in cart.kala)
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(18, "tr");
            __builder.OpenElement(19, "td");
            __builder.OpenElement(20, "img");
            __builder.AddAttribute(21, "src", 
#nullable restore
#line 37 "C:\git\AP99002\Project\P9\Client\Pages\Counter.razor"
                                     forecast.picture

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\r\n                    ");
            __builder.OpenElement(23, "td");
            __builder.AddContent(24, 
#nullable restore
#line 38 "C:\git\AP99002\Project\P9\Client\Pages\Counter.razor"
                         forecast.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\r\n                    ");
            __builder.OpenElement(26, "td");
            __builder.AddContent(27, 
#nullable restore
#line 39 "C:\git\AP99002\Project\P9\Client\Pages\Counter.razor"
                         forecast.Price

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(28, "\r\n                    ");
            __builder.OpenElement(29, "td");
            __builder.AddContent(30, 
#nullable restore
#line 40 "C:\git\AP99002\Project\P9\Client\Pages\Counter.razor"
                         forecast.number

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 43 "C:\git\AP99002\Project\P9\Client\Pages\Counter.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(31, "\r\n\r\n");
            __builder.OpenElement(32, "p");
            __builder.AddContent(33, "TOTAL PRICE IS : ");
            __builder.AddContent(34, 
#nullable restore
#line 47 "C:\git\AP99002\Project\P9\Client\Pages\Counter.razor"
                     cart.calc()

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(35, "\r\n<img src=\"https://edit.org/img/blog/x1x-free-printable-thank-you-purchase-template.jpg\">");
        }
        #pragma warning restore 1998
#nullable restore
#line 50 "C:\git\AP99002\Project\P9\Client\Pages\Counter.razor"
       
    public async Task result()
    {
        HttpClient client = new HttpClient();
        User g = await client.GetFromJsonAsync<User>("http://localhost:5000/api/User/getlastuser");
        string path = $"http://localhost:5000/api/User/deleteuser?id={g.ID}";
        await client.DeleteAsync(path);
        StateHasChanged();
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
