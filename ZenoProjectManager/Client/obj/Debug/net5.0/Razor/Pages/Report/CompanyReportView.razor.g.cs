#pragma checksum "C:\Users\Acer\source\repos\Zeno\ZenoProjectManager\Client\Pages\Report\CompanyReportView.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "231884b35a5e841ee4adeb0c99f7913acb2e5c97"
// <auto-generated/>
#pragma warning disable 1591
namespace ZenoProjectManager.Client.Pages.Report
{
    #line hidden
    using System;
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
#line 31 "C:\Users\Acer\source\repos\Zeno\ZenoProjectManager\Client\_Imports.razor"
using ZenoProjectManager.Client.Services.Prediction;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Acer\source\repos\Zeno\ZenoProjectManager\Client\Pages\Report\CompanyReportView.razor"
using ChartJs.Blazor.PieChart;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Acer\source\repos\Zeno\ZenoProjectManager\Client\Pages\Report\CompanyReportView.razor"
using System.Drawing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Acer\source\repos\Zeno\ZenoProjectManager\Client\Pages\Report\CompanyReportView.razor"
using System.Collections.Generic;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Acer\source\repos\Zeno\ZenoProjectManager\Client\Pages\Report\CompanyReportView.razor"
using System.Text;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Acer\source\repos\Zeno\ZenoProjectManager\Client\Pages\Report\CompanyReportView.razor"
           [Authorize(Roles = "admin")]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/companies/{CompanyId:guid}/report")]
    public partial class CompanyReportView : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<ZenoProjectManager.Client.Shared.SideNavCompany>(0);
            __builder.AddAttribute(1, "CompanyId", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Guid>(
#nullable restore
#line 8 "C:\Users\Acer\source\repos\Zeno\ZenoProjectManager\Client\Pages\Report\CompanyReportView.razor"
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
            __builder.AddMarkupContent(6, "<h5 class=\"mb-2 pb-4\">Company Report</h5>");
#nullable restore
#line 12 "C:\Users\Acer\source\repos\Zeno\ZenoProjectManager\Client\Pages\Report\CompanyReportView.razor"
     if (!fetched)
    {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(7, "<img src=\"./images/spinner.gif\" class=\"spinner\" alt=\"Loading...\">");
#nullable restore
#line 15 "C:\Users\Acer\source\repos\Zeno\ZenoProjectManager\Client\Pages\Report\CompanyReportView.razor"
    }
    else
    {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(8, "<h6 class=\"mt-3 pb-3 border-bottom\">Current Day Stats</h6>\r\n    ");
            __builder.OpenElement(9, "div");
            __builder.AddAttribute(10, "class", "row mt-4");
            __builder.OpenElement(11, "div");
            __builder.AddAttribute(12, "class", "col-md-4");
            __builder.OpenElement(13, "div");
            __builder.AddAttribute(14, "class", "card rounded");
            __builder.OpenElement(15, "div");
            __builder.AddAttribute(16, "class", "card-body rounded text-center bg-info text-white");
            __builder.AddMarkupContent(17, "<h4 class=\"card-title\">Total Projects</h4>\r\n                    ");
            __builder.OpenElement(18, "p");
            __builder.AddAttribute(19, "class", "card-text mt-4 mb-4 h2 text-center");
            __builder.AddMarkupContent(20, "<i class=\"fas fa-tasks fa-2x m-lg-1\"></i> ");
            __builder.AddContent(21, 
#nullable restore
#line 24 "C:\Users\Acer\source\repos\Zeno\ZenoProjectManager\Client\Pages\Report\CompanyReportView.razor"
                                                                                                             totalProjects

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\r\n        ");
            __builder.OpenElement(23, "div");
            __builder.AddAttribute(24, "class", "col-md-4");
            __builder.OpenElement(25, "div");
            __builder.AddAttribute(26, "class", "card rounded");
            __builder.OpenElement(27, "div");
            __builder.AddAttribute(28, "class", "card-body rounded text-center bg-warning text-white");
            __builder.AddMarkupContent(29, "<h4 class=\"card-title\">Total Tickets</h4>\r\n                    ");
            __builder.OpenElement(30, "p");
            __builder.AddAttribute(31, "class", "card-text mt-4 mb-4 h2 text-center");
            __builder.AddMarkupContent(32, "<i class=\"fas fa-chart-line fa-2x m-lg-1\"></i>");
            __builder.AddContent(33, 
#nullable restore
#line 32 "C:\Users\Acer\source\repos\Zeno\ZenoProjectManager\Client\Pages\Report\CompanyReportView.razor"
                                                                                                                 totalTickets

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(34, "\r\n        ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(35);
            __builder.AddAttribute(36, "class", "row g-3 mt-4 pb-4 border-bottom");
            __builder.AddAttribute(37, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 37 "C:\Users\Acer\source\repos\Zeno\ZenoProjectManager\Client\Pages\Report\CompanyReportView.razor"
                                                                 reportRequest

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(38, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 37 "C:\Users\Acer\source\repos\Zeno\ZenoProjectManager\Client\Pages\Report\CompanyReportView.razor"
                                                                                               HandleCreateForm

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(39, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(40);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(41, "\r\n            ");
                __builder2.OpenElement(42, "div");
                __builder2.AddAttribute(43, "class", "col-md-3");
                __Blazor.ZenoProjectManager.Client.Pages.Report.CompanyReportView.TypeInference.CreateInputDate_0(__builder2, 44, 45, "form-control", 46, "ticketName", 47, true, 48, 
#nullable restore
#line 40 "C:\Users\Acer\source\repos\Zeno\ZenoProjectManager\Client\Pages\Report\CompanyReportView.razor"
                                        reportRequest.StartDate

#line default
#line hidden
#nullable disable
                , 49, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => reportRequest.StartDate = __value, reportRequest.StartDate)), 50, () => reportRequest.StartDate);
                __builder2.CloseElement();
                __builder2.AddMarkupContent(51, "\r\n            ");
                __builder2.OpenElement(52, "div");
                __builder2.AddAttribute(53, "class", "col-md-3");
                __Blazor.ZenoProjectManager.Client.Pages.Report.CompanyReportView.TypeInference.CreateInputDate_1(__builder2, 54, 55, "form-control", 56, "ticketDescription", 57, "margin-top: -1px;", 58, "4", 59, 
#nullable restore
#line 43 "C:\Users\Acer\source\repos\Zeno\ZenoProjectManager\Client\Pages\Report\CompanyReportView.razor"
                                        reportRequest.EndDate

#line default
#line hidden
#nullable disable
                , 60, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => reportRequest.EndDate = __value, reportRequest.EndDate)), 61, () => reportRequest.EndDate);
                __builder2.CloseElement();
                __builder2.AddMarkupContent(62, "\r\n\r\n            ");
                __builder2.AddMarkupContent(63, "<div class=\"col-md-2\"><button type=\"submit\" class=\"btn btn-primary\">Submit</button></div>");
            }
            ));
            __builder.CloseComponent();
            __builder.OpenElement(64, "h6");
            __builder.AddAttribute(65, "class", "mt-2 pb-1");
            __builder.AddContent(66, "Report for date range of ");
            __builder.AddContent(67, 
#nullable restore
#line 51 "C:\Users\Acer\source\repos\Zeno\ZenoProjectManager\Client\Pages\Report\CompanyReportView.razor"
                                                        reportRequest.StartDate.Date

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(68, " - ");
            __builder.AddContent(69, 
#nullable restore
#line 51 "C:\Users\Acer\source\repos\Zeno\ZenoProjectManager\Client\Pages\Report\CompanyReportView.razor"
                                                                                        reportRequest.EndDate.Date

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(70, "\r\n        ");
            __builder.OpenElement(71, "div");
            __builder.AddAttribute(72, "class", "charts-container mt-5 pb-4");
            __builder.OpenElement(73, "div");
            __builder.AddAttribute(74, "class", "chart-container");
            __builder.AddAttribute(75, "style", "width: 100%; display: flex; align-items: flex-start; margin-left: -50px;");
            __builder.OpenComponent<ChartJs.Blazor.Chart>(76);
            __builder.AddAttribute(77, "Config", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<ChartJs.Blazor.Common.ConfigBase>(
#nullable restore
#line 54 "C:\Users\Acer\source\repos\Zeno\ZenoProjectManager\Client\Pages\Report\CompanyReportView.razor"
                               _ticketPieConfig

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(78, "\r\n\r\n\r\n            ");
            __builder.OpenElement(79, "div");
            __builder.AddAttribute(80, "class", "chart-container");
            __builder.AddAttribute(81, "style", "width:100%; display: flex; align-items: flex-start; margin-left: -50px;");
            __builder.OpenComponent<ChartJs.Blazor.Chart>(82);
            __builder.AddAttribute(83, "Config", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<ChartJs.Blazor.Common.ConfigBase>(
#nullable restore
#line 59 "C:\Users\Acer\source\repos\Zeno\ZenoProjectManager\Client\Pages\Report\CompanyReportView.razor"
                               _projectPieConfig

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 62 "C:\Users\Acer\source\repos\Zeno\ZenoProjectManager\Client\Pages\Report\CompanyReportView.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 65 "C:\Users\Acer\source\repos\Zeno\ZenoProjectManager\Client\Pages\Report\CompanyReportView.razor"
       

    [Inject]
    private IReportService _reportService { get; set; }
    [Inject]
    private ICompanyService _companyService { get; set; }

    [Parameter]
    public Guid CompanyId { get; set; }

    

#line default
#line hidden
#nullable disable
#nullable restore
#line 76 "C:\Users\Acer\source\repos\Zeno\ZenoProjectManager\Client\Pages\Report\CompanyReportView.razor"
    private PieConfig _ticketPieConfig { get; set; } = new PieConfig();
    private PieConfig _projectPieConfig { get; set; } = new PieConfig();

    private bool fetched = false;
    private List<int> ticketStats;
    private List<int> projectStats;
    private IEnumerable<Project> completedProjects = Enumerable.Empty<Project>();
    private IEnumerable<Project> inprogressProjects = Enumerable.Empty<Project>();
    private IEnumerable<Ticket> completedTickets = Enumerable.Empty<Ticket>();
    private IEnumerable<Ticket> todoTickets = Enumerable.Empty<Ticket>();
    private IEnumerable<Ticket> inProgressTickets = Enumerable.Empty<Ticket>();
    private ReportRequest reportRequest { get; set; } = new ReportRequest();
    private PieDataset<int> ticketPieData { get; set; } = new PieDataset<int>();
    private PieDataset<int> projectPieData { get; set; } = new PieDataset<int>();
    private int totalTickets { get; set; }
    private int totalProjects { get; set; }


    protected async override Task OnInitializedAsync()
    {
        /*
            Initialize the charts with status upto the current data from the creation date of the company.
        */
        // get the created date of the company.
        Company company = await _companyService.GetCompanyById(CompanyId);
        reportRequest.StartDate = company.CreatedDate;
        reportRequest.EndDate = DateTime.Now;

        ticketStats = await GetTicketStats(reportRequest.StartDate, reportRequest.EndDate);
        projectStats = await GetProjectStats(reportRequest.StartDate, reportRequest.EndDate);
        totalTickets = getTotalTickets(ticketStats);
        totalProjects = getTotalProjects(projectStats);

        var backgroundColors = new[] { ColorUtil.ColorString(54, 162, 235, 0.6), ColorUtil.ColorString(75, 192, 192, 0.6), ColorUtil.ColorString(153, 102, 255, 0.6) };
        ticketPieData = new PieDataset<int>(new[] { ticketStats[0], ticketStats[1], ticketStats[2] }) { BackgroundColor = backgroundColors };

        var backgroundColorsProject = new[] { ColorUtil.ColorString(54, 162, 235, 0.6), ColorUtil.ColorString(75, 192, 192, 0.6) };
        projectPieData = new PieDataset<int>(new[] { projectStats[0], projectStats[1] }) { BackgroundColor = backgroundColors };

        // set data to tickets charts.
        InitializeTicketPieChart();
        _ticketPieConfig.Data.Datasets.Add(ticketPieData);

        // set data to project charts.
        InitializeProjectsPieChart();
        _projectPieConfig.Data.Datasets.Add(projectPieData);

        fetched = true;
    }

    private int getTotalTickets(List<int> ticketStats)
    {
        int total = 0;
        foreach(var stat in ticketStats)
        {
            total += stat;
        }
        return total;
    }

    private int getTotalProjects(List<int> projectStats)
    {
        int total = 0;
        foreach (var stat in projectStats)
        {
            total += stat;
        }
        return total;
    }

    /*
        return a list of number of todo, in-progress and completed tickets in an array.
    */
    private async Task<List<int>> GetTicketStats(DateTime startDate, DateTime endDate)
    {
        ReportRequest todoRequest = new ReportRequest() { CompanyId = CompanyId, StartDate = startDate, Status = "TODO", EndDate = endDate };
        ReportRequest inProgressRequest = new ReportRequest() { CompanyId = CompanyId, StartDate = startDate, Status = "IN-PROGRESS", EndDate = endDate };
        ReportRequest doneRequest = new ReportRequest() { CompanyId = CompanyId, StartDate = startDate, Status = "DONE", EndDate = endDate };

        todoTickets = await _reportService.GetTicketsByStatusInCompany(todoRequest);
        inProgressTickets = await _reportService.GetTicketsByStatusInCompany(inProgressRequest);
        completedTickets = await _reportService.GetCompletedTicketsInCompany(doneRequest);

        return new List<int>() { todoTickets.Count(), inProgressTickets.Count(), completedTickets.Count() };
    }

    /*
        return a list of number of in-progress and completed projects in an array.
    */
    private async Task<List<int>> GetProjectStats(DateTime startDate, DateTime endDate)
    {
        ReportRequest inProgressRequest = new ReportRequest() { CompanyId = CompanyId, StartDate = startDate, EndDate = endDate };
        ReportRequest inCompletedRequest = new ReportRequest() { CompanyId = CompanyId, StartDate = startDate, EndDate = endDate };

        inprogressProjects = await _reportService.GetInProgressProjects(inProgressRequest);
        completedProjects = await _reportService.GetCompletedProjects(inCompletedRequest);

        return new List<int>() { inprogressProjects.Count(),  completedProjects.Count() };
    }

    private void InitializeTicketPieChart()
    {
        _ticketPieConfig = new PieConfig();
        _ticketPieConfig.Options = new PieOptions
        {
            Animation = new ArcAnimation() { AnimateRotate = true, AnimateScale = true },
            Responsive = true,
            Legend = new Legend
            {
                Position = Position.Top
            },
            Title = new OptionsTitle
            {
                Display = true,
                Text = "Ticket Status"
            }
        };

        // Set Up lables.
        foreach (var party in new[] { $"Todo", "In-Progress", "Done" })
        {
            _ticketPieConfig.Data.Labels.Add(party);
        }
    }

    private void InitializeProjectsPieChart()
    {
        _projectPieConfig = new PieConfig();
        _projectPieConfig.Options = new PieOptions
        {
            Animation = new ArcAnimation() { AnimateRotate = true, AnimateScale = true },
            Responsive = true,
            Legend = new Legend
            {
                Position = Position.Top
            },
            Title = new OptionsTitle
            {
                Display = true,
                Text = "Project Status"
            }
        };

        // Set Up lables.
        foreach (var party in new[] { "In-Progress", "Completed" })
        {
            _projectPieConfig.Data.Labels.Add(party);
        }
    }


    private async Task HandleCreateForm()
    {
        var previousTicketData = ticketPieData;
        var previousProjectData = projectPieData;
        ticketStats = await GetTicketStats(reportRequest.StartDate, reportRequest.EndDate);
        projectStats = await GetProjectStats(reportRequest.StartDate, reportRequest.EndDate);

        // set updated ticket data.
        var backgroundTicketsPieColors = new[] { ColorUtil.ColorString(54, 162, 235, 0.6), ColorUtil.ColorString(75, 192, 192, 0.6), ColorUtil.ColorString(153, 102, 255, 0.6) };
        ticketPieData = new PieDataset<int>(new[] { ticketStats[0], ticketStats[1], ticketStats[2] }) { BackgroundColor = backgroundTicketsPieColors };
        _ticketPieConfig.Data.Datasets.Remove(previousTicketData);
        _ticketPieConfig.Data.Datasets.Add(ticketPieData);

        //setup project data.
        var backgroundProjectPieColors = new[] { ColorUtil.ColorString(54, 162, 235, 0.6), ColorUtil.ColorString(75, 192, 192, 0.6) };
        projectPieData = new PieDataset<int>(new[] { projectStats[0], projectStats[1] }) { BackgroundColor = backgroundProjectPieColors };
        _projectPieConfig.Data.Datasets.Remove(previousProjectData);
        _projectPieConfig.Data.Datasets.Add(projectPieData);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager _navigationManager { get; set; }
    }
}
namespace __Blazor.ZenoProjectManager.Client.Pages.Report.CompanyReportView
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
        public static void CreateInputDate_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, System.Object __arg1, int __seq2, System.Object __arg2, int __seq3, System.Object __arg3, int __seq4, TValue __arg4, int __seq5, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg5, int __seq6, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg6)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputDate<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", __arg0);
        __builder.AddAttribute(__seq1, "id", __arg1);
        __builder.AddAttribute(__seq2, "style", __arg2);
        __builder.AddAttribute(__seq3, "rows", __arg3);
        __builder.AddAttribute(__seq4, "Value", __arg4);
        __builder.AddAttribute(__seq5, "ValueChanged", __arg5);
        __builder.AddAttribute(__seq6, "ValueExpression", __arg6);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
