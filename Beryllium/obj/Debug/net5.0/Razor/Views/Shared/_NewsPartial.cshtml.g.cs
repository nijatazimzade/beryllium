#pragma checksum "C:\nijatazimzade\codeacademy\backend\Beryllium\Beryllium\Views\Shared\_NewsPartial.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "70e00aa30133c6f7d7008707c2b899360ba3d19d5368ca0188fa5164ab80f595"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__NewsPartial), @"mvc.1.0.view", @"/Views/Shared/_NewsPartial.cshtml")]
namespace AspNetCore
{
    #line hidden
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Mvc;
    using global::Microsoft.AspNetCore.Mvc.Rendering;
    using global::Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\nijatazimzade\codeacademy\backend\Beryllium\Beryllium\Views\_ViewImports.cshtml"
using Beryllium;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\nijatazimzade\codeacademy\backend\Beryllium\Beryllium\Views\_ViewImports.cshtml"
using Beryllium.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\nijatazimzade\codeacademy\backend\Beryllium\Beryllium\Views\_ViewImports.cshtml"
using Beryllium.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"70e00aa30133c6f7d7008707c2b899360ba3d19d5368ca0188fa5164ab80f595", @"/Views/Shared/_NewsPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"c34394c4d996b0bef937a1b681e2be07ab5cab9ea773c09b1ee481facc8a52e6", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared__NewsPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Post>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\nijatazimzade\codeacademy\backend\Beryllium\Beryllium\Views\Shared\_NewsPartial.cshtml"
 foreach (Post item in Model)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <li>\r\n        <a href=\"#\">\r\n            <span class=\"post-date\">");
#nullable restore
#line 7 "C:\nijatazimzade\codeacademy\backend\Beryllium\Beryllium\Views\Shared\_NewsPartial.cshtml"
                               Write(item.PostDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n            <h3>");
#nullable restore
#line 8 "C:\nijatazimzade\codeacademy\backend\Beryllium\Beryllium\Views\Shared\_NewsPartial.cshtml"
           Write(item.PostTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n            <p>");
#nullable restore
#line 9 "C:\nijatazimzade\codeacademy\backend\Beryllium\Beryllium\Views\Shared\_NewsPartial.cshtml"
          Write(item.PostContent);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        </a>\r\n    </li>\r\n");
#nullable restore
#line 12 "C:\nijatazimzade\codeacademy\backend\Beryllium\Beryllium\Views\Shared\_NewsPartial.cshtml"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Post>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
