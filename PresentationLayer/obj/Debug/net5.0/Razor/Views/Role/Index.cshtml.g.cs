#pragma checksum "A:\Pro_AspMvc\Crud-Operations-And-User-Manegment-master\Crud-Operations-And-User-Manegment-master\PresentationLayer\Views\Role\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4ff4de4546133984bb6f4b78e7833b79dc3bbbe9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Role_Index), @"mvc.1.0.view", @"/Views/Role/Index.cshtml")]
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
#line 1 "A:\Pro_AspMvc\Crud-Operations-And-User-Manegment-master\Crud-Operations-And-User-Manegment-master\PresentationLayer\Views\_ViewImports.cshtml"
using PresentationLayer;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "A:\Pro_AspMvc\Crud-Operations-And-User-Manegment-master\Crud-Operations-And-User-Manegment-master\PresentationLayer\Views\_ViewImports.cshtml"
using PresentationLayer.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "A:\Pro_AspMvc\Crud-Operations-And-User-Manegment-master\Crud-Operations-And-User-Manegment-master\PresentationLayer\Views\_ViewImports.cshtml"
using DataAccessLayer.Entities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "A:\Pro_AspMvc\Crud-Operations-And-User-Manegment-master\Crud-Operations-And-User-Manegment-master\PresentationLayer\Views\_ViewImports.cshtml"
using BusinessLogicLayer.Interfaces;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "A:\Pro_AspMvc\Crud-Operations-And-User-Manegment-master\Crud-Operations-And-User-Manegment-master\PresentationLayer\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4ff4de4546133984bb6f4b78e7833b79dc3bbbe9", @"/Views/Role/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"80ae358d43fda400006fae926dca90028707cb03", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Role_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<IdentityRole>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("mt-2 btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_ButtonsPartailView", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "A:\Pro_AspMvc\Crud-Operations-And-User-Manegment-master\Crud-Operations-And-User-Manegment-master\PresentationLayer\Views\Role\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<h1>All Users</h1>\n<br />\n<br />\n\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4ff4de4546133984bb6f4b78e7833b79dc3bbbe96114", async() => {
                WriteLiteral(@"
    <div class=""row align-items-center justify-content-center"">
        <div class=""col-8"">
            <input type=""text"" placeholder=""Search By Name"" class=""form-control"" name=""SearchValue"" />
        </div>
        <div class=""col-4"">
            <input type=""submit"" value=""Search"" class=""btn btn-success"" />
        </div>
    </div>
");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4ff4de4546133984bb6f4b78e7833b79dc3bbbe97902", async() => {
                WriteLiteral("<i class=\"fas fa-add\"></i> Create New Department");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n<br />\n\n");
#nullable restore
#line 25 "A:\Pro_AspMvc\Crud-Operations-And-User-Manegment-master\Crud-Operations-And-User-Manegment-master\PresentationLayer\Views\Role\Index.cshtml"
 if(@TempData["Message"]!=null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"alert alert-success my-3\">\n        ");
#nullable restore
#line 28 "A:\Pro_AspMvc\Crud-Operations-And-User-Manegment-master\Crud-Operations-And-User-Manegment-master\PresentationLayer\Views\Role\Index.cshtml"
   Write(TempData["Message"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    </div>\n");
#nullable restore
#line 30 "A:\Pro_AspMvc\Crud-Operations-And-User-Manegment-master\Crud-Operations-And-User-Manegment-master\PresentationLayer\Views\Role\Index.cshtml"

}

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n\n");
#nullable restore
#line 35 "A:\Pro_AspMvc\Crud-Operations-And-User-Manegment-master\Crud-Operations-And-User-Manegment-master\PresentationLayer\Views\Role\Index.cshtml"
 if (Model.Count() > 0)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <table class=\"table mt-4 table-striped table-hover\">\n        <thead>\n            <tr>\n                <th>");
#nullable restore
#line 40 "A:\Pro_AspMvc\Crud-Operations-And-User-Manegment-master\Crud-Operations-And-User-Manegment-master\PresentationLayer\Views\Role\Index.cshtml"
               Write(Html.DisplayNameFor(R=>R.Id ));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\n                <th>");
#nullable restore
#line 41 "A:\Pro_AspMvc\Crud-Operations-And-User-Manegment-master\Crud-Operations-And-User-Manegment-master\PresentationLayer\Views\Role\Index.cshtml"
               Write(Html.DisplayNameFor(R=>R.Name ));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\n                \n                <th>Datails</th>\n                <th>Update</th>\n                <th>Delete</th>\n            </tr>\n        </thead>\n        <tbody>\n");
#nullable restore
#line 49 "A:\Pro_AspMvc\Crud-Operations-And-User-Manegment-master\Crud-Operations-And-User-Manegment-master\PresentationLayer\Views\Role\Index.cshtml"
             foreach (var Role in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\n                    <td>");
#nullable restore
#line 52 "A:\Pro_AspMvc\Crud-Operations-And-User-Manegment-master\Crud-Operations-And-User-Manegment-master\PresentationLayer\Views\Role\Index.cshtml"
                   Write(Role.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                    <td>");
#nullable restore
#line 53 "A:\Pro_AspMvc\Crud-Operations-And-User-Manegment-master\Crud-Operations-And-User-Manegment-master\PresentationLayer\Views\Role\Index.cshtml"
                   Write(Role.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                   \n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "4ff4de4546133984bb6f4b78e7833b79dc3bbbe912314", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
#nullable restore
#line 55 "A:\Pro_AspMvc\Crud-Operations-And-User-Manegment-master\Crud-Operations-And-User-Manegment-master\PresentationLayer\Views\Role\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model = Role.Id;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("model", __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n\n                </tr>\n");
#nullable restore
#line 58 "A:\Pro_AspMvc\Crud-Operations-And-User-Manegment-master\Crud-Operations-And-User-Manegment-master\PresentationLayer\Views\Role\Index.cshtml"

            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\n    </table>\n");
#nullable restore
#line 62 "A:\Pro_AspMvc\Crud-Operations-And-User-Manegment-master\Crud-Operations-And-User-Manegment-master\PresentationLayer\Views\Role\Index.cshtml"
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"mt-5 alert alert-warning\">\n        <h3>There is No Roles</h3>\n    </div>\n");
#nullable restore
#line 68 "A:\Pro_AspMvc\Crud-Operations-And-User-Manegment-master\Crud-Operations-And-User-Manegment-master\PresentationLayer\Views\Role\Index.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<IdentityRole>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
