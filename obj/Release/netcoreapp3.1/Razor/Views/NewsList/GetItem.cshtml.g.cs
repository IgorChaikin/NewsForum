#pragma checksum "E:\ASP-NET\NewsForum\Views\NewsList\GetItem.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b0a6f716673eb697ac9fbcb2f752c237a6756bf7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_NewsList_GetItem), @"mvc.1.0.view", @"/Views/NewsList/GetItem.cshtml")]
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
#line 1 "E:\ASP-NET\NewsForum\Views\_ViewImports.cshtml"
using NewsForum;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\ASP-NET\NewsForum\Views\_ViewImports.cshtml"
using NewsForum.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "E:\ASP-NET\NewsForum\Views\NewsList\GetItem.cshtml"
using NewsForum.Models.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b0a6f716673eb697ac9fbcb2f752c237a6756bf7", @"/Views/NewsList/GetItem.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c79a803ea000e6cf251cb0bddf7e1c85e0f0ca03", @"/Views/_ViewImports.cshtml")]
    public class Views_NewsList_GetItem : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<GetItemViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("form-id"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "E:\ASP-NET\NewsForum\Views\NewsList\GetItem.cshtml"
  
    ViewBag.Title = Model.News.Title;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!DOCTYPE html>\r\n<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b0a6f716673eb697ac9fbcb2f752c237a6756bf74438", async() => {
                WriteLiteral("\r\n    <meta charset=\"utf-8\" />\r\n    <title></title>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b0a6f716673eb697ac9fbcb2f752c237a6756bf75461", async() => {
                WriteLiteral("\r\n    <h1> ");
#nullable restore
#line 14 "E:\ASP-NET\NewsForum\Views\NewsList\GetItem.cshtml"
    Write(Model.News.Title);

#line default
#line hidden
#nullable disable
                WriteLiteral(" </h1>\r\n    <h3>");
#nullable restore
#line 15 "E:\ASP-NET\NewsForum\Views\NewsList\GetItem.cshtml"
   Write(Model.News.ShortDesc);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h3>\r\n    <img");
                BeginWriteAttribute("src", " src=\"", 288, "\"", 309, 1);
#nullable restore
#line 16 "E:\ASP-NET\NewsForum\Views\NewsList\GetItem.cshtml"
WriteAttributeValue("", 294, Model.News.Img, 294, 15, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n    <div>\r\n        ");
#nullable restore
#line 18 "E:\ASP-NET\NewsForum\Views\NewsList\GetItem.cshtml"
   Write(Model.News.Desc);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    </div>\r\n    <div>\r\n        <h5>\r\n            Автор:\r\n            ");
#nullable restore
#line 23 "E:\ASP-NET\NewsForum\Views\NewsList\GetItem.cshtml"
       Write(Model.News.Author);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        </h5>\r\n    </div>\r\n    <span>");
#nullable restore
#line 26 "E:\ASP-NET\NewsForum\Views\NewsList\GetItem.cshtml"
     Write(Html.ActionLink(Model.News.Category.Title, "GetList", "NewsList", new { id = Model.News.Category.Id }));

#line default
#line hidden
#nullable disable
                WriteLiteral("</span>\r\n");
#nullable restore
#line 27 "E:\ASP-NET\NewsForum\Views\NewsList\GetItem.cshtml"
     if (User.Identity.IsAuthenticated)
    {
        if (User.Identity.Name == Model.News.Author)
        {

#line default
#line hidden
#nullable disable
                WriteLiteral("            <span>\r\n                ");
#nullable restore
#line 32 "E:\ASP-NET\NewsForum\Views\NewsList\GetItem.cshtml"
           Write(Html.ActionLink("Редактировать", "EditForm", "EditNews", new { id = Model.News.Id }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                ");
#nullable restore
#line 33 "E:\ASP-NET\NewsForum\Views\NewsList\GetItem.cshtml"
           Write(Html.ActionLink("Удалить", "DeleteNews", "EditNews", new { id = Model.News.Id }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </span>\r\n");
#nullable restore
#line 35 "E:\ASP-NET\NewsForum\Views\NewsList\GetItem.cshtml"
        }

#line default
#line hidden
#nullable disable
                WriteLiteral("        <h5>\r\n            Оставить комментарий\r\n        </h5>\r\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b0a6f716673eb697ac9fbcb2f752c237a6756bf78506", async() => {
                    WriteLiteral("\r\n            <textarea style=\"width:90%\" name=\"text\" id=\"text-id\">\r\n            </textarea><br />\r\n            <input name=\"date\" type=\"hidden\" id=\"date-id\" />\r\n            <input type=\"submit\" id=\"submit-id\" value=\"Опубликовать\" />\r\n        ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "action", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 39 "E:\ASP-NET\NewsForum\Views\NewsList\GetItem.cshtml"
AddHtmlAttributeValue("", 1053, Url.Action("EditComments", "Comments",  new { newsId = Model.News.Id}), 1053, 73, false);

#line default
#line hidden
#nullable disable
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
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
#line 46 "E:\ASP-NET\NewsForum\Views\NewsList\GetItem.cshtml"
    }

#line default
#line hidden
#nullable disable
                WriteLiteral("    <h5>Комментарии</h5>\r\n    <div id=\"list-id\">\r\n");
#nullable restore
#line 49 "E:\ASP-NET\NewsForum\Views\NewsList\GetItem.cshtml"
         foreach (var item in Model.News.Comments)
        {

#line default
#line hidden
#nullable disable
                WriteLiteral("            <div");
                BeginWriteAttribute("id", " id=\"", 1546, "\"", 1559, 1);
#nullable restore
#line 51 "E:\ASP-NET\NewsForum\Views\NewsList\GetItem.cshtml"
WriteAttributeValue("", 1551, item.Id, 1551, 8, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                <h6>\r\n                    ");
#nullable restore
#line 53 "E:\ASP-NET\NewsForum\Views\NewsList\GetItem.cshtml"
               Write(Html.DisplayFor(modelItem => item.Author));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </h6>\r\n                <div>\r\n                    ");
#nullable restore
#line 56 "E:\ASP-NET\NewsForum\Views\NewsList\GetItem.cshtml"
               Write(Html.DisplayFor(modelItem => item.Text));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </div>\r\n                \r\n                <div>\r\n                    <span style=\"font-size: small\">\r\n                        ");
#nullable restore
#line 61 "E:\ASP-NET\NewsForum\Views\NewsList\GetItem.cshtml"
                    Write((Model.Offset != null ? item.Date.AddHours((int)Model.Offset) : item.Date).ToString("dd.MM.yyyy HH:mm"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        ");
#nullable restore
#line 62 "E:\ASP-NET\NewsForum\Views\NewsList\GetItem.cshtml"
                    Write(Model.Offset != null ? "" : "(по UTC)");

#line default
#line hidden
#nullable disable
                WriteLiteral(" \r\n                    </span>\r\n");
#nullable restore
#line 64 "E:\ASP-NET\NewsForum\Views\NewsList\GetItem.cshtml"
                     if (User.Identity.Name == item.Author)
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                        <span>\r\n                            ");
#nullable restore
#line 67 "E:\ASP-NET\NewsForum\Views\NewsList\GetItem.cshtml"
                       Write(Html.ActionLink("Удалить", "DeleteComment", "Comments", new { newsId = Model.News.Id, Id = item.Id }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        </span>\r\n");
#nullable restore
#line 69 "E:\ASP-NET\NewsForum\Views\NewsList\GetItem.cshtml"
                    }

#line default
#line hidden
#nullable disable
                WriteLiteral("                </div>\r\n                \r\n            </div>\r\n");
#nullable restore
#line 73 "E:\ASP-NET\NewsForum\Views\NewsList\GetItem.cshtml"
        }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"    </div>

    <script>
        const form = document.getElementById('form-id');
        const date = document.getElementById('date-id');

        form.addEventListener('submit', (event) => {

            const dateNow = new Date();
            date.value = `${dateNow.getFullYear()}-${
                (dateNow.getMonth() + 1).toString().padStart(2, '0')}-${
                dateNow.getDate().toString().padStart(2, '0')}-${
                dateNow.getHours().toString().padStart(2, '0')}-${
                dateNow.getMinutes().toString().padStart(2, '0')}-${
                dateNow.getSeconds().toString().padStart(2, '0')}`;
        });
    </script>
");
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
            WriteLiteral("\r\n</html>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<GetItemViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
