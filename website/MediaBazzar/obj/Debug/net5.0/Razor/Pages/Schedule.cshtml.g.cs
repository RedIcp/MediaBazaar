#pragma checksum "C:\Users\lars\Desktop\ict\sem2\PROJECT\Project\website\MediaBazzar\Pages\Schedule.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "24aecf5e0c2149e09b828bedf2b5dccc852b8dc0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(MediaBazzar.Pages.Pages_Schedule), @"mvc.1.0.razor-page", @"/Pages/Schedule.cshtml")]
namespace MediaBazzar.Pages
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
#line 1 "C:\Users\lars\Desktop\ict\sem2\PROJECT\Project\website\MediaBazzar\Pages\_ViewImports.cshtml"
using MediaBazzar;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"24aecf5e0c2149e09b828bedf2b5dccc852b8dc0", @"/Pages/Schedule.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"17501a10c88cb0ed86a29bb7145f1f0900b6a7f5", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Schedule : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
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
#nullable restore
#line 3 "C:\Users\lars\Desktop\ict\sem2\PROJECT\Project\website\MediaBazzar\Pages\Schedule.cshtml"
   ViewData["Title"] = "Schedule"; 

#line default
#line hidden
#nullable disable
            WriteLiteral("<style>\r\n</style>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "24aecf5e0c2149e09b828bedf2b5dccc852b8dc03136", async() => {
                WriteLiteral("\r\n    <div class=\"container\">\r\n        <div>\r\n\r\n            <p>  Welcome, ");
#nullable restore
#line 10 "C:\Users\lars\Desktop\ict\sem2\PROJECT\Project\website\MediaBazzar\Pages\Schedule.cshtml"
                     Write(User.Identity.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n\r\n\r\n\r\n            <h2>Employee schedule</h2>\r\n\r\n            <hr />\r\n            <table cellpadding=\"10\" cellspacing=\"10\">\r\n                <tr>\r\n                    <th>Day</th>\r\n                    <th>Shift</th>\r\n                </tr>\r\n");
#nullable restore
#line 22 "C:\Users\lars\Desktop\ict\sem2\PROJECT\Project\website\MediaBazzar\Pages\Schedule.cshtml"
                     foreach (var item in Model.pws)
                    {


#line default
#line hidden
#nullable disable
                WriteLiteral("                    <tr>\r\n                        <td>");
#nullable restore
#line 26 "C:\Users\lars\Desktop\ict\sem2\PROJECT\Project\website\MediaBazzar\Pages\Schedule.cshtml"
                       Write(item.Day);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 27 "C:\Users\lars\Desktop\ict\sem2\PROJECT\Project\website\MediaBazzar\Pages\Schedule.cshtml"
                       Write(item.Shift);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                    </tr>\r\n");
#nullable restore
#line 29 "C:\Users\lars\Desktop\ict\sem2\PROJECT\Project\website\MediaBazzar\Pages\Schedule.cshtml"
                }

#line default
#line hidden
#nullable disable
                WriteLiteral("                </table>\r\n           \r\n            </div>\r\n    </div>\r\n\r\n\r\n");
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
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MediaBazzar.Pages.ScheduleModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<MediaBazzar.Pages.ScheduleModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<MediaBazzar.Pages.ScheduleModel>)PageContext?.ViewData;
        public MediaBazzar.Pages.ScheduleModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
