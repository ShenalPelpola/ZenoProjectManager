// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
#pragma warning restore 1591
