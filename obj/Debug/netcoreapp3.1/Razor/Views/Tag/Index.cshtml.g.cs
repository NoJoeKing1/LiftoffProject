#pragma checksum "C:\Users\Joe\Documents\LaunchCode\Project\ParkRec\Views\Tag\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "227e05f0c3843c887f35e1fe6fe67a832454378c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Tag_Index), @"mvc.1.0.view", @"/Views/Tag/Index.cshtml")]
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
#line 1 "C:\Users\Joe\Documents\LaunchCode\Project\ParkRec\Views\_ViewImports.cshtml"
using ParkRec;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Joe\Documents\LaunchCode\Project\ParkRec\Views\_ViewImports.cshtml"
using ParkRec.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"227e05f0c3843c887f35e1fe6fe67a832454378c", @"/Views/Tag/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"70ef5e8c23d8337db16bbe3271603d66040a5506", @"/Views/_ViewImports.cshtml")]
    public class Views_Tag_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<ParkRec.Models.Tag>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<h1>All Park Tags</h1>\r\n\r\n");
#nullable restore
#line 5 "C:\Users\Joe\Documents\LaunchCode\Project\ParkRec\Views\Tag\Index.cshtml"
 if(Model.Count == 0)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <p>No tags yet!</p>\r\n");
#nullable restore
#line 8 "C:\Users\Joe\Documents\LaunchCode\Project\ParkRec\Views\Tag\Index.cshtml"
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <table class=\"table\">\r\n        <tr>\r\n            <th>Id</th>\r\n            <th>TagName</th>\r\n        </tr>\r\n");
#nullable restore
#line 16 "C:\Users\Joe\Documents\LaunchCode\Project\ParkRec\Views\Tag\Index.cshtml"
         foreach(var tag in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>");
#nullable restore
#line 19 "C:\Users\Joe\Documents\LaunchCode\Project\ParkRec\Views\Tag\Index.cshtml"
               Write(tag.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 20 "C:\Users\Joe\Documents\LaunchCode\Project\ParkRec\Views\Tag\Index.cshtml"
               Write(tag.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            </tr>\r\n");
#nullable restore
#line 22 "C:\Users\Joe\Documents\LaunchCode\Project\ParkRec\Views\Tag\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </table>\r\n");
#nullable restore
#line 24 "C:\Users\Joe\Documents\LaunchCode\Project\ParkRec\Views\Tag\Index.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<ParkRec.Models.Tag>> Html { get; private set; }
    }
}
#pragma warning restore 1591
