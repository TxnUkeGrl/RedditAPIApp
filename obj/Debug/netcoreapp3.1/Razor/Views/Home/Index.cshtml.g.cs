#pragma checksum "D:\GCProjects\Labs & HW\Lab27Reddit\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cbc91802de0be5761bd5c23ea8e3bbeee6456a86"
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
#line 1 "D:\GCProjects\Labs & HW\Lab27Reddit\Views\_ViewImports.cshtml"
using Lab27Reddit;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\GCProjects\Labs & HW\Lab27Reddit\Views\_ViewImports.cshtml"
using Lab27Reddit.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cbc91802de0be5761bd5c23ea8e3bbeee6456a86", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b07b8da9f4fab48ebd6267fc682d08c7c93a3de5", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<RedditModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "D:\GCProjects\Labs & HW\Lab27Reddit\Views\Home\Index.cshtml"
 foreach(var post in Model.data.children)
{
   var poster = @post.data;
    

#line default
#line hidden
#nullable disable
            WriteLiteral("<img");
            BeginWriteAttribute("src", " src=\"", 126, "\"", 149, 1);
#nullable restore
#line 7 "D:\GCProjects\Labs & HW\Lab27Reddit\Views\Home\Index.cshtml"
WriteAttributeValue("", 132, poster.thumbnail, 132, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("width", " width=\"", 150, "\"", 181, 1);
#nullable restore
#line 7 "D:\GCProjects\Labs & HW\Lab27Reddit\Views\Home\Index.cshtml"
WriteAttributeValue("", 158, poster.thumbnail_width, 158, 23, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("height", " height=\"", 182, "\"", 215, 1);
#nullable restore
#line 7 "D:\GCProjects\Labs & HW\Lab27Reddit\Views\Home\Index.cshtml"
WriteAttributeValue("", 191, poster.thumbnail_height, 191, 24, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n");
#nullable restore
#line 8 "D:\GCProjects\Labs & HW\Lab27Reddit\Views\Home\Index.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RedditModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
