#pragma checksum "C:\Users\showm\Desktop\web1\AjaxCore\AjaxCore\Pages\_CourseEnrollmentPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "05d1af817622ba73f9ccbe6fa5bca592d92cb88a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AjaxCore.Pages.Pages__CourseEnrollmentPartial), @"mvc.1.0.view", @"/Pages/_CourseEnrollmentPartial.cshtml")]
namespace AjaxCore.Pages
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
#line 1 "C:\Users\showm\Desktop\web1\AjaxCore\AjaxCore\Pages\_ViewImports.cshtml"
using AjaxCore;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"05d1af817622ba73f9ccbe6fa5bca592d92cb88a", @"/Pages/_CourseEnrollmentPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f641101e07731e5aebb2232574f9aa8bc0f085bb", @"/Pages/_ViewImports.cshtml")]
    #nullable restore
    public class Pages__CourseEnrollmentPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Models.Enrollment>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<table class=\"table\">\r\n    <tr><th>First Name</th><th>Last Name</th><th>StudentId</th><th>CourseNum</th></tr>\r\n");
#nullable restore
#line 5 "C:\Users\showm\Desktop\web1\AjaxCore\AjaxCore\Pages\_CourseEnrollmentPartial.cshtml"
 foreach(var item in Model)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("<tr>\r\n    <td>");
#nullable restore
#line 8 "C:\Users\showm\Desktop\web1\AjaxCore\AjaxCore\Pages\_CourseEnrollmentPartial.cshtml"
   Write(item.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    <td>");
#nullable restore
#line 9 "C:\Users\showm\Desktop\web1\AjaxCore\AjaxCore\Pages\_CourseEnrollmentPartial.cshtml"
   Write(item.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    <td>");
#nullable restore
#line 10 "C:\Users\showm\Desktop\web1\AjaxCore\AjaxCore\Pages\_CourseEnrollmentPartial.cshtml"
   Write(item.StudentId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    <td>");
#nullable restore
#line 11 "C:\Users\showm\Desktop\web1\AjaxCore\AjaxCore\Pages\_CourseEnrollmentPartial.cshtml"
   Write(item.CourseNum);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n</tr>\r\n");
#nullable restore
#line 13 "C:\Users\showm\Desktop\web1\AjaxCore\AjaxCore\Pages\_CourseEnrollmentPartial.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Models.Enrollment>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591