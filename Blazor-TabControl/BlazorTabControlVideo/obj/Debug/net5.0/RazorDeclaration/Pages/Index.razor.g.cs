// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace BlazorTabControlVideo.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Dotnet\DavidSeesSharp-Videos\Blazor-TabControl\BlazorTabControlVideo\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Dotnet\DavidSeesSharp-Videos\Blazor-TabControl\BlazorTabControlVideo\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Dotnet\DavidSeesSharp-Videos\Blazor-TabControl\BlazorTabControlVideo\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Dotnet\DavidSeesSharp-Videos\Blazor-TabControl\BlazorTabControlVideo\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Dotnet\DavidSeesSharp-Videos\Blazor-TabControl\BlazorTabControlVideo\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Dotnet\DavidSeesSharp-Videos\Blazor-TabControl\BlazorTabControlVideo\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Dotnet\DavidSeesSharp-Videos\Blazor-TabControl\BlazorTabControlVideo\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Dotnet\DavidSeesSharp-Videos\Blazor-TabControl\BlazorTabControlVideo\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Dotnet\DavidSeesSharp-Videos\Blazor-TabControl\BlazorTabControlVideo\_Imports.razor"
using BlazorTabControlVideo;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Dotnet\DavidSeesSharp-Videos\Blazor-TabControl\BlazorTabControlVideo\_Imports.razor"
using BlazorTabControlVideo.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 28 "C:\Dotnet\DavidSeesSharp-Videos\Blazor-TabControl\BlazorTabControlVideo\Pages\Index.razor"
      
    RenderFragment GetRenderFragment(Type type)
    {
        RenderFragment renderFragment = renderTreeBuilder =>
        {
            renderTreeBuilder.OpenComponent(0, type);
            renderTreeBuilder.CloseComponent();
        };
        return renderFragment;
    }
    int selected;
    ComponentBase[] components = { new Counter(), new SurveyPrompt(), new FetchData() };
    Type[] types => components.Select(c => c.GetType()).ToArray();

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
