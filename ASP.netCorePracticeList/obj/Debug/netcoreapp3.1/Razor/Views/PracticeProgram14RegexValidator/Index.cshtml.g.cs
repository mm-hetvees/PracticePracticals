#pragma checksum "C:\Users\techbrain\source\repos\ASP.netCorePracticeList\ASP.netCorePracticeList\Views\PracticeProgram14RegexValidator\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b34a2bf1e1636204a169d22d4dde5ad3ade8af46"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_PracticeProgram14RegexValidator_Index), @"mvc.1.0.view", @"/Views/PracticeProgram14RegexValidator/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b34a2bf1e1636204a169d22d4dde5ad3ade8af46", @"/Views/PracticeProgram14RegexValidator/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a5216e7c6fb645b769a7b4433cfd32640105d93e", @"/Views/_ViewImports.cshtml")]
    public class Views_PracticeProgram14RegexValidator_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ASP.netCorePracticeList.Models.RegexValidator>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<h2>Regex Validator</h2>\r\n");
#nullable restore
#line 6 "C:\Users\techbrain\source\repos\ASP.netCorePracticeList\ASP.netCorePracticeList\Views\PracticeProgram14RegexValidator\Index.cshtml"
 using (Html.BeginForm())
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"table-bordered\" style=\"width:500px;padding:10px;\">\r\n        <div class=\"row mt-2\">\r\n            <div class=\"col-md-4\">\r\n                ");
#nullable restore
#line 11 "C:\Users\techbrain\source\repos\ASP.netCorePracticeList\ASP.netCorePracticeList\Views\PracticeProgram14RegexValidator\Index.cshtml"
           Write(Html.Label("Email:"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n            <div class=\"col-md-8\">\r\n                ");
#nullable restore
#line 14 "C:\Users\techbrain\source\repos\ASP.netCorePracticeList\ASP.netCorePracticeList\Views\PracticeProgram14RegexValidator\Index.cshtml"
           Write(Html.TextBoxFor(model => model.Email, htmlAttributes: new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 15 "C:\Users\techbrain\source\repos\ASP.netCorePracticeList\ASP.netCorePracticeList\Views\PracticeProgram14RegexValidator\Index.cshtml"
           Write(Html.ValidationMessageFor(model => model.Email, null, htmlAttributes: new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n        <div class=\"row mt-2\">\r\n            <div class=\"col-md-12 text-center\">\r\n                <input type=\"submit\" value=\"Submit\" class=\"btn btn-primary\" />\r\n            </div>\r\n        </div>\r\n");
#nullable restore
#line 23 "C:\Users\techbrain\source\repos\ASP.netCorePracticeList\ASP.netCorePracticeList\Views\PracticeProgram14RegexValidator\Index.cshtml"
         if (@ViewBag.Email != null)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"row mt-2\">\r\n                <div class=\"col-md-4\">\r\n                    ");
#nullable restore
#line 27 "C:\Users\techbrain\source\repos\ASP.netCorePracticeList\ASP.netCorePracticeList\Views\PracticeProgram14RegexValidator\Index.cshtml"
               Write(Html.Label("Email:"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n                <div class=\"col-md-8\">\r\n                    ");
#nullable restore
#line 30 "C:\Users\techbrain\source\repos\ASP.netCorePracticeList\ASP.netCorePracticeList\Views\PracticeProgram14RegexValidator\Index.cshtml"
               Write(ViewBag.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n");
#nullable restore
#line 33 "C:\Users\techbrain\source\repos\ASP.netCorePracticeList\ASP.netCorePracticeList\Views\PracticeProgram14RegexValidator\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n");
#nullable restore
#line 35 "C:\Users\techbrain\source\repos\ASP.netCorePracticeList\ASP.netCorePracticeList\Views\PracticeProgram14RegexValidator\Index.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ASP.netCorePracticeList.Models.RegexValidator> Html { get; private set; }
    }
}
#pragma warning restore 1591
