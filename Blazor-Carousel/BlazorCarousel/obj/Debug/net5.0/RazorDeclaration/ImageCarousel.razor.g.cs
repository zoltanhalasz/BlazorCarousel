// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace BlazorCarousel
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Dotnet\DavidSeesSharp-Videos\Blazor-Carousel\BlazorCarousel\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Dotnet\DavidSeesSharp-Videos\Blazor-Carousel\BlazorCarousel\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Dotnet\DavidSeesSharp-Videos\Blazor-Carousel\BlazorCarousel\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Dotnet\DavidSeesSharp-Videos\Blazor-Carousel\BlazorCarousel\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Dotnet\DavidSeesSharp-Videos\Blazor-Carousel\BlazorCarousel\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Dotnet\DavidSeesSharp-Videos\Blazor-Carousel\BlazorCarousel\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Dotnet\DavidSeesSharp-Videos\Blazor-Carousel\BlazorCarousel\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Dotnet\DavidSeesSharp-Videos\Blazor-Carousel\BlazorCarousel\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Dotnet\DavidSeesSharp-Videos\Blazor-Carousel\BlazorCarousel\_Imports.razor"
using BlazorCarousel;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Dotnet\DavidSeesSharp-Videos\Blazor-Carousel\BlazorCarousel\_Imports.razor"
using BlazorCarousel.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Dotnet\DavidSeesSharp-Videos\Blazor-Carousel\BlazorCarousel\ImageCarousel.razor"
using System.Threading;

#line default
#line hidden
#nullable disable
    public partial class ImageCarousel : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 26 "C:\Dotnet\DavidSeesSharp-Videos\Blazor-Carousel\BlazorCarousel\ImageCarousel.razor"
       
    public void Manualy(bool backwards)
    {
        if (!cts.IsCancellationRequested)
            cts.Cancel();
        if (backwards)
            currentPosition--;
        else
            currentPosition++;
        if (currentPosition >= Images.Length) currentPosition = 0;
        if (currentPosition < 0) currentPosition = Images.Length - 1;
    }

    [Parameter]

    public string[] Images { get; set; }

    //public Type[] Components { get; set; }

    int currentPosition;
    CancellationTokenSource cts;
    CancellationToken ct;

    private async void CallBck(int k)
    {
        Console.WriteLine("CallBack called " + k.ToString());
        currentPosition = k;
        await InvokeAsync(() => this.StateHasChanged());

    }

    protected override async Task OnInitializedAsync()
    {
        cts = new CancellationTokenSource();
        ct = cts.Token;
        Walkthrough();
    }
    public async Task Walkthrough()
    {
        while (!ct.IsCancellationRequested)
        {
            await Task.Delay(3500, ct);
            currentPosition++;
            await InvokeAsync(() => this.StateHasChanged());
        }
    }
    //public RenderFragment Render(int position)
    //{
    //    return RenderTreeBuilder =>
    //    {
    //        RenderTreeBuilder.OpenComponent(0, Components[Math.Abs(position % Components.Length)]);
    //        RenderTreeBuilder.CloseComponent();
    //    };
    //}

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
