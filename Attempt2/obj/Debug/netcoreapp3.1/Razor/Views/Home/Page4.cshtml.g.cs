#pragma checksum "C:\Users\cb867\source\repos\Attempt2\Attempt2\Views\Home\Page4.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7330041e1185d057139615b9a0d2c37455ed691a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Page4), @"mvc.1.0.view", @"/Views/Home/Page4.cshtml")]
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
#line 1 "C:\Users\cb867\source\repos\Attempt2\Attempt2\Views\_ViewImports.cshtml"
using Attempt2;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\cb867\source\repos\Attempt2\Attempt2\Views\_ViewImports.cshtml"
using Attempt2.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7330041e1185d057139615b9a0d2c37455ed691a", @"/Views/Home/Page4.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8f945a386947322f3686e0eca543421cf2b93b59", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Page4 : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Attempt2.Models.InfoModel>
    {
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\cb867\source\repos\Attempt2\Attempt2\Views\Home\Page4.cshtml"
  
    ViewData["Title"] = "Page4";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7330041e1185d057139615b9a0d2c37455ed691a3282", async() => {
                WriteLiteral("\r\n    <h1>Page4</h1>\r\n    <br />\r\n    <h1>");
#nullable restore
#line 10 "C:\Users\cb867\source\repos\Attempt2\Attempt2\Views\Home\Page4.cshtml"
   Write(Model.Day);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h1>\r\n    <br />\r\n    <h1>");
#nullable restore
#line 12 "C:\Users\cb867\source\repos\Attempt2\Attempt2\Views\Home\Page4.cshtml"
   Write(Model.FirstName);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h1>\r\n    <br />\r\n    <h1>");
#nullable restore
#line 14 "C:\Users\cb867\source\repos\Attempt2\Attempt2\Views\Home\Page4.cshtml"
   Write(Model.Email);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h1>\r\n    <h1>Is git working?</h1>\r\n    <div>\r\n       \r\n    </div>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Attempt2.Models.InfoModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
