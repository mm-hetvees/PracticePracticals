#pragma checksum "C:\Users\techbrain\source\repos\ASP.netCorePracticeList\ASP.netCorePracticeList\Views\PracticeProgram19PassDataToSecondPage\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8680b78378e3d34f97b4e6ce7c1d6ee2082a1f52"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_PracticeProgram19PassDataToSecondPage_Index), @"mvc.1.0.view", @"/Views/PracticeProgram19PassDataToSecondPage/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8680b78378e3d34f97b4e6ce7c1d6ee2082a1f52", @"/Views/PracticeProgram19PassDataToSecondPage/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a5216e7c6fb645b769a7b4433cfd32640105d93e", @"/Views/_ViewImports.cshtml")]
    public class Views_PracticeProgram19PassDataToSecondPage_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<h2>Pass Data From One Page To Other</h2>\r\n");
#nullable restore
#line 5 "C:\Users\techbrain\source\repos\ASP.netCorePracticeList\ASP.netCorePracticeList\Views\PracticeProgram19PassDataToSecondPage\Index.cshtml"
 using (Html.BeginForm())
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div style=\"padding:10px;width:200px;\" class=\"table-bordered\">\r\n        <div class=\"row\" style=\"padding:10px;\">\r\n            <div class=\"col-md-12\">\r\n                ");
#nullable restore
#line 10 "C:\Users\techbrain\source\repos\ASP.netCorePracticeList\ASP.netCorePracticeList\Views\PracticeProgram19PassDataToSecondPage\Index.cshtml"
           Write(Html.DropDownList("ddlThings", null, htmlAttributes: new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n        <div class=\"row\" style=\"padding:10px;\">\r\n            <div class=\"col-md-12 text-center\">\r\n                ");
#nullable restore
#line 15 "C:\Users\techbrain\source\repos\ASP.netCorePracticeList\ASP.netCorePracticeList\Views\PracticeProgram19PassDataToSecondPage\Index.cshtml"
           Write(Html.CheckBox("chkShowDetails", true));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"Show Full Details
            </div>
        </div>
        <div class=""row"" style=""padding:10px;"">
            <div class=""col-md-12"">
                <input type=""submit"" value=""View Information"" name=""btnAction"" class=""btn btn-primary"" />
            </div>
        </div>
    </div>
");
#nullable restore
#line 24 "C:\Users\techbrain\source\repos\ASP.netCorePracticeList\ASP.netCorePracticeList\Views\PracticeProgram19PassDataToSecondPage\Index.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591