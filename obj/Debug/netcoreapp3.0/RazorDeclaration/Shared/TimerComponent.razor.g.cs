#pragma checksum "D:\Perso\InnovTechExercice\Shared\TimerComponent.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "11859d8ca76cab1a8e3fa68d88d1581cb9c52ba0"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace InnovTechExercice.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\Perso\InnovTechExercice\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Perso\InnovTechExercice\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Perso\InnovTechExercice\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Perso\InnovTechExercice\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Perso\InnovTechExercice\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\Perso\InnovTechExercice\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\Perso\InnovTechExercice\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\Perso\InnovTechExercice\_Imports.razor"
using InnovTechExercice;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\Perso\InnovTechExercice\_Imports.razor"
using InnovTechExercice.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "D:\Perso\InnovTechExercice\Shared\TimerComponent.razor"
using InnovTechExercice.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Perso\InnovTechExercice\Shared\TimerComponent.razor"
using System.Threading;

#line default
#line hidden
#nullable disable
    public class TimerComponent : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 8 "D:\Perso\InnovTechExercice\Shared\TimerComponent.razor"
       

    protected override void OnAfterRender(bool firstRender)
    {
        TimerService.Handler = this.OnElapsed;
    }

    public void OnElapsed()
    {
        TimerService.Decrement();
        InvokeAsync(() => StateHasChanged());
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private TimerService TimerService { get; set; }
    }
}
#pragma warning restore 1591
