#pragma checksum "C:\Users\Acer\source\repos\Zeno\ZenoProjectManager\Client\Pages\Prediction\PredictionView.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "85726ea196f291fa4f20b8895dfa31654c508e80"
// <auto-generated/>
#pragma warning disable 1591
namespace ZenoProjectManager.Client.Pages.Prediction
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
#nullable restore
#line 2 "C:\Users\Acer\source\repos\Zeno\ZenoProjectManager\Client\Pages\Prediction\PredictionView.razor"
           [Authorize(Roles = "admin")]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/companies/{CompanyId:guid}/prediction")]
    public partial class PredictionView : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<ZenoProjectManager.Client.Shared.SideNavCompany>(0);
            __builder.AddAttribute(1, "CompanyId", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Guid>(
#nullable restore
#line 4 "C:\Users\Acer\source\repos\Zeno\ZenoProjectManager\Client\Pages\Prediction\PredictionView.razor"
                            CompanyId

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(2, "\r\n");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "content-container");
            __builder.AddAttribute(5, "id", "content-container");
            __builder.AddMarkupContent(6, "<h2>Predictions</h2>");
#nullable restore
#line 8 "C:\Users\Acer\source\repos\Zeno\ZenoProjectManager\Client\Pages\Prediction\PredictionView.razor"
     if (!fetched)
    {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(7, "<img src=\"./images/spinner.gif\" class=\"spinner\" alt=\"Loading...\">");
#nullable restore
#line 11 "C:\Users\Acer\source\repos\Zeno\ZenoProjectManager\Client\Pages\Prediction\PredictionView.razor"
    }
    else
    {

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(8);
            __builder.AddAttribute(9, "class", "row g-3 mt-3 pb-5 border-bottom");
            __builder.AddAttribute(10, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 14 "C:\Users\Acer\source\repos\Zeno\ZenoProjectManager\Client\Pages\Prediction\PredictionView.razor"
                                                                 predictionRequest

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(11, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 14 "C:\Users\Acer\source\repos\Zeno\ZenoProjectManager\Client\Pages\Prediction\PredictionView.razor"
                                                                                                   HandleCreateForm

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(12, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(13);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(14, "\r\n            ");
                __builder2.OpenElement(15, "div");
                __builder2.AddAttribute(16, "class", "col-md-3");
                __Blazor.ZenoProjectManager.Client.Pages.Prediction.PredictionView.TypeInference.CreateInputDate_0(__builder2, 17, 18, "form-control", 19, "ticketName", 20, true, 21, 
#nullable restore
#line 17 "C:\Users\Acer\source\repos\Zeno\ZenoProjectManager\Client\Pages\Prediction\PredictionView.razor"
                                        predictionRequest.PredictionDate

#line default
#line hidden
#nullable disable
                , 22, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => predictionRequest.PredictionDate = __value, predictionRequest.PredictionDate)), 23, () => predictionRequest.PredictionDate);
                __builder2.CloseElement();
                __builder2.AddMarkupContent(24, "\r\n            ");
                __builder2.AddMarkupContent(25, "<div class=\"col-md-2\"><button type=\"submit\" class=\"btn btn-primary\">Submit</button></div>");
            }
            ));
            __builder.CloseComponent();
            __builder.OpenElement(26, "div");
            __builder.AddAttribute(27, "class", "row mt-4");
            __builder.OpenElement(28, "div");
            __builder.AddAttribute(29, "class", "col-sm-6");
            __builder.OpenElement(30, "div");
            __builder.AddAttribute(31, "class", "card rounded");
            __builder.OpenElement(32, "div");
            __builder.AddAttribute(33, "class", "card-body rounded text-center bg-info text-white");
            __builder.AddMarkupContent(34, "<h4 class=\"card-title\">Current Number of projects</h4>\r\n                        ");
            __builder.OpenElement(35, "p");
            __builder.AddAttribute(36, "class", "card-text mt-4 mb-4 h2 text-center");
            __builder.AddMarkupContent(37, "<i class=\"fas fa-tasks fa-2x\"></i> ");
            __builder.AddContent(38, 
#nullable restore
#line 29 "C:\Users\Acer\source\repos\Zeno\ZenoProjectManager\Client\Pages\Prediction\PredictionView.razor"
                                                                                                          currentProjects

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(39, "\r\n            ");
            __builder.OpenElement(40, "div");
            __builder.AddAttribute(41, "class", "col-sm-6");
            __builder.OpenElement(42, "div");
            __builder.AddAttribute(43, "class", "card rounded");
            __builder.OpenElement(44, "div");
            __builder.AddAttribute(45, "class", "card-body rounded text-center bg-warning text-white");
            __builder.AddMarkupContent(46, "<h4 class=\"card-title\">Predicted Number of projects.</h4>\r\n                        ");
            __builder.OpenElement(47, "p");
            __builder.AddAttribute(48, "class", "card-text mt-4 mb-4 h2 text-center");
            __builder.AddMarkupContent(49, "<i class=\"fas fa-chart-line fa-2x\"></i> ");
            __builder.AddContent(50, 
#nullable restore
#line 37 "C:\Users\Acer\source\repos\Zeno\ZenoProjectManager\Client\Pages\Prediction\PredictionView.razor"
                                                                                                               predictedProjects

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.OpenElement(51, "table");
            __builder.AddAttribute(52, "class", "table mt-4");
            __builder.AddMarkupContent(53, @"<thead class=""thead-dark""><tr><th scope=""col"">Project ID</th>
                    <th scope=""col"">Project Name</th>
                    <th scope=""col"">Current Users</th>
                    <th scope=""col"">Predicted Users</th></tr></thead>
            ");
            __builder.OpenElement(54, "tbody");
#nullable restore
#line 53 "C:\Users\Acer\source\repos\Zeno\ZenoProjectManager\Client\Pages\Prediction\PredictionView.razor"
                 foreach (var user in userPrediction)
                {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(55, "tr");
            __builder.OpenElement(56, "th");
            __builder.AddAttribute(57, "scope", "row");
            __builder.AddContent(58, 
#nullable restore
#line 56 "C:\Users\Acer\source\repos\Zeno\ZenoProjectManager\Client\Pages\Prediction\PredictionView.razor"
                                         user.ProjectId

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(59, "\r\n                        ");
            __builder.OpenElement(60, "td");
            __builder.AddContent(61, 
#nullable restore
#line 57 "C:\Users\Acer\source\repos\Zeno\ZenoProjectManager\Client\Pages\Prediction\PredictionView.razor"
                             user.ProjectName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(62, "\r\n                        ");
            __builder.OpenElement(63, "td");
            __builder.AddContent(64, 
#nullable restore
#line 58 "C:\Users\Acer\source\repos\Zeno\ZenoProjectManager\Client\Pages\Prediction\PredictionView.razor"
                             user.CurrentUsers

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(65, "\r\n                        ");
            __builder.OpenElement(66, "td");
            __builder.AddContent(67, 
#nullable restore
#line 59 "C:\Users\Acer\source\repos\Zeno\ZenoProjectManager\Client\Pages\Prediction\PredictionView.razor"
                             user.PredictedUsers

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 61 "C:\Users\Acer\source\repos\Zeno\ZenoProjectManager\Client\Pages\Prediction\PredictionView.razor"
                }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 64 "C:\Users\Acer\source\repos\Zeno\ZenoProjectManager\Client\Pages\Prediction\PredictionView.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 67 "C:\Users\Acer\source\repos\Zeno\ZenoProjectManager\Client\Pages\Prediction\PredictionView.razor"
       
    [Parameter]
    public Guid CompanyId { get; set; }
    [Inject]
    private ICompanyService _companyService { get; set; }
    private int currentProjects { get; set; }
    private int predictedProjects { get; set; }
    private bool fetched = false;
    private IEnumerable<UserPredictionResponse> userPrediction { get; set; }
    private PredictionResponse projectPrediction { get; set; }

    [Inject]
    private IPredictionService _predictionService { get; set; }
    [Inject]
    private IProjectService _projectService { get; set; }
    private PredictionRequest predictionRequest { get; set; } = new PredictionRequest();


    protected async override Task OnInitializedAsync()
    {
        Company company = await _companyService.GetCompanyById(CompanyId);
        predictionRequest.CompanyId = CompanyId;
        predictionRequest.CompanyCreatedDate = company.CreatedDate;
        predictionRequest.PredictionDate = DateTime.Now.AddMonths(1);

        projectPrediction = await _predictionService.GetProjectsPrediction(predictionRequest);
        userPrediction = await _predictionService.GetUserPrediction(predictionRequest);
        if (projectPrediction == null)
        {
            predictedProjects = 0;
            currentProjects = (await _projectService.GetProjects(company.Id.ToString())).Count();
        }
        else
        {
            if (projectPrediction.Prediction < 0)
            {
                currentProjects = (await _projectService.GetProjects(company.Id.ToString())).Count();
                predictedProjects = 0;
            }
            else
            {
                currentProjects = projectPrediction.Current;
                predictedProjects = projectPrediction.Prediction;
            }
        }

        fetched = true;
    }

    private async Task HandleCreateForm()
    {
        projectPrediction = await _predictionService.GetProjectsPrediction(predictionRequest);
        userPrediction = await _predictionService.GetUserPrediction(predictionRequest);
        if (projectPrediction == null)
        {
            predictedProjects = 0;
        }
        else
        {
            if (projectPrediction.Prediction < 0)
            {
                predictedProjects = 0;
            }
            else
            {
                predictedProjects = projectPrediction.Prediction;
            }
        }
        fetched = true;
    }

#line default
#line hidden
#nullable disable
    }
}
namespace __Blazor.ZenoProjectManager.Client.Pages.Prediction.PredictionView
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateInputDate_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, System.Object __arg1, int __seq2, System.Object __arg2, int __seq3, TValue __arg3, int __seq4, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg4, int __seq5, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg5)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputDate<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", __arg0);
        __builder.AddAttribute(__seq1, "id", __arg1);
        __builder.AddAttribute(__seq2, "required", __arg2);
        __builder.AddAttribute(__seq3, "Value", __arg3);
        __builder.AddAttribute(__seq4, "ValueChanged", __arg4);
        __builder.AddAttribute(__seq5, "ValueExpression", __arg5);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
