#pragma checksum "C:\Users\VikS\source\repos\hopTropOnlineShop\Views\WishList\PrintFromBasket.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7af82a4632c2cc32e7e9ebbe5ac6856a7d0813e1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_WishList_PrintFromBasket), @"mvc.1.0.view", @"/Views/WishList/PrintFromBasket.cshtml")]
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
#line 1 "C:\Users\VikS\source\repos\hopTropOnlineShop\Views\_ViewImports.cshtml"
using hopTropOnlineShop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\VikS\source\repos\hopTropOnlineShop\Views\_ViewImports.cshtml"
using hopTropOnlineShop.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7af82a4632c2cc32e7e9ebbe5ac6856a7d0813e1", @"/Views/WishList/PrintFromBasket.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8a8303fc8901a09e6b1a35da908482c82694c455", @"/Views/_ViewImports.cshtml")]
    public class Views_WishList_PrintFromBasket : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<hopTropOnlineShop.ViewModels.WishListDetailsViewModel>
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\VikS\source\repos\hopTropOnlineShop\Views\WishList\PrintFromBasket.cshtml"
  
    ViewData["Title"] = "PrintFromBasket";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\VikS\source\repos\hopTropOnlineShop\Views\WishList\PrintFromBasket.cshtml"
 if (Model.Clothes.Count > 0)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7af82a4632c2cc32e7e9ebbe5ac6856a7d0813e13804", async() => {
                WriteLiteral("\r\n        <table class=\"table\">\r\n            <thead>\r\n                <tr>\r\n                    <th>\r\n                        ");
#nullable restore
#line 14 "C:\Users\VikS\source\repos\hopTropOnlineShop\Views\WishList\PrintFromBasket.cshtml"
                   Write(Html.DisplayNameFor(model => model.Clothes[0].Gender));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
#nullable restore
#line 17 "C:\Users\VikS\source\repos\hopTropOnlineShop\Views\WishList\PrintFromBasket.cshtml"
                   Write(Html.DisplayNameFor(model => model.Clothes[0].TypeOfCloth));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
#nullable restore
#line 20 "C:\Users\VikS\source\repos\hopTropOnlineShop\Views\WishList\PrintFromBasket.cshtml"
                   Write(Html.DisplayNameFor(model => model.Clothes[0].Size));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
#nullable restore
#line 23 "C:\Users\VikS\source\repos\hopTropOnlineShop\Views\WishList\PrintFromBasket.cshtml"
                   Write(Html.DisplayNameFor(model => model.Clothes[0].Color));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
#nullable restore
#line 26 "C:\Users\VikS\source\repos\hopTropOnlineShop\Views\WishList\PrintFromBasket.cshtml"
                   Write(Html.DisplayNameFor(model => model.Clothes[0].Price));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
#nullable restore
#line 29 "C:\Users\VikS\source\repos\hopTropOnlineShop\Views\WishList\PrintFromBasket.cshtml"
                   Write(Html.DisplayNameFor(model => model.Clothes[0].Currency));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </th>\r\n                    <th></th>\r\n                </tr>\r\n            </thead>\r\n            <tbody>\r\n");
#nullable restore
#line 35 "C:\Users\VikS\source\repos\hopTropOnlineShop\Views\WishList\PrintFromBasket.cshtml"
                 foreach (var item in Model.Clothes)
                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                <tr>\r\n                    <td>\r\n                        ");
#nullable restore
#line 39 "C:\Users\VikS\source\repos\hopTropOnlineShop\Views\WishList\PrintFromBasket.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Gender));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 42 "C:\Users\VikS\source\repos\hopTropOnlineShop\Views\WishList\PrintFromBasket.cshtml"
                   Write(Html.DisplayFor(modelItem => item.TypeOfCloth));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 45 "C:\Users\VikS\source\repos\hopTropOnlineShop\Views\WishList\PrintFromBasket.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Size));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 48 "C:\Users\VikS\source\repos\hopTropOnlineShop\Views\WishList\PrintFromBasket.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Color));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 51 "C:\Users\VikS\source\repos\hopTropOnlineShop\Views\WishList\PrintFromBasket.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Price));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 54 "C:\Users\VikS\source\repos\hopTropOnlineShop\Views\WishList\PrintFromBasket.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Currency));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </td>\r\n                  \r\n                </tr>\r\n");
#nullable restore
#line 58 "C:\Users\VikS\source\repos\hopTropOnlineShop\Views\WishList\PrintFromBasket.cshtml"
                }

#line default
#line hidden
#nullable disable
                WriteLiteral("            </tbody>\r\n        </table>\r\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 62 "C:\Users\VikS\source\repos\hopTropOnlineShop\Views\WishList\PrintFromBasket.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 64 "C:\Users\VikS\source\repos\hopTropOnlineShop\Views\WishList\PrintFromBasket.cshtml"
 if (@Model.IDUser > 0)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("<p>Крайна сума: ");
#nullable restore
#line 66 "C:\Users\VikS\source\repos\hopTropOnlineShop\Views\WishList\PrintFromBasket.cshtml"
           Write(Model.Sum);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 66 "C:\Users\VikS\source\repos\hopTropOnlineShop\Views\WishList\PrintFromBasket.cshtml"
                      Write(Html.DisplayFor(model => model.Clothes[0].Currency));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n<button");
            BeginWriteAttribute("onclick", " onclick=\"", 2244, "\"", 2298, 3);
            WriteAttributeValue("", 2254, "location.href=\'", 2254, 15, true);
#nullable restore
#line 67 "C:\Users\VikS\source\repos\hopTropOnlineShop\Views\WishList\PrintFromBasket.cshtml"
WriteAttributeValue("", 2269, Url.Action("Order", "Home"), 2269, 28, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2297, "\'", 2297, 1, true);
            EndWriteAttribute();
            WriteLiteral(" type=\"button\">Поръчвам</button>\r\n");
#nullable restore
#line 68 "C:\Users\VikS\source\repos\hopTropOnlineShop\Views\WishList\PrintFromBasket.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<hopTropOnlineShop.ViewModels.WishListDetailsViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
