#pragma checksum "C:\Users\a.sapotko\source\repos\UserBookedApartments\UserBookedApartments\Views\Page\PageEditor.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b9e98e77c70ff6aa4c869124f0318baf8c853b5a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Page_PageEditor), @"mvc.1.0.view", @"/Views/Page/PageEditor.cshtml")]
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
#line 1 "C:\Users\a.sapotko\source\repos\UserBookedApartments\UserBookedApartments\Views\_ViewImports.cshtml"
using UserBookedApartments;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\a.sapotko\source\repos\UserBookedApartments\UserBookedApartments\Views\_ViewImports.cshtml"
using UserBookedApartments.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\a.sapotko\source\repos\UserBookedApartments\UserBookedApartments\Views\Page\PageEditor.cshtml"
using PresentationLayer.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b9e98e77c70ff6aa4c869124f0318baf8c853b5a", @"/Views/Page/PageEditor.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"00a56197229b7ad9094f37b5c775b74722fd7258", @"/Views/_ViewImports.cshtml")]
    public class Views_Page_PageEditor : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PageEditModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/Page/SaveApartment"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/Page/SaveUser"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\Users\a.sapotko\source\repos\UserBookedApartments\UserBookedApartments\Views\Page\PageEditor.cshtml"
 if (Model is ApartmentsEditModel)
{
    var currentModel = (ApartmentsEditModel)Model;

#line default
#line hidden
#nullable disable
            WriteLiteral("    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b9e98e77c70ff6aa4c869124f0318baf8c853b5a4857", async() => {
                WriteLiteral("\r\n        <input name=\"Id\" type=\"hidden\"");
                BeginWriteAttribute("value", " value=\"", 242, "\"", 266, 1);
#nullable restore
#line 8 "C:\Users\a.sapotko\source\repos\UserBookedApartments\UserBookedApartments\Views\Page\PageEditor.cshtml"
WriteAttributeValue("", 250, currentModel.Id, 250, 16, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n        <table>\r\n            <tr>\r\n                <th>\r\n                    ");
#nullable restore
#line 12 "C:\Users\a.sapotko\source\repos\UserBookedApartments\UserBookedApartments\Views\Page\PageEditor.cshtml"
               Write(Html.DisplayNameFor(model => currentModel.Address));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 15 "C:\Users\a.sapotko\source\repos\UserBookedApartments\UserBookedApartments\Views\Page\PageEditor.cshtml"
               Write(Html.DisplayNameFor(model => currentModel.Area));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 18 "C:\Users\a.sapotko\source\repos\UserBookedApartments\UserBookedApartments\Views\Page\PageEditor.cshtml"
               Write(Html.DisplayNameFor(model => currentModel.Rooms));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 21 "C:\Users\a.sapotko\source\repos\UserBookedApartments\UserBookedApartments\Views\Page\PageEditor.cshtml"
               Write(Html.DisplayNameFor(model => currentModel.MaxGuets));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 24 "C:\Users\a.sapotko\source\repos\UserBookedApartments\UserBookedApartments\Views\Page\PageEditor.cshtml"
               Write(Html.DisplayNameFor(model => currentModel.Cost));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </th>\r\n            </tr>\r\n            <tr>\r\n                <td>\r\n                    <input name=\"Address\"");
                BeginWriteAttribute("value", " value=\"", 990, "\"", 1019, 1);
#nullable restore
#line 29 "C:\Users\a.sapotko\source\repos\UserBookedApartments\UserBookedApartments\Views\Page\PageEditor.cshtml"
WriteAttributeValue("", 998, currentModel.Address, 998, 21, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                </td>\r\n                <td>\r\n                    <input name=\"Area\"");
                BeginWriteAttribute("value", " value=\"", 1108, "\"", 1134, 1);
#nullable restore
#line 32 "C:\Users\a.sapotko\source\repos\UserBookedApartments\UserBookedApartments\Views\Page\PageEditor.cshtml"
WriteAttributeValue("", 1116, currentModel.Area, 1116, 18, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                </td>\r\n                <td>\r\n                    <input name=\"Rooms\"");
                BeginWriteAttribute("value", " value=\"", 1224, "\"", 1251, 1);
#nullable restore
#line 35 "C:\Users\a.sapotko\source\repos\UserBookedApartments\UserBookedApartments\Views\Page\PageEditor.cshtml"
WriteAttributeValue("", 1232, currentModel.Rooms, 1232, 19, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                </td>\r\n                <td>\r\n                    <input name=\"MaxGuests\"");
                BeginWriteAttribute("value", " value=\"", 1345, "\"", 1375, 1);
#nullable restore
#line 38 "C:\Users\a.sapotko\source\repos\UserBookedApartments\UserBookedApartments\Views\Page\PageEditor.cshtml"
WriteAttributeValue("", 1353, currentModel.MaxGuets, 1353, 22, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                </td>\r\n                <td>\r\n                    <input name=\"Cost\"");
                BeginWriteAttribute("value", " value=\"", 1464, "\"", 1490, 1);
#nullable restore
#line 41 "C:\Users\a.sapotko\source\repos\UserBookedApartments\UserBookedApartments\Views\Page\PageEditor.cshtml"
WriteAttributeValue("", 1472, currentModel.Cost, 1472, 18, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                </td>\r\n                <td>\r\n                    <input type=\"submit\" value=\"Сохранить\"/>\r\n                </td>\r\n            </tr>\r\n        </table>\r\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 49 "C:\Users\a.sapotko\source\repos\UserBookedApartments\UserBookedApartments\Views\Page\PageEditor.cshtml"
}
else if (Model is UsersEditModel)
{
    var currentModel = (UsersEditModel)Model;

#line default
#line hidden
#nullable disable
            WriteLiteral("    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b9e98e77c70ff6aa4c869124f0318baf8c853b5a11720", async() => {
                WriteLiteral("\r\n        <input name=\"Id\" type=\"hidden\"");
                BeginWriteAttribute("value", " value=\"", 1852, "\"", 1876, 1);
#nullable restore
#line 54 "C:\Users\a.sapotko\source\repos\UserBookedApartments\UserBookedApartments\Views\Page\PageEditor.cshtml"
WriteAttributeValue("", 1860, currentModel.Id, 1860, 16, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n        <table>\r\n            <tr>\r\n                <th>\r\n                    ");
#nullable restore
#line 58 "C:\Users\a.sapotko\source\repos\UserBookedApartments\UserBookedApartments\Views\Page\PageEditor.cshtml"
               Write(Html.DisplayNameFor(model => currentModel.Login));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 61 "C:\Users\a.sapotko\source\repos\UserBookedApartments\UserBookedApartments\Views\Page\PageEditor.cshtml"
               Write(Html.DisplayNameFor(model => currentModel.MobilePhone));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </th>\r\n            </tr>\r\n            <tr>\r\n                <td>\r\n                    <input name=\"Login\"");
                BeginWriteAttribute("value", " value=\"", 2253, "\"", 2280, 1);
#nullable restore
#line 66 "C:\Users\a.sapotko\source\repos\UserBookedApartments\UserBookedApartments\Views\Page\PageEditor.cshtml"
WriteAttributeValue("", 2261, currentModel.Login, 2261, 19, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                </td>\r\n                <td>\r\n                    <input name=\"MobilePhone\"");
                BeginWriteAttribute("value", " value=\"", 2376, "\"", 2409, 1);
#nullable restore
#line 69 "C:\Users\a.sapotko\source\repos\UserBookedApartments\UserBookedApartments\Views\Page\PageEditor.cshtml"
WriteAttributeValue("", 2384, currentModel.MobilePhone, 2384, 25, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                </td>\r\n                <td>\r\n                    <input type=\"submit\" />\r\n                </td>\r\n            </tr>\r\n        </table>\r\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 77 "C:\Users\a.sapotko\source\repos\UserBookedApartments\UserBookedApartments\Views\Page\PageEditor.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PageEditModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
