#pragma checksum "C:\Users\esthe\OneDrive\Bureaublad\TestGit\cbo3-1-soleil-lars-esther-mohammad\website\MediaBazzar\Pages\Schedule.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6d79fa94dfda305246e3afea629d175b214a106b"
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
#line 1 "C:\Users\esthe\OneDrive\Bureaublad\TestGit\cbo3-1-soleil-lars-esther-mohammad\website\MediaBazzar\Pages\_ViewImports.cshtml"
using MediaBazzar;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6d79fa94dfda305246e3afea629d175b214a106b", @"/Pages/Schedule.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"17501a10c88cb0ed86a29bb7145f1f0900b6a7f5", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Schedule : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "week", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "year", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("profile-form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\esthe\OneDrive\Bureaublad\TestGit\cbo3-1-soleil-lars-esther-mohammad\website\MediaBazzar\Pages\Schedule.cshtml"
   ViewData["Title"] = "Schedule"; 

#line default
#line hidden
#nullable disable
            WriteLiteral("<style>\r\n</style>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6d79fa94dfda305246e3afea629d175b214a106b5004", async() => {
                WriteLiteral("\r\n    <div class=\"container\">\r\n        <div>\r\n            <h2>Employee schedule</h2>\r\n\r\n            <hr />\r\n\r\n            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6d79fa94dfda305246e3afea629d175b214a106b5396", async() => {
                    WriteLiteral("\r\n                <div>\r\n                    ");
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("label", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6d79fa94dfda305246e3afea629d175b214a106b5707", async() => {
                        WriteLiteral(" week:");
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper);
#nullable restore
#line 15 "C:\Users\esthe\OneDrive\Bureaublad\TestGit\cbo3-1-soleil-lars-esther-mohammad\website\MediaBazzar\Pages\Schedule.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.week);

#line default
#line hidden
#nullable disable
                    __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    WriteLiteral("\r\n                    ");
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "6d79fa94dfda305246e3afea629d175b214a106b7361", async() => {
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#nullable restore
#line 16 "C:\Users\esthe\OneDrive\Bureaublad\TestGit\cbo3-1-soleil-lars-esther-mohammad\website\MediaBazzar\Pages\Schedule.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.week);

#line default
#line hidden
#nullable disable
                    __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                    __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Name = (string)__tagHelperAttribute_0.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    WriteLiteral("\r\n                </div>\r\n                <div>\r\n                    ");
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("label", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6d79fa94dfda305246e3afea629d175b214a106b9226", async() => {
                        WriteLiteral(" year:");
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper);
#nullable restore
#line 19 "C:\Users\esthe\OneDrive\Bureaublad\TestGit\cbo3-1-soleil-lars-esther-mohammad\website\MediaBazzar\Pages\Schedule.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.year);

#line default
#line hidden
#nullable disable
                    __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    WriteLiteral("\r\n                    ");
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "6d79fa94dfda305246e3afea629d175b214a106b10880", async() => {
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#nullable restore
#line 20 "C:\Users\esthe\OneDrive\Bureaublad\TestGit\cbo3-1-soleil-lars-esther-mohammad\website\MediaBazzar\Pages\Schedule.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.year);

#line default
#line hidden
#nullable disable
                    __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                    __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Name = (string)__tagHelperAttribute_1.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    WriteLiteral("\r\n                </div>\r\n\r\n                <div class=\"button\">\r\n                    <input type=\"submit\" class=\"subtmit-btn\" value=\"Update Profile\">\r\n                </div>\r\n            ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n\r\n            <hr />\r\n\r\n            <table>\r\n                <tr>\r\n                    <th>Days</th>\r\n");
#nullable restore
#line 33 "C:\Users\esthe\OneDrive\Bureaublad\TestGit\cbo3-1-soleil-lars-esther-mohammad\website\MediaBazzar\Pages\Schedule.cshtml"
                     for (int i = 0; i < 3; i++)
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                        <th>\r\n                            ");
#nullable restore
#line 36 "C:\Users\esthe\OneDrive\Bureaublad\TestGit\cbo3-1-soleil-lars-esther-mohammad\website\MediaBazzar\Pages\Schedule.cshtml"
                       Write(Model.Shift.ToString());

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                            <p style=\"visibility:hidden\"> ");
#nullable restore
#line 37 "C:\Users\esthe\OneDrive\Bureaublad\TestGit\cbo3-1-soleil-lars-esther-mohammad\website\MediaBazzar\Pages\Schedule.cshtml"
                                                     Write(Model.ShiftIncrease());

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n                        </th>\r\n");
#nullable restore
#line 39 "C:\Users\esthe\OneDrive\Bureaublad\TestGit\cbo3-1-soleil-lars-esther-mohammad\website\MediaBazzar\Pages\Schedule.cshtml"
                    }

#line default
#line hidden
#nullable disable
                WriteLiteral("                </tr>\r\n");
#nullable restore
#line 41 "C:\Users\esthe\OneDrive\Bureaublad\TestGit\cbo3-1-soleil-lars-esther-mohammad\website\MediaBazzar\Pages\Schedule.cshtml"
                 for (int i = 0; i < 7; i++)
                {

#line default
#line hidden
#nullable disable
                WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
#nullable restore
#line 45 "C:\Users\esthe\OneDrive\Bureaublad\TestGit\cbo3-1-soleil-lars-esther-mohammad\website\MediaBazzar\Pages\Schedule.cshtml"
               Write(Model.Day.ToString());

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </td>\r\n\r\n\r\n");
#nullable restore
#line 49 "C:\Users\esthe\OneDrive\Bureaublad\TestGit\cbo3-1-soleil-lars-esther-mohammad\website\MediaBazzar\Pages\Schedule.cshtml"
                 if (@Model.IsWorkingToday().morning)
                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <td style=\"background-color: green\"> </td>\r\n");
#nullable restore
#line 52 "C:\Users\esthe\OneDrive\Bureaublad\TestGit\cbo3-1-soleil-lars-esther-mohammad\website\MediaBazzar\Pages\Schedule.cshtml"
                }
                else
                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <td style=\"background-color: red\"> </td>\r\n");
#nullable restore
#line 56 "C:\Users\esthe\OneDrive\Bureaublad\TestGit\cbo3-1-soleil-lars-esther-mohammad\website\MediaBazzar\Pages\Schedule.cshtml"
                }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n");
#nullable restore
#line 58 "C:\Users\esthe\OneDrive\Bureaublad\TestGit\cbo3-1-soleil-lars-esther-mohammad\website\MediaBazzar\Pages\Schedule.cshtml"
                 if (@Model.IsWorkingToday().afternoon)
                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <td style=\"background-color: green\"> </td>\r\n");
#nullable restore
#line 61 "C:\Users\esthe\OneDrive\Bureaublad\TestGit\cbo3-1-soleil-lars-esther-mohammad\website\MediaBazzar\Pages\Schedule.cshtml"
                }
                else
                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <td style=\"background-color: red\"> </td>\r\n");
#nullable restore
#line 65 "C:\Users\esthe\OneDrive\Bureaublad\TestGit\cbo3-1-soleil-lars-esther-mohammad\website\MediaBazzar\Pages\Schedule.cshtml"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 66 "C:\Users\esthe\OneDrive\Bureaublad\TestGit\cbo3-1-soleil-lars-esther-mohammad\website\MediaBazzar\Pages\Schedule.cshtml"
                 if (@Model.IsWorkingToday().evening)
                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <td style=\"background-color: green\"> </td>\r\n");
#nullable restore
#line 69 "C:\Users\esthe\OneDrive\Bureaublad\TestGit\cbo3-1-soleil-lars-esther-mohammad\website\MediaBazzar\Pages\Schedule.cshtml"
                }
                else
                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <td style=\"background-color: red\"> </td>\r\n");
#nullable restore
#line 73 "C:\Users\esthe\OneDrive\Bureaublad\TestGit\cbo3-1-soleil-lars-esther-mohammad\website\MediaBazzar\Pages\Schedule.cshtml"
                }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                <p style=\"visibility:hidden\"> ");
#nullable restore
#line 75 "C:\Users\esthe\OneDrive\Bureaublad\TestGit\cbo3-1-soleil-lars-esther-mohammad\website\MediaBazzar\Pages\Schedule.cshtml"
                                         Write(Model.DayIncrease());

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n            </tr>\r\n");
#nullable restore
#line 77 "C:\Users\esthe\OneDrive\Bureaublad\TestGit\cbo3-1-soleil-lars-esther-mohammad\website\MediaBazzar\Pages\Schedule.cshtml"
                }

#line default
#line hidden
#nullable disable
                WriteLiteral("            </table>\r\n        </div>\r\n    </div>\r\n");
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
