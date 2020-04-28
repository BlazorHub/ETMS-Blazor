#pragma checksum "C:\Users\Siraj\source\repos\ETMS-Blazor\ETMS-Blazor\Pages\Employer\EditEmployee.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cdcb5e8f284d1970dda4d5970c9da4ab8dd790b4"
// <auto-generated/>
#pragma warning disable 1591
namespace ETMS_Blazor.Pages.Employer
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Siraj\source\repos\ETMS-Blazor\ETMS-Blazor\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Siraj\source\repos\ETMS-Blazor\ETMS-Blazor\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Siraj\source\repos\ETMS-Blazor\ETMS-Blazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Siraj\source\repos\ETMS-Blazor\ETMS-Blazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Siraj\source\repos\ETMS-Blazor\ETMS-Blazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Siraj\source\repos\ETMS-Blazor\ETMS-Blazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Siraj\source\repos\ETMS-Blazor\ETMS-Blazor\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Siraj\source\repos\ETMS-Blazor\ETMS-Blazor\_Imports.razor"
using ETMS_Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Siraj\source\repos\ETMS-Blazor\ETMS-Blazor\_Imports.razor"
using ETMS_Blazor.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Siraj\source\repos\ETMS-Blazor\ETMS-Blazor\_Imports.razor"
using ETMS.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Siraj\source\repos\ETMS-Blazor\ETMS-Blazor\_Imports.razor"
using ETMS.Data.Service;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/editemployee/{id}")]
    public partial class EditEmployee : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Edit Employee</h3>\r\n\r\n");
            __builder.OpenElement(1, "form");
            __builder.AddMarkupContent(2, "\r\n    ");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "row");
            __builder.AddMarkupContent(5, "\r\n        ");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "col-md-8");
            __builder.AddMarkupContent(8, "\r\n            ");
            __builder.OpenElement(9, "div");
            __builder.AddAttribute(10, "class", "form-group");
            __builder.AddMarkupContent(11, "\r\n                ");
            __builder.AddMarkupContent(12, "<label for=\"Name\" class=\"control-label\">Name</label>\r\n                ");
            __builder.OpenElement(13, "input");
            __builder.AddAttribute(14, "for", "Name");
            __builder.AddAttribute(15, "class", "form-control");
            __builder.AddAttribute(16, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 12 "C:\Users\Siraj\source\repos\ETMS-Blazor\ETMS-Blazor\Pages\Employer\EditEmployee.razor"
                                                               employee.Name

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(17, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => employee.Name = __value, employee.Name));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\r\n            ");
            __builder.OpenElement(20, "div");
            __builder.AddAttribute(21, "class", "form-group");
            __builder.AddMarkupContent(22, "\r\n                ");
            __builder.AddMarkupContent(23, "<label for=\"Department\" class=\"control-label\">Hire Date</label>\r\n                ");
            __builder.OpenElement(24, "input");
            __builder.AddAttribute(25, "for", "Department");
            __builder.AddAttribute(26, "class", "form-control");
            __builder.AddAttribute(27, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 16 "C:\Users\Siraj\source\repos\ETMS-Blazor\ETMS-Blazor\Pages\Employer\EditEmployee.razor"
                                                                     employee.HireDate

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(28, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => employee.HireDate = __value, employee.HireDate));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(29, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(31, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(32, "\r\n    ");
            __builder.OpenElement(33, "div");
            __builder.AddAttribute(34, "class", "row");
            __builder.AddMarkupContent(35, "\r\n        ");
            __builder.OpenElement(36, "div");
            __builder.AddAttribute(37, "class", "form-group");
            __builder.AddMarkupContent(38, "\r\n            ");
            __builder.OpenElement(39, "input");
            __builder.AddAttribute(40, "type", "button");
            __builder.AddAttribute(41, "class", "btn btn-primary");
            __builder.AddAttribute(42, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 22 "C:\Users\Siraj\source\repos\ETMS-Blazor\ETMS-Blazor\Pages\Employer\EditEmployee.razor"
                                                                    UpdateEmployee

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(43, "value", "Update");
            __builder.CloseElement();
            __builder.AddMarkupContent(44, "\r\n            ");
            __builder.OpenElement(45, "input");
            __builder.AddAttribute(46, "type", "button");
            __builder.AddAttribute(47, "class", "btn");
            __builder.AddAttribute(48, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 23 "C:\Users\Siraj\source\repos\ETMS-Blazor\ETMS-Blazor\Pages\Employer\EditEmployee.razor"
                                                        Cancel

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(49, "value", "Cancel");
            __builder.CloseElement();
            __builder.AddMarkupContent(50, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(51, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(52, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 28 "C:\Users\Siraj\source\repos\ETMS-Blazor\ETMS-Blazor\Pages\Employer\EditEmployee.razor"
       

    [Parameter]
    public string id { get; set; }

    Employee employee = new Employee();

    protected override async Task OnInitializedAsync()
    {
        employee = await EmployeeService.SingleEmployee(id);
    }

    protected async Task UpdateEmployee()
    {
        await EmployeeService.EditEmployee(id, employee);
        NavigationManager.NavigateTo("listemployees");
    }

    void Cancel()
    {
        NavigationManager.NavigateTo("listemployees");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IEmployeeService EmployeeService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
    }
}
#pragma warning restore 1591