#pragma checksum "C:\Users\Acer\source\repos\Zeno\ZenoProjectManager\Client\Pages\ProjectUser\ProjectUserListView.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5f3ce48291151045cb2762f0d6182cc0b578bfe9"
// <auto-generated/>
#pragma warning disable 1591
namespace ZenoProjectManager.Client.Pages.ProjectUser
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
#line 2 "C:\Users\Acer\source\repos\Zeno\ZenoProjectManager\Client\Pages\ProjectUser\ProjectUserListView.razor"
           [Authorize(Roles = "admin")]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/projects/{ProjectId:guid}/users")]
    public partial class ProjectUserListView : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<ZenoProjectManager.Client.Shared.SideNavProject>(0);
            __builder.AddAttribute(1, "ProjectId", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Guid>(
#nullable restore
#line 4 "C:\Users\Acer\source\repos\Zeno\ZenoProjectManager\Client\Pages\ProjectUser\ProjectUserListView.razor"
                            ProjectId

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(2, "\r\n");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "content-container");
            __builder.AddAttribute(5, "id", "content-container");
            __builder.AddMarkupContent(6, "<h3>Users</h3>\r\n\r\n    ");
            __builder.OpenComponent<ZenoProjectManager.Client.Pages.ProjectUser.ProjectUserAddView>(7);
            __builder.AddAttribute(8, "ProjectId", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Guid>(
#nullable restore
#line 8 "C:\Users\Acer\source\repos\Zeno\ZenoProjectManager\Client\Pages\ProjectUser\ProjectUserListView.razor"
                                    ProjectId

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(9, "\r\n\r\n    ");
            __builder.AddMarkupContent(10, "<div class=\"create-button-container\"><button type=\"button\" class=\"btn btn-primary\" data-bs-toggle=\"modal\" data-bs-target=\"#myModal\">\r\n            Add\r\n        </button></div>");
#nullable restore
#line 16 "C:\Users\Acer\source\repos\Zeno\ZenoProjectManager\Client\Pages\ProjectUser\ProjectUserListView.razor"
     if (users == null)
    {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(11, "<img src=\"./images/spinner.gif\" class=\"spinner\" alt=\"Loading...\">");
#nullable restore
#line 19 "C:\Users\Acer\source\repos\Zeno\ZenoProjectManager\Client\Pages\ProjectUser\ProjectUserListView.razor"
    }
    else if (users.Count() == 0)
    {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(12, "<div class=\"not-available\"><p>No users available</p></div>");
#nullable restore
#line 25 "C:\Users\Acer\source\repos\Zeno\ZenoProjectManager\Client\Pages\ProjectUser\ProjectUserListView.razor"
    }
    else
    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(13, "table");
            __builder.AddAttribute(14, "class", "table align-middle mb-0 bg-white");
            __builder.AddMarkupContent(15, "<thead class=\"bg-light\"><tr><th>User</th>\r\n                    <th>Title</th>\r\n                    <th>Role</th>\r\n                    <th></th></tr></thead>\r\n            ");
            __builder.OpenElement(16, "tbody");
#nullable restore
#line 38 "C:\Users\Acer\source\repos\Zeno\ZenoProjectManager\Client\Pages\ProjectUser\ProjectUserListView.razor"
                 foreach (var user in users)
                {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(17, "tr");
            __builder.OpenElement(18, "td");
            __builder.OpenElement(19, "div");
            __builder.AddAttribute(20, "class", "d-flex align-items-center");
            __builder.OpenElement(21, "img");
            __builder.AddAttribute(22, "src", 
#nullable restore
#line 43 "C:\Users\Acer\source\repos\Zeno\ZenoProjectManager\Client\Pages\ProjectUser\ProjectUserListView.razor"
                                           user.Avatar

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(23, "class", "rounded-circle");
            __builder.AddAttribute(24, "alt");
            __builder.AddAttribute(25, "style", "width: 45px; height: 45px");
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\r\n                                ");
            __builder.OpenElement(27, "div");
            __builder.AddAttribute(28, "class", "ms-3");
            __builder.OpenElement(29, "p");
            __builder.AddAttribute(30, "class", "fw-bold mb-1");
            __builder.AddContent(31, 
#nullable restore
#line 46 "C:\Users\Acer\source\repos\Zeno\ZenoProjectManager\Client\Pages\ProjectUser\ProjectUserListView.razor"
                                                             user.FirstName

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(32, " ");
            __builder.AddContent(33, 
#nullable restore
#line 46 "C:\Users\Acer\source\repos\Zeno\ZenoProjectManager\Client\Pages\ProjectUser\ProjectUserListView.razor"
                                                                             user.LastName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(34, "\r\n                                    ");
            __builder.OpenElement(35, "p");
            __builder.AddAttribute(36, "class", "text-muted mb-0");
            __builder.AddContent(37, 
#nullable restore
#line 47 "C:\Users\Acer\source\repos\Zeno\ZenoProjectManager\Client\Pages\ProjectUser\ProjectUserListView.razor"
                                                                user.Email

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(38, "\r\n                        ");
            __builder.OpenElement(39, "td");
            __builder.OpenElement(40, "p");
            __builder.AddAttribute(41, "class", "fw-bold mb-1");
            __builder.AddContent(42, 
#nullable restore
#line 52 "C:\Users\Acer\source\repos\Zeno\ZenoProjectManager\Client\Pages\ProjectUser\ProjectUserListView.razor"
                                                     user.Position

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(43, "\r\n                            ");
            __builder.OpenElement(44, "p");
            __builder.AddAttribute(45, "class", "text-muted mb-0");
            __builder.AddContent(46, 
#nullable restore
#line 53 "C:\Users\Acer\source\repos\Zeno\ZenoProjectManager\Client\Pages\ProjectUser\ProjectUserListView.razor"
                                                        user.Department

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(47, "\r\n                        ");
            __builder.OpenElement(48, "td");
            __builder.OpenElement(49, "span");
            __builder.AddContent(50, 
#nullable restore
#line 56 "C:\Users\Acer\source\repos\Zeno\ZenoProjectManager\Client\Pages\ProjectUser\ProjectUserListView.razor"
                                   user.Role

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(51, "\r\n                        ");
            __builder.OpenElement(52, "td");
            __builder.AddAttribute(53, "style", "text-align:right;");
            __builder.OpenElement(54, "button");
            __builder.AddAttribute(55, "type", "button");
            __builder.AddAttribute(56, "class", "btn btn-outline-danger");
            __builder.AddAttribute(57, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 59 "C:\Users\Acer\source\repos\Zeno\ZenoProjectManager\Client\Pages\ProjectUser\ProjectUserListView.razor"
                                                                                             e => DeleteUser(ProjectId, user.Email)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(58, "\r\n                                Remove User\r\n                            ");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 64 "C:\Users\Acer\source\repos\Zeno\ZenoProjectManager\Client\Pages\ProjectUser\ProjectUserListView.razor"
                }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 67 "C:\Users\Acer\source\repos\Zeno\ZenoProjectManager\Client\Pages\ProjectUser\ProjectUserListView.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 70 "C:\Users\Acer\source\repos\Zeno\ZenoProjectManager\Client\Pages\ProjectUser\ProjectUserListView.razor"
       
    [Inject]
    private IProjectUserService _projectUserService { get; set; }

    [Parameter]
    public Guid ProjectId { get; set; }

    public IEnumerable<User> users { get; set; }

    protected override async Task OnInitializedAsync()
    {
        users = await _projectUserService.GetUsersInProject(ProjectId);
    }

    public async Task DeleteUser(Guid projectId, string email)
    {
        var deleted = await _projectUserService.DeleteUserFromProject(projectId, email);
        users = await _projectUserService.GetUsersInProject(ProjectId);
        StateHasChanged();
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
