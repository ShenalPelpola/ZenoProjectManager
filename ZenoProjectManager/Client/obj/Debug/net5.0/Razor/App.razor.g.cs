#pragma checksum "C:\Users\Acer\source\repos\Zeno\ZenoProjectManager\Client\App.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ba99658a34554b97836fcb6d9edc57d3a401eea6"
// <auto-generated/>
#pragma warning disable 1591
namespace ZenoProjectManager.Client
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Acer\source\repos\Zeno\ZenoProjectManager\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Acer\source\repos\Zeno\ZenoProjectManager\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Acer\source\repos\Zeno\ZenoProjectManager\Client\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Acer\source\repos\Zeno\ZenoProjectManager\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Acer\source\repos\Zeno\ZenoProjectManager\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Acer\source\repos\Zeno\ZenoProjectManager\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Acer\source\repos\Zeno\ZenoProjectManager\Client\_Imports.razor"
using Microsoft.AspNetCore.WebUtilities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Acer\source\repos\Zeno\ZenoProjectManager\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Acer\source\repos\Zeno\ZenoProjectManager\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Acer\source\repos\Zeno\ZenoProjectManager\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Acer\source\repos\Zeno\ZenoProjectManager\Client\_Imports.razor"
using ZenoProjectManager.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\Acer\source\repos\Zeno\ZenoProjectManager\Client\_Imports.razor"
using ZenoProjectManager.Client.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\Acer\source\repos\Zeno\ZenoProjectManager\Client\_Imports.razor"
using ZenoProjectManager.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\Acer\source\repos\Zeno\ZenoProjectManager\Client\_Imports.razor"
using ZenoProjectManager.Shared.Entities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\Acer\source\repos\Zeno\ZenoProjectManager\Client\_Imports.razor"
using ZenoProjectManager.Shared.Entities.ResponseFormats;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\Acer\source\repos\Zeno\ZenoProjectManager\Client\_Imports.razor"
using ZenoProjectManager.Shared.Entities.RequestFormats;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "C:\Users\Acer\source\repos\Zeno\ZenoProjectManager\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "C:\Users\Acer\source\repos\Zeno\ZenoProjectManager\Client\_Imports.razor"
using Blazored.LocalStorage;

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "C:\Users\Acer\source\repos\Zeno\ZenoProjectManager\Client\_Imports.razor"
using Blazored.Toast;

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "C:\Users\Acer\source\repos\Zeno\ZenoProjectManager\Client\_Imports.razor"
using Blazored.Toast.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 21 "C:\Users\Acer\source\repos\Zeno\ZenoProjectManager\Client\_Imports.razor"
using ChartJs.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 22 "C:\Users\Acer\source\repos\Zeno\ZenoProjectManager\Client\_Imports.razor"
using ChartJs.Blazor.Common.Axes;

#line default
#line hidden
#nullable disable
#nullable restore
#line 23 "C:\Users\Acer\source\repos\Zeno\ZenoProjectManager\Client\_Imports.razor"
using ChartJs.Blazor.Common.Axes.Ticks;

#line default
#line hidden
#nullable disable
#nullable restore
#line 24 "C:\Users\Acer\source\repos\Zeno\ZenoProjectManager\Client\_Imports.razor"
using ChartJs.Blazor.Common.Enums;

#line default
#line hidden
#nullable disable
#nullable restore
#line 25 "C:\Users\Acer\source\repos\Zeno\ZenoProjectManager\Client\_Imports.razor"
using ChartJs.Blazor.Common.Handlers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 26 "C:\Users\Acer\source\repos\Zeno\ZenoProjectManager\Client\_Imports.razor"
using ChartJs.Blazor.Common.Time;

#line default
#line hidden
#nullable disable
#nullable restore
#line 27 "C:\Users\Acer\source\repos\Zeno\ZenoProjectManager\Client\_Imports.razor"
using ChartJs.Blazor.Util;

#line default
#line hidden
#nullable disable
#nullable restore
#line 28 "C:\Users\Acer\source\repos\Zeno\ZenoProjectManager\Client\_Imports.razor"
using ChartJs.Blazor.Interop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 29 "C:\Users\Acer\source\repos\Zeno\ZenoProjectManager\Client\_Imports.razor"
using ChartJs.Blazor.Common;

#line default
#line hidden
#nullable disable
#nullable restore
#line 30 "C:\Users\Acer\source\repos\Zeno\ZenoProjectManager\Client\_Imports.razor"
using System.Drawing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 31 "C:\Users\Acer\source\repos\Zeno\ZenoProjectManager\Client\_Imports.razor"
using ZenoProjectManager.Client.Services.Prediction;

#line default
#line hidden
#nullable disable
    public partial class App : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.CascadingAuthenticationState>(0);
            __builder.AddAttribute(1, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Routing.Router>(2);
                __builder2.AddAttribute(3, "AppAssembly", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Reflection.Assembly>(
#nullable restore
#line 2 "C:\Users\Acer\source\repos\Zeno\ZenoProjectManager\Client\App.razor"
                          typeof(Program).Assembly

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(4, "PreferExactMatches", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 2 "C:\Users\Acer\source\repos\Zeno\ZenoProjectManager\Client\App.razor"
                                                                         true

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(5, "Found", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.RouteData>)((routeData) => (__builder3) => {
                    __builder3.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeRouteView>(6);
                    __builder3.AddAttribute(7, "RouteData", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.RouteData>(
#nullable restore
#line 4 "C:\Users\Acer\source\repos\Zeno\ZenoProjectManager\Client\App.razor"
                                            routeData

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(8, "DefaultLayout", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Type>(
#nullable restore
#line 4 "C:\Users\Acer\source\repos\Zeno\ZenoProjectManager\Client\App.razor"
                                                                       typeof(ZenoMainLayout)

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(9, "NotAuthorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder4) => {
                        __builder4.AddMarkupContent(10, "<p>You are not authorized.</p>");
                    }
                    ));
                    __builder3.CloseComponent();
                }
                ));
                __builder2.AddAttribute(11, "NotFound", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<Microsoft.AspNetCore.Components.LayoutView>(12);
                    __builder3.AddAttribute(13, "Layout", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Type>(
#nullable restore
#line 11 "C:\Users\Acer\source\repos\Zeno\ZenoProjectManager\Client\App.razor"
                                 typeof(ZenoMainLayout)

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(14, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddMarkupContent(15, "<p>Sorry, there\'s nothing at this address.</p>");
                    }
                    ));
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
