#pragma checksum "C:\Users\Acer\source\repos\Zeno\ZenoProjectManager\Client\Pages\Ticket\TicketEditView.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d496be55ab9e11851b9048881ac175a66cc60c18"
// <auto-generated/>
#pragma warning disable 1591
namespace ZenoProjectManager.Client.Pages.Ticket
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
#line 2 "C:\Users\Acer\source\repos\Zeno\ZenoProjectManager\Client\Pages\Ticket\TicketEditView.razor"
           [Authorize(Roles = "admin, user")]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/tickets/{ProjectId:guid}/ticket/{TicketId:guid}/edit")]
    public partial class TicketEditView : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<ZenoProjectManager.Client.Shared.SideNavProject>(0);
            __builder.AddAttribute(1, "ProjectId", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Guid>(
#nullable restore
#line 5 "C:\Users\Acer\source\repos\Zeno\ZenoProjectManager\Client\Pages\Ticket\TicketEditView.razor"
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
            __builder.OpenElement(6, "h3");
            __builder.AddAttribute(7, "class", "mb-4");
            __builder.AddContent(8, 
#nullable restore
#line 7 "C:\Users\Acer\source\repos\Zeno\ZenoProjectManager\Client\Pages\Ticket\TicketEditView.razor"
                      ticketTitle

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(9, "\r\n    ");
            __builder.OpenElement(10, "div");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(11);
            __builder.AddAttribute(12, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 9 "C:\Users\Acer\source\repos\Zeno\ZenoProjectManager\Client\Pages\Ticket\TicketEditView.razor"
                         editedTicket

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(13, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 9 "C:\Users\Acer\source\repos\Zeno\ZenoProjectManager\Client\Pages\Ticket\TicketEditView.razor"
                                                      HandleValidSubmit

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(14, "class", "form");
            __builder.AddAttribute(15, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(16);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(17, "\r\n\r\n            ");
                __builder2.OpenElement(18, "divs");
                __builder2.AddAttribute(19, "class", "mb-4 form-group");
                __builder2.AddMarkupContent(20, "<label for=\"ticketName\" class=\"custom-label\">Ticket Name</label>\r\n                ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(21);
                __builder2.AddAttribute(22, "class", "form-control mb-2");
                __builder2.AddAttribute(23, "id", "ticketName");
                __builder2.AddAttribute(24, "disabled", 
#nullable restore
#line 14 "C:\Users\Acer\source\repos\Zeno\ZenoProjectManager\Client\Pages\Ticket\TicketEditView.razor"
                                                                                                                      IsDisabled

#line default
#line hidden
#nullable disable
                );
                __builder2.AddAttribute(25, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 14 "C:\Users\Acer\source\repos\Zeno\ZenoProjectManager\Client\Pages\Ticket\TicketEditView.razor"
                                        editedTicket.TicketName

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(26, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => editedTicket.TicketName = __value, editedTicket.TicketName))));
                __builder2.AddAttribute(27, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => editedTicket.TicketName));
                __builder2.AddAttribute(28, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(29, "Ticket Name");
                }
                ));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(30, "\r\n\r\n            ");
                __builder2.OpenElement(31, "div");
                __builder2.AddAttribute(32, "class", "mb-4 form-group");
                __builder2.AddMarkupContent(33, "<label for=\"ticketDescription\" class=\"custom-label\">Ticket Description</label>\r\n                ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputTextArea>(34);
                __builder2.AddAttribute(35, "class", "form-control");
                __builder2.AddAttribute(36, "id", "ticketDescription");
                __builder2.AddAttribute(37, "style", "margin-top: -1px;");
                __builder2.AddAttribute(38, "rows", "4");
                __builder2.AddAttribute(39, "disabled", 
#nullable restore
#line 19 "C:\Users\Acer\source\repos\Zeno\ZenoProjectManager\Client\Pages\Ticket\TicketEditView.razor"
                                                                                                                                                                 IsDisabled

#line default
#line hidden
#nullable disable
                );
                __builder2.AddAttribute(40, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 19 "C:\Users\Acer\source\repos\Zeno\ZenoProjectManager\Client\Pages\Ticket\TicketEditView.razor"
                                                                                                                   editedTicket.Description

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(41, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => editedTicket.Description = __value, editedTicket.Description))));
                __builder2.AddAttribute(42, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => editedTicket.Description));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(43, "\r\n\r\n            ");
                __builder2.OpenElement(44, "div");
                __builder2.AddAttribute(45, "class", "mb-4 form-group");
                __builder2.AddMarkupContent(46, "<label for=\"storyPoints\" class=\"form-label\">Story Points</label>\r\n                ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(47);
                __builder2.AddAttribute(48, "class", "form-control");
                __builder2.AddAttribute(49, "id", "storyPoints");
                __builder2.AddAttribute(50, "disabled", 
#nullable restore
#line 24 "C:\Users\Acer\source\repos\Zeno\ZenoProjectManager\Client\Pages\Ticket\TicketEditView.razor"
                                                                                                      IsDisabled

#line default
#line hidden
#nullable disable
                );
                __builder2.AddAttribute(51, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 24 "C:\Users\Acer\source\repos\Zeno\ZenoProjectManager\Client\Pages\Ticket\TicketEditView.razor"
                                        storyPoints

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(52, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => storyPoints = __value, storyPoints))));
                __builder2.AddAttribute(53, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => storyPoints));
                __builder2.AddAttribute(54, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(55, "Story Points");
                }
                ));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(56, "\r\n\r\n            ");
                __builder2.OpenElement(57, "div");
                __builder2.AddAttribute(58, "class", "mb-4 form-group");
                __builder2.AddMarkupContent(59, "<label for=\"type\" class=\"form-label\">Type</label>\r\n                ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(60);
                __builder2.AddAttribute(61, "type", "text");
                __builder2.AddAttribute(62, "class", "form-control");
                __builder2.AddAttribute(63, "id", "type");
                __builder2.AddAttribute(64, "disabled", 
#nullable restore
#line 29 "C:\Users\Acer\source\repos\Zeno\ZenoProjectManager\Client\Pages\Ticket\TicketEditView.razor"
                                                                                                                 IsDisabled

#line default
#line hidden
#nullable disable
                );
                __builder2.AddAttribute(65, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 29 "C:\Users\Acer\source\repos\Zeno\ZenoProjectManager\Client\Pages\Ticket\TicketEditView.razor"
                                        editedTicket.Type

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(66, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => editedTicket.Type = __value, editedTicket.Type))));
                __builder2.AddAttribute(67, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => editedTicket.Type));
                __builder2.AddAttribute(68, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(69, "Type");
                }
                ));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(70, "\r\n\r\n            ");
                __builder2.OpenElement(71, "div");
                __builder2.AddAttribute(72, "class", "mb-4 form-group");
                __builder2.AddMarkupContent(73, "<label for=\"users\" class=\"form-label\">Assignee</label>\r\n                ");
                __Blazor.ZenoProjectManager.Client.Pages.Ticket.TicketEditView.TypeInference.CreateInputSelect_0(__builder2, 74, 75, "users", 76, "form-select", 77, 
#nullable restore
#line 34 "C:\Users\Acer\source\repos\Zeno\ZenoProjectManager\Client\Pages\Ticket\TicketEditView.razor"
                                                                                            IsDisabled

#line default
#line hidden
#nullable disable
                , 78, 
#nullable restore
#line 34 "C:\Users\Acer\source\repos\Zeno\ZenoProjectManager\Client\Pages\Ticket\TicketEditView.razor"
                                                     userId

#line default
#line hidden
#nullable disable
                , 79, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => userId = __value, userId)), 80, () => userId, 81, (__builder3) => {
                    __builder3.AddMarkupContent(82, "<option value selected disabled>Unassigned</option>");
#nullable restore
#line 36 "C:\Users\Acer\source\repos\Zeno\ZenoProjectManager\Client\Pages\Ticket\TicketEditView.razor"
                     foreach (var user in Users)
                    {

#line default
#line hidden
#nullable disable
                    __builder3.OpenElement(83, "option");
                    __builder3.AddAttribute(84, "value", 
#nullable restore
#line 38 "C:\Users\Acer\source\repos\Zeno\ZenoProjectManager\Client\Pages\Ticket\TicketEditView.razor"
                                        user.Id

#line default
#line hidden
#nullable disable
                    );
                    __builder3.AddContent(85, 
#nullable restore
#line 38 "C:\Users\Acer\source\repos\Zeno\ZenoProjectManager\Client\Pages\Ticket\TicketEditView.razor"
                                                  user.Email

#line default
#line hidden
#nullable disable
                    );
                    __builder3.CloseElement();
#nullable restore
#line 39 "C:\Users\Acer\source\repos\Zeno\ZenoProjectManager\Client\Pages\Ticket\TicketEditView.razor"
                    }

#line default
#line hidden
#nullable disable
                }
                );
                __builder2.CloseElement();
#nullable restore
#line 44 "C:\Users\Acer\source\repos\Zeno\ZenoProjectManager\Client\Pages\Ticket\TicketEditView.razor"
             if (IsDisabled)
            {

#line default
#line hidden
#nullable disable
                __builder2.OpenElement(86, "button");
                __builder2.AddAttribute(87, "class", "btn btn-success");
                __builder2.AddAttribute(88, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 46 "C:\Users\Acer\source\repos\Zeno\ZenoProjectManager\Client\Pages\Ticket\TicketEditView.razor"
                                                          activateForm

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddContent(89, "Edit");
                __builder2.CloseElement();
#nullable restore
#line 47 "C:\Users\Acer\source\repos\Zeno\ZenoProjectManager\Client\Pages\Ticket\TicketEditView.razor"
            }
            else
            {

#line default
#line hidden
#nullable disable
                __builder2.AddMarkupContent(90, "<button type=\"submit\" class=\"btn btn-success mr-3\">Save Changes</button>");
#nullable restore
#line 51 "C:\Users\Acer\source\repos\Zeno\ZenoProjectManager\Client\Pages\Ticket\TicketEditView.razor"
            }

#line default
#line hidden
#nullable disable
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 59 "C:\Users\Acer\source\repos\Zeno\ZenoProjectManager\Client\Pages\Ticket\TicketEditView.razor"

    [Inject]
    private ITicketService _ticketService { get; set; }
    [Inject]
    private IProjectUserService _projectUserService { get; set; }
    [Parameter]
    public Guid TicketId { get; set; }
    [Parameter]
    public Guid ProjectId { get; set; }

    private Ticket editedTicket { get; set; } = new Ticket();
    private string ticketTitle { get; set; }
    private string storyPoints { get; set; }
    private string userId { get; set; }
    private bool IsDisabled { get; set; } = true;
    private Guid CompanyId { get; set; }
    private List<User> Users { get; set; } = new List<User>();

    protected async override Task OnInitializedAsync()
    {
        editedTicket = await _ticketService.GetTicketById(TicketId);
        Users = (await _projectUserService.GetUsersInProject(ProjectId)).ToList();
        userId = editedTicket.UserId.ToString();
        ticketTitle = editedTicket.TicketName;
        storyPoints = editedTicket.StoryPoints.ToString();
    }

    private async Task HandleValidSubmit()
    {
        editedTicket.ProjectId = ProjectId;

        if (userId != string.Empty)
        {
            editedTicket.UserId = Guid.Parse(userId);
        }

        if (storyPoints != null)
        {
            int StoryPointsint;
            bool isNumber = int.TryParse(storyPoints, out StoryPointsint);
            if (!isNumber)
            {
                editedTicket.StoryPoints = 0;
            }
            else
            {
                editedTicket.StoryPoints = StoryPointsint;
            }
        }

        var updated = await _ticketService.UpdateTicket(editedTicket);
        if (updated == null)
        {
            editedTicket = await _ticketService.GetTicketById(TicketId);
            toastService.ShowError("Ticket name has already been taken.");
        }
        else
        {
            ticketTitle = updated.TicketName;
            toastService.ShowSuccess("Your changes have been recorded!");
            IsDisabled = true;
        }
    }

    public void activateForm()
    {
        IsDisabled = false;
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager _navigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IToastService toastService { get; set; }
    }
}
namespace __Blazor.ZenoProjectManager.Client.Pages.Ticket.TicketEditView
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateInputSelect_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, System.Object __arg1, int __seq2, System.Object __arg2, int __seq3, TValue __arg3, int __seq4, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg4, int __seq5, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg5, int __seq6, global::Microsoft.AspNetCore.Components.RenderFragment __arg6)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputSelect<TValue>>(seq);
        __builder.AddAttribute(__seq0, "id", __arg0);
        __builder.AddAttribute(__seq1, "class", __arg1);
        __builder.AddAttribute(__seq2, "disabled", __arg2);
        __builder.AddAttribute(__seq3, "Value", __arg3);
        __builder.AddAttribute(__seq4, "ValueChanged", __arg4);
        __builder.AddAttribute(__seq5, "ValueExpression", __arg5);
        __builder.AddAttribute(__seq6, "ChildContent", __arg6);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
