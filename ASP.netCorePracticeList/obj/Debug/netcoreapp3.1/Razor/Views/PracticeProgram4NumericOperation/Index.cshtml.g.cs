#pragma checksum "C:\Users\techbrain\source\repos\ASP.netCorePracticeList\ASP.netCorePracticeList\Views\PracticeProgram4NumericOperation\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e874526413b6d8da7493f58642d024640b97df32"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_PracticeProgram4NumericOperation_Index), @"mvc.1.0.view", @"/Views/PracticeProgram4NumericOperation/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e874526413b6d8da7493f58642d024640b97df32", @"/Views/PracticeProgram4NumericOperation/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a5216e7c6fb645b769a7b4433cfd32640105d93e", @"/Views/_ViewImports.cshtml")]
    public class Views_PracticeProgram4NumericOperation_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<h1>Numeric Operation</h1>\r\n");
#nullable restore
#line 5 "C:\Users\techbrain\source\repos\ASP.netCorePracticeList\ASP.netCorePracticeList\Views\PracticeProgram4NumericOperation\Index.cshtml"
 using (Html.BeginForm())
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"row\">\r\n        <div class=\"col-2\">\r\n            ");
#nullable restore
#line 9 "C:\Users\techbrain\source\repos\ASP.netCorePracticeList\ASP.netCorePracticeList\Views\PracticeProgram4NumericOperation\Index.cshtml"
       Write(Html.Label("Enter A Number:"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n        <div class=\"col-4\">\r\n            ");
#nullable restore
#line 12 "C:\Users\techbrain\source\repos\ASP.netCorePracticeList\ASP.netCorePracticeList\Views\PracticeProgram4NumericOperation\Index.cshtml"
       Write(Html.TextBox("No",null,null,htmlAttributes:new { @class="form-control",@type="number"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n    <div class=\"row mt-2\">\r\n        <div class=\"col-2\">\r\n            ");
#nullable restore
#line 17 "C:\Users\techbrain\source\repos\ASP.netCorePracticeList\ASP.netCorePracticeList\Views\PracticeProgram4NumericOperation\Index.cshtml"
       Write(Html.Label("Choose:"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n        <div class=\"col-4\">\r\n            <div class=\"row\">\r\n                <div class=\"col\">\r\n                    ");
#nullable restore
#line 22 "C:\Users\techbrain\source\repos\ASP.netCorePracticeList\ASP.netCorePracticeList\Views\PracticeProgram4NumericOperation\Index.cshtml"
               Write(Html.RadioButton("RadioChoice", "Even Or Odd", true));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    ");
#nullable restore
#line 23 "C:\Users\techbrain\source\repos\ASP.netCorePracticeList\ASP.netCorePracticeList\Views\PracticeProgram4NumericOperation\Index.cshtml"
               Write(Html.Label("Even Or Odd", null, htmlAttributes: new { @class = "ml-1" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n            <div class=\"row\">\r\n                <div class=\"col\">\r\n                    ");
#nullable restore
#line 28 "C:\Users\techbrain\source\repos\ASP.netCorePracticeList\ASP.netCorePracticeList\Views\PracticeProgram4NumericOperation\Index.cshtml"
               Write(Html.RadioButton("RadioChoice", "Positive Or Negative"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    ");
#nullable restore
#line 29 "C:\Users\techbrain\source\repos\ASP.netCorePracticeList\ASP.netCorePracticeList\Views\PracticeProgram4NumericOperation\Index.cshtml"
               Write(Html.Label("Positive Or Negative", null, htmlAttributes: new { @class = "ml-1" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n            <div class=\"row\">\r\n                <div class=\"col\">\r\n                    ");
#nullable restore
#line 34 "C:\Users\techbrain\source\repos\ASP.netCorePracticeList\ASP.netCorePracticeList\Views\PracticeProgram4NumericOperation\Index.cshtml"
               Write(Html.RadioButton("RadioChoice", "Square"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    ");
#nullable restore
#line 35 "C:\Users\techbrain\source\repos\ASP.netCorePracticeList\ASP.netCorePracticeList\Views\PracticeProgram4NumericOperation\Index.cshtml"
               Write(Html.Label("Square", null, htmlAttributes: new { @class = "ml-1" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n            <div class=\"row\">\r\n                <div class=\"col\">\r\n                    ");
#nullable restore
#line 40 "C:\Users\techbrain\source\repos\ASP.netCorePracticeList\ASP.netCorePracticeList\Views\PracticeProgram4NumericOperation\Index.cshtml"
               Write(Html.RadioButton("RadioChoice", "Factorial"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    ");
#nullable restore
#line 41 "C:\Users\techbrain\source\repos\ASP.netCorePracticeList\ASP.netCorePracticeList\Views\PracticeProgram4NumericOperation\Index.cshtml"
               Write(Html.Label("Factorial", null, htmlAttributes: new { @class = "ml-1" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div><div class=\"row mt-2\">\r\n        <div class=\"col\">\r\n            <input type=\"submit\" value=\"Click\" class=\"btn btn-primary\" />\r\n        </div>\r\n    </div>\r\n");
#nullable restore
#line 50 "C:\Users\techbrain\source\repos\ASP.netCorePracticeList\ASP.netCorePracticeList\Views\PracticeProgram4NumericOperation\Index.cshtml"
     if (ViewBag.Ans != null)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"row mt-2\">\r\n            <div class=\"col\">\r\n                ");
#nullable restore
#line 54 "C:\Users\techbrain\source\repos\ASP.netCorePracticeList\ASP.netCorePracticeList\Views\PracticeProgram4NumericOperation\Index.cshtml"
           Write(Html.Label("Response : "));

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 54 "C:\Users\techbrain\source\repos\ASP.netCorePracticeList\ASP.netCorePracticeList\Views\PracticeProgram4NumericOperation\Index.cshtml"
                                      Write(ViewBag.Ans);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n");
#nullable restore
#line 57 "C:\Users\techbrain\source\repos\ASP.netCorePracticeList\ASP.netCorePracticeList\Views\PracticeProgram4NumericOperation\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 57 "C:\Users\techbrain\source\repos\ASP.netCorePracticeList\ASP.netCorePracticeList\Views\PracticeProgram4NumericOperation\Index.cshtml"
     
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
