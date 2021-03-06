#pragma checksum "C:\Users\Tam\source\repos\Assignment10\Assignment10\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2f5e71694d61dbaf6b06d2b6a5ccec8b9509d35a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "C:\Users\Tam\source\repos\Assignment10\Assignment10\Views\_ViewImports.cshtml"
using Assignment10;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Tam\source\repos\Assignment10\Assignment10\Views\_ViewImports.cshtml"
using Assignment10.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Tam\source\repos\Assignment10\Assignment10\Views\_ViewImports.cshtml"
using Assignment10.Models.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2f5e71694d61dbaf6b06d2b6a5ccec8b9509d35a", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f68548891b1daccf6c13a451d68afe2ae4000bd0", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IndexViewModel>
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
        private global::Assignment10.Infrastructure.PaginationTagHelper __Assignment10_Infrastructure_PaginationTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\Tam\source\repos\Assignment10\Assignment10\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "BowlingTeam";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<div>\r\n    <h2>Bowler Contact List</h2>\r\n");
#nullable restore
#line 9 "C:\Users\Tam\source\repos\Assignment10\Assignment10\Views\Home\Index.cshtml"
     if(Model.TeamName != null) 
    { 

#line default
#line hidden
#nullable disable
            WriteLiteral("        <h3>Team: ");
#nullable restore
#line 11 "C:\Users\Tam\source\repos\Assignment10\Assignment10\Views\Home\Index.cshtml"
             Write(Model.TeamName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n");
#nullable restore
#line 12 "C:\Users\Tam\source\repos\Assignment10\Assignment10\Views\Home\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</div>
<div>
    <table class=""table-striped"">
        <thead class=""thead-dark"">
            <tr>
                <th class=""d-md-table-cell"">First Name</th>
                <th class=""d-md-table-cell"">Initial</th>
                <th class=""d-md-table-cell"">Last Name</th>
                <th class=""d-md-table-cell"">Address </th>
                <th class=""d-md-table-cell"">City </th>
                <th class=""d-md-table-cell"">State </th>
                <th class=""d-md-table-cell"">Zip </th>
                <th class=""d-md-table-cell"">Phone Number </th>
            </tr>
        </thead>
        <tbody>
");
#nullable restore
#line 29 "C:\Users\Tam\source\repos\Assignment10\Assignment10\Views\Home\Index.cshtml"
             foreach (Bowlers x in Model.Bowlers)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>");
#nullable restore
#line 32 "C:\Users\Tam\source\repos\Assignment10\Assignment10\Views\Home\Index.cshtml"
               Write(x.BowlerFirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 33 "C:\Users\Tam\source\repos\Assignment10\Assignment10\Views\Home\Index.cshtml"
               Write(x.BowlerMiddleInit);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 34 "C:\Users\Tam\source\repos\Assignment10\Assignment10\Views\Home\Index.cshtml"
               Write(x.BowlerLastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 35 "C:\Users\Tam\source\repos\Assignment10\Assignment10\Views\Home\Index.cshtml"
               Write(x.BowlerAddress);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 36 "C:\Users\Tam\source\repos\Assignment10\Assignment10\Views\Home\Index.cshtml"
               Write(x.BowlerCity);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 37 "C:\Users\Tam\source\repos\Assignment10\Assignment10\Views\Home\Index.cshtml"
               Write(x.BowlerState);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 38 "C:\Users\Tam\source\repos\Assignment10\Assignment10\Views\Home\Index.cshtml"
               Write(x.BowlerZip);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 39 "C:\Users\Tam\source\repos\Assignment10\Assignment10\Views\Home\Index.cshtml"
               Write(x.BowlerPhoneNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            </tr>\r\n");
#nullable restore
#line 41 "C:\Users\Tam\source\repos\Assignment10\Assignment10\Views\Home\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>\r\n</div>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("div", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2f5e71694d61dbaf6b06d2b6a5ccec8b9509d35a7426", async() => {
            }
            );
            __Assignment10_Infrastructure_PaginationTagHelper = CreateTagHelper<global::Assignment10.Infrastructure.PaginationTagHelper>();
            __tagHelperExecutionContext.Add(__Assignment10_Infrastructure_PaginationTagHelper);
#nullable restore
#line 45 "C:\Users\Tam\source\repos\Assignment10\Assignment10\Views\Home\Index.cshtml"
__Assignment10_Infrastructure_PaginationTagHelper.PageInfo = Model.PageNumberingInfo;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("page-info", __Assignment10_Infrastructure_PaginationTagHelper.PageInfo, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            if (__Assignment10_Infrastructure_PaginationTagHelper.KeyValuePairs == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("page-url-teamname", "Assignment10.Infrastructure.PaginationTagHelper", "KeyValuePairs"));
            }
#nullable restore
#line 45 "C:\Users\Tam\source\repos\Assignment10\Assignment10\Views\Home\Index.cshtml"
__Assignment10_Infrastructure_PaginationTagHelper.KeyValuePairs["teamname"] = Model.TeamName;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("page-url-teamname", __Assignment10_Infrastructure_PaginationTagHelper.KeyValuePairs["teamname"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IndexViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
