#pragma checksum "C:\Users\techbrain\source\repos\ASP.netCorePracticeList\ASP.netCorePracticeList\Views\PracticeProgram27EmployeeDepartmentWise\_DisplayDataOnSelectGetData.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dbc4b1ceb194fd59a8baa3071acf28485106798a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_PracticeProgram27EmployeeDepartmentWise__DisplayDataOnSelectGetData), @"mvc.1.0.view", @"/Views/PracticeProgram27EmployeeDepartmentWise/_DisplayDataOnSelectGetData.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\techbrain\source\repos\ASP.netCorePracticeList\ASP.netCorePracticeList\Views\_ViewImports.cshtml"
using ASP.netCorePracticeList;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\techbrain\source\repos\ASP.netCorePracticeList\ASP.netCorePracticeList\Views\_ViewImports.cshtml"
using ASP.netCorePracticeList.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dbc4b1ceb194fd59a8baa3071acf28485106798a", @"/Views/PracticeProgram27EmployeeDepartmentWise/_DisplayDataOnSelectGetData.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a5216e7c6fb645b769a7b4433cfd32640105d93e", @"/Views/_ViewImports.cshtml")]
    public class Views_PracticeProgram27EmployeeDepartmentWise__DisplayDataOnSelectGetData : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ASP.netCorePracticeList.Database.Model.EmployeeDepartmentTableDetails>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<h1>Result</h1>\r\n<div>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 7 "C:\Users\techbrain\source\repos\ASP.netCorePracticeList\ASP.netCorePracticeList\Views\PracticeProgram27EmployeeDepartmentWise\_DisplayDataOnSelectGetData.cshtml"
       Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 10 "C:\Users\techbrain\source\repos\ASP.netCorePracticeList\ASP.netCorePracticeList\Views\PracticeProgram27EmployeeDepartmentWise\_DisplayDataOnSelectGetData.cshtml"
       Write(Html.DisplayFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 13 "C:\Users\techbrain\source\repos\ASP.netCorePracticeList\ASP.netCorePracticeList\Views\PracticeProgram27EmployeeDepartmentWise\_DisplayDataOnSelectGetData.cshtml"
       Write(Html.DisplayNameFor(model => model.Job));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 16 "C:\Users\techbrain\source\repos\ASP.netCorePracticeList\ASP.netCorePracticeList\Views\PracticeProgram27EmployeeDepartmentWise\_DisplayDataOnSelectGetData.cshtml"
       Write(Html.DisplayFor(model => model.Job));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 19 "C:\Users\techbrain\source\repos\ASP.netCorePracticeList\ASP.netCorePracticeList\Views\PracticeProgram27EmployeeDepartmentWise\_DisplayDataOnSelectGetData.cshtml"
       Write(Html.DisplayNameFor(model => model.HireDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n");
#nullable restore
#line 22 "C:\Users\techbrain\source\repos\ASP.netCorePracticeList\ASP.netCorePracticeList\Views\PracticeProgram27EmployeeDepartmentWise\_DisplayDataOnSelectGetData.cshtml"
             if (!string.IsNullOrEmpty(Convert.ToString(Model.HireDate)))
            {
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 24 "C:\Users\techbrain\source\repos\ASP.netCorePracticeList\ASP.netCorePracticeList\Views\PracticeProgram27EmployeeDepartmentWise\_DisplayDataOnSelectGetData.cshtml"
           Write(Convert.ToDateTime(Model.HireDate).ToString("dd-MM-yyyy"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 24 "C:\Users\techbrain\source\repos\ASP.netCorePracticeList\ASP.netCorePracticeList\Views\PracticeProgram27EmployeeDepartmentWise\_DisplayDataOnSelectGetData.cshtml"
                                                                          
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 28 "C:\Users\techbrain\source\repos\ASP.netCorePracticeList\ASP.netCorePracticeList\Views\PracticeProgram27EmployeeDepartmentWise\_DisplayDataOnSelectGetData.cshtml"
       Write(Html.DisplayNameFor(model => model.Salary));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 31 "C:\Users\techbrain\source\repos\ASP.netCorePracticeList\ASP.netCorePracticeList\Views\PracticeProgram27EmployeeDepartmentWise\_DisplayDataOnSelectGetData.cshtml"
       Write(Html.DisplayFor(model => model.Salary));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 34 "C:\Users\techbrain\source\repos\ASP.netCorePracticeList\ASP.netCorePracticeList\Views\PracticeProgram27EmployeeDepartmentWise\_DisplayDataOnSelectGetData.cshtml"
       Write(Html.DisplayNameFor(model => model.Commision));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 37 "C:\Users\techbrain\source\repos\ASP.netCorePracticeList\ASP.netCorePracticeList\Views\PracticeProgram27EmployeeDepartmentWise\_DisplayDataOnSelectGetData.cshtml"
       Write(Html.DisplayFor(model => model.Commision));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 40 "C:\Users\techbrain\source\repos\ASP.netCorePracticeList\ASP.netCorePracticeList\Views\PracticeProgram27EmployeeDepartmentWise\_DisplayDataOnSelectGetData.cshtml"
       Write(Html.DisplayNameFor(model => model.DepartmentName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 43 "C:\Users\techbrain\source\repos\ASP.netCorePracticeList\ASP.netCorePracticeList\Views\PracticeProgram27EmployeeDepartmentWise\_DisplayDataOnSelectGetData.cshtml"
       Write(Html.DisplayFor(model => model.DepartmentName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ASP.netCorePracticeList.Database.Model.EmployeeDepartmentTableDetails> Html { get; private set; }
    }
}
#pragma warning restore 1591
