#pragma checksum "C:\Users\Siraj\source\repos\ETMS-Blazor\ETMS-Blazor\Pages\Dashboard.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d6d3d35c220000dce6e6b24d4efa7458f7ddc4cf"
// <auto-generated/>
#pragma warning disable 1591
namespace ETMS_Blazor.Pages
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/dashboard")]
    public partial class Dashboard : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<div class=\"row\">\r\n    <div class=\"col-md-8\">\r\n        <h5>ETMS : Employee Training Management System</h5>\r\n    </div>\r\n    <div class=\"col-md-4\">\r\n    </div>\r\n</div>\r\n\r\n");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "row");
            __builder.AddMarkupContent(3, "\r\n    ");
            __builder.OpenComponent<ETMS_Blazor.Shared.Status>(4);
            __builder.AddAttribute(5, "number", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 17 "C:\Users\Siraj\source\repos\ETMS-Blazor\ETMS-Blazor\Pages\Dashboard.razor"
                     statusInfo.TotalEmployeeCourses

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(6, "type", "chart-line");
            __builder.AddAttribute(7, "colour", "primary");
            __builder.AddAttribute(8, "comments", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 17 "C:\Users\Siraj\source\repos\ETMS-Blazor\ETMS-Blazor\Pages\Dashboard.razor"
                                                                                                   text1

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(9, "linkto", "listemployees");
            __builder.CloseComponent();
            __builder.AddMarkupContent(10, "\r\n    ");
            __builder.OpenComponent<ETMS_Blazor.Shared.Status>(11);
            __builder.AddAttribute(12, "number", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 18 "C:\Users\Siraj\source\repos\ETMS-Blazor\ETMS-Blazor\Pages\Dashboard.razor"
                     statusInfo.EmployeeAllComplterd

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(13, "type", "smile");
            __builder.AddAttribute(14, "colour", "success");
            __builder.AddAttribute(15, "comments", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 18 "C:\Users\Siraj\source\repos\ETMS-Blazor\ETMS-Blazor\Pages\Dashboard.razor"
                                                                                              text2

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(16, "linkto", "listemployees");
            __builder.CloseComponent();
            __builder.AddMarkupContent(17, "\r\n    ");
            __builder.OpenComponent<ETMS_Blazor.Shared.Status>(18);
            __builder.AddAttribute(19, "number", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 19 "C:\Users\Siraj\source\repos\ETMS-Blazor\ETMS-Blazor\Pages\Dashboard.razor"
                     statusInfo.EmployeeAllNotStarted

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(20, "type", "exclamation-circle");
            __builder.AddAttribute(21, "colour", "danger");
            __builder.AddAttribute(22, "comments", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 19 "C:\Users\Siraj\source\repos\ETMS-Blazor\ETMS-Blazor\Pages\Dashboard.razor"
                                                                                                           text3

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(23, "linkto", "listcourses");
            __builder.CloseComponent();
            __builder.AddMarkupContent(24, "\r\n    ");
            __builder.OpenComponent<ETMS_Blazor.Shared.Status>(25);
            __builder.AddAttribute(26, "number", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 20 "C:\Users\Siraj\source\repos\ETMS-Blazor\ETMS-Blazor\Pages\Dashboard.razor"
                     statusInfo.TotalCourses

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(27, "type", "bicycle");
            __builder.AddAttribute(28, "colour", "warning");
            __builder.AddAttribute(29, "comments", "Courses, 4 courses are assigned to each employee.");
            __builder.AddAttribute(30, "linkto", "listcourses");
            __builder.CloseComponent();
            __builder.AddMarkupContent(31, "\r\n\r\n\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(32, "\r\n<br>\r\n\r\n");
#nullable restore
#line 26 "C:\Users\Siraj\source\repos\ETMS-Blazor\ETMS-Blazor\Pages\Dashboard.razor"
 if (employeesCourseInfoList == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(33, "    ");
            __builder.OpenComponent<ETMS_Blazor.Shared.Loader>(34);
            __builder.CloseComponent();
            __builder.AddMarkupContent(35, "\r\n");
#nullable restore
#line 29 "C:\Users\Siraj\source\repos\ETMS-Blazor\ETMS-Blazor\Pages\Dashboard.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(36, "    ");
            __builder.OpenElement(37, "table");
            __builder.AddAttribute(38, "class", "table table-sm table-bordered table-striped table-hover");
            __builder.AddMarkupContent(39, "\r\n        ");
            __builder.AddMarkupContent(40, @"<thead>
            <tr>
                <th scope=""col"" class=""text-center table-dark"">#</th>
                <th colspan=""2"" class=""text-center table-warning"" scope=""col"">Employee</th>
                <th scope=""col"" class=""text-center table-success"">?</th>
                <th colspan=""2"" class=""text-center table-secondary"" scope=""col"">Training Course</th>
            </tr>
        </thead>
        ");
            __builder.OpenElement(41, "tbody");
            __builder.AddMarkupContent(42, "\r\n");
#nullable restore
#line 43 "C:\Users\Siraj\source\repos\ETMS-Blazor\ETMS-Blazor\Pages\Dashboard.razor"
             foreach (var info in employeesCourseInfoList)
            {
                 string tdClass = $"{(info.isComplete ? "table-success" : "table-danger")}";

#line default
#line hidden
#nullable disable
            __builder.AddContent(43, "            ");
            __builder.OpenElement(44, "tr");
            __builder.AddMarkupContent(45, "\r\n                ");
            __builder.OpenElement(46, "th");
            __builder.AddAttribute(47, "scope", "row");
            __builder.AddAttribute(48, "class", "text-center table-dark");
            __builder.AddMarkupContent(49, "\r\n                    ");
            __builder.OpenElement(50, "span");
            __builder.AddAttribute(51, "class", "badge badge-pill badge-light");
            __builder.AddContent(52, 
#nullable restore
#line 48 "C:\Users\Siraj\source\repos\ETMS-Blazor\ETMS-Blazor\Pages\Dashboard.razor"
                                                                ix

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(53, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(54, "\r\n                ");
            __builder.OpenElement(55, "td");
            __builder.AddAttribute(56, "class", 
#nullable restore
#line 50 "C:\Users\Siraj\source\repos\ETMS-Blazor\ETMS-Blazor\Pages\Dashboard.razor"
                            info.cellCSS

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(57, 
#nullable restore
#line 50 "C:\Users\Siraj\source\repos\ETMS-Blazor\ETMS-Blazor\Pages\Dashboard.razor"
                                           info.Employee.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(58, "\r\n                ");
            __builder.OpenElement(59, "td");
            __builder.AddAttribute(60, "class", 
#nullable restore
#line 51 "C:\Users\Siraj\source\repos\ETMS-Blazor\ETMS-Blazor\Pages\Dashboard.razor"
                            info.cellCSS

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(61, "\r\n                    ");
            __builder.OpenElement(62, "strong");
            __builder.AddContent(63, 
#nullable restore
#line 52 "C:\Users\Siraj\source\repos\ETMS-Blazor\ETMS-Blazor\Pages\Dashboard.razor"
                             info.TotalEmployeeCompleted

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(64, " / ");
            __builder.AddContent(65, 
#nullable restore
#line 52 "C:\Users\Siraj\source\repos\ETMS-Blazor\ETMS-Blazor\Pages\Dashboard.razor"
                                                             info.TotalEmployeeNotStarted+info.TotalEmployeeCompleted

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(66, "\r\n                    &nbsp;\r\n                    ");
            __builder.OpenElement(67, "span");
            __builder.AddAttribute(68, "class", "badge badge-pill badge-warning");
            __builder.AddMarkupContent(69, "\r\n                        ");
            __builder.AddContent(70, 
#nullable restore
#line 55 "C:\Users\Siraj\source\repos\ETMS-Blazor\ETMS-Blazor\Pages\Dashboard.razor"
                         info.PercentEmployeCompleted

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(71, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(72, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(73, "\r\n\r\n                ");
            __builder.OpenElement(74, "td");
            __builder.AddAttribute(75, "class", "text-center" + " " + (
#nullable restore
#line 59 "C:\Users\Siraj\source\repos\ETMS-Blazor\ETMS-Blazor\Pages\Dashboard.razor"
                                        tdClass

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(76, "\r\n");
#nullable restore
#line 60 "C:\Users\Siraj\source\repos\ETMS-Blazor\ETMS-Blazor\Pages\Dashboard.razor"
                     if (info.isComplete)
                    {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(77, "                        <span class=\"oi oi-circle-check\"></span>\r\n");
#nullable restore
#line 63 "C:\Users\Siraj\source\repos\ETMS-Blazor\ETMS-Blazor\Pages\Dashboard.razor"
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(78, "                        <span class=\"oi oi-circle-x\"></span>\r\n");
#nullable restore
#line 67 "C:\Users\Siraj\source\repos\ETMS-Blazor\ETMS-Blazor\Pages\Dashboard.razor"
                    }

#line default
#line hidden
#nullable disable
            __builder.AddContent(79, "                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(80, "\r\n                ");
            __builder.OpenElement(81, "td");
            __builder.AddMarkupContent(82, "\r\n                    ");
            __builder.AddContent(83, 
#nullable restore
#line 70 "C:\Users\Siraj\source\repos\ETMS-Blazor\ETMS-Blazor\Pages\Dashboard.razor"
                     info.Course.Code

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(84, " : ");
            __builder.AddContent(85, 
#nullable restore
#line 70 "C:\Users\Siraj\source\repos\ETMS-Blazor\ETMS-Blazor\Pages\Dashboard.razor"
                                         info.Course.Name

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(86, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(87, "\r\n                ");
            __builder.OpenElement(88, "td");
            __builder.AddMarkupContent(89, "\r\n                    ");
            __builder.OpenElement(90, "strong");
            __builder.AddContent(91, "    ");
            __builder.AddContent(92, 
#nullable restore
#line 73 "C:\Users\Siraj\source\repos\ETMS-Blazor\ETMS-Blazor\Pages\Dashboard.razor"
                                 info.TotalCourseCompleted

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(93, " / ");
            __builder.AddContent(94, 
#nullable restore
#line 73 "C:\Users\Siraj\source\repos\ETMS-Blazor\ETMS-Blazor\Pages\Dashboard.razor"
                                                               info.TotalCourseNotStarted+info.TotalCourseCompleted

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(95, " ");
            __builder.CloseElement();
            __builder.AddMarkupContent(96, "\r\n                    &nbsp;\r\n                    ");
            __builder.OpenElement(97, "span");
            __builder.AddAttribute(98, "class", "badge badge-pill badge-secondary");
            __builder.AddMarkupContent(99, "\r\n                        ");
            __builder.AddContent(100, 
#nullable restore
#line 76 "C:\Users\Siraj\source\repos\ETMS-Blazor\ETMS-Blazor\Pages\Dashboard.razor"
                         info.PercentCourcesCompleted

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(101, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(102, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(103, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(104, "\r\n");
#nullable restore
#line 80 "C:\Users\Siraj\source\repos\ETMS-Blazor\ETMS-Blazor\Pages\Dashboard.razor"
                ix++;
            }

#line default
#line hidden
#nullable disable
            __builder.AddContent(105, "        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(106, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(107, "\r\n");
#nullable restore
#line 84 "C:\Users\Siraj\source\repos\ETMS-Blazor\ETMS-Blazor\Pages\Dashboard.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 3 "C:\Users\Siraj\source\repos\ETMS-Blazor\ETMS-Blazor\Pages\Dashboard.razor"
      
    int ix = 1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 86 "C:\Users\Siraj\source\repos\ETMS-Blazor\ETMS-Blazor\Pages\Dashboard.razor"
       

    string text1;
    string text2;
    string text3;


    List<EmployeeCourseInfo> employeesCourseInfoList;

    StatusInfo statusInfo = new StatusInfo();

    protected override async Task OnInitializedAsync()
    {
        employeesCourseInfoList = await EmployeeCourseService.GetEmployeeCourses();

        statusInfo = EmployeeCourseService.GetStatus();

        text1 = "Courses assigned to " + statusInfo.TotalEmployees + " employees.";

        double perComplete = statusInfo.EmployeeAllComplterd*100/statusInfo.TotalEmployees;

        text2 = "Employees has complted all 4 courses - " + (perComplete/100).ToString("P") +".";

        double perNotStart = statusInfo.EmployeeAllNotStarted*100/statusInfo.TotalEmployees;

        text3 = "Employees has yet not strated - " + (perNotStart/100).ToString("P") + ".";

    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IEmployeeCourseService EmployeeCourseService { get; set; }
    }
}
#pragma warning restore 1591