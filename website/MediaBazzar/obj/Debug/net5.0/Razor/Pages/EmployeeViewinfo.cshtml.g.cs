#pragma checksum "C:\Users\csten\source\repos\MediaBazzar\Pages\EmployeeViewinfo.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "84c429779c69ee3875e16fcd0da6befa63e7fc6a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(MediaBazzar.Pages.Pages_EmployeeViewinfo), @"mvc.1.0.razor-page", @"/Pages/EmployeeViewinfo.cshtml")]
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
#line 1 "C:\Users\csten\source\repos\MediaBazzar\Pages\_ViewImports.cshtml"
using MediaBazzar;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"84c429779c69ee3875e16fcd0da6befa63e7fc6a", @"/Pages/EmployeeViewinfo.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"17501a10c88cb0ed86a29bb7145f1f0900b6a7f5", @"/Pages/_ViewImports.cshtml")]
    public class Pages_EmployeeViewinfo : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("container"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\csten\source\repos\MediaBazzar\Pages\EmployeeViewinfo.cshtml"
  
    Layout = "Employee_Layout";
    ViewData["Title"] = "EmployeeViewinfo";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "84c429779c69ee3875e16fcd0da6befa63e7fc6a3620", async() => {
                WriteLiteral(@"
    <div class=""action"">
        <fieldset>
            <legend>Information:</legend>




            <label for=""fname"">First name:</label><br>
            <input type=""text"" placeholder=""Enter your firstname"" name=""fname"" value=""Peter""><br>

            <label for=""lname"">Last name:</label><br>
            <input type=""text"" placeholder=""Enter your lastname"" name=""lname"" value=""Smith""><br><br>

            <label for=""fname"">Email:</label><br>
            <input type=""text"" id=""email"" name=""email"" value=""PeterSmith@mediabazaar.nl""><br>

            <label for=""Phone"">Phone number:</label><br>
            <input type=""tel"" id=""phone"" name=""phone"" placeholder=""123-45-678"" pattern=""[0-9]{3}-[0-9]{2}-[0-9]{3}""><br><br>


            <label for=""Department"">Department:</label>
            <input type=""text"" placeholder=""Enter your department"" name=""department"" value=""Sale Manager"">

            <label for=""Streetname"">Streetname & Housenumber:</label>
            <input type=""text"" plac");
                WriteLiteral(@"eholder=""address"" name=""streetname"" value=""Mandelapark 1546"" <br><br>

            <label for=""Zipcode"">Zipcode:</label>
            <input type=""text"" id=""address"" name=""Zipcode"" value=""1546AB""<br><br>

            <label for=""Birthday"">Birthday:</label>
            <input type=""date"" id=""birthday"" name=""birthday"" value=""1-01-2000"">

            <input type=""submit"" value=""Submit"">
            <input type=""button"" onclick=""alert('Edit info!')"" value=""Edit"">
            <input type=""button"" onclick=""alert('Cancel!')"" value=""Cancle"">


        </fieldset>
    </div>

");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MediaBazzar.Pages.Shared.EmployeeViewinfoModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<MediaBazzar.Pages.Shared.EmployeeViewinfoModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<MediaBazzar.Pages.Shared.EmployeeViewinfoModel>)PageContext?.ViewData;
        public MediaBazzar.Pages.Shared.EmployeeViewinfoModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
