#pragma checksum "C:\Users\Sadiq\Desktop\ASP.NET\Partial-views-load-more\EmbryoFrontToBack\EmbryoFrontToBack\Views\Accessories\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4c5dfe7c8b3508637cfd0571978ff9cc576bead3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Accessories_Index), @"mvc.1.0.view", @"/Views/Accessories/Index.cshtml")]
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
#line 1 "C:\Users\Sadiq\Desktop\ASP.NET\Partial-views-load-more\EmbryoFrontToBack\EmbryoFrontToBack\Views\_ViewImports.cshtml"
using EmbryoFrontToBack;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Sadiq\Desktop\ASP.NET\Partial-views-load-more\EmbryoFrontToBack\EmbryoFrontToBack\Views\_ViewImports.cshtml"
using EmbryoFrontToBack.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Sadiq\Desktop\ASP.NET\Partial-views-load-more\EmbryoFrontToBack\EmbryoFrontToBack\Views\_ViewImports.cshtml"
using EmbryoFrontToBack.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4c5dfe7c8b3508637cfd0571978ff9cc576bead3", @"/Views/Accessories/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"52271251cabf428c688ce7935b18151548b32c4c", @"/Views/_ViewImports.cshtml")]
    public class Views_Accessories_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<AccessoriesVM>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "volvo", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "saab", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "opel", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_ProductPartial", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Sadiq\Desktop\ASP.NET\Partial-views-load-more\EmbryoFrontToBack\EmbryoFrontToBack\Views\Accessories\Index.cshtml"
  
    ViewData["Title"] = "Accessories";
    Layout = "~/Views/Shared/_AccessoriesLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<main>
    <section id=""slide-accesories"">
        <div class=""my-container"">
            <div class=""row"">
                <div class=""sliders"">
                    <div class=""summary"">
                        <h4>Accessories</h4>
                        <p>Choose The Wide Range Of Best Accessories.</p>
                    </div>
                </div>
            </div>
        </div>
    </section>

    <section id=""products"">
        <div class=""my-container"">
            <div class=""row"">
                <div class=""col-3"">
                    <div class=""search"">
                        <input type=""search"" placeholder=""Search Products"">
                    </div>


                    <div class=""brand"">
                        <h5><b>Brand</b></h5>
                        <input class=""input"" type=""search"" placeholder=""Search Here"">
                        <input type=""checkbox"">
                        <label><b>Insignia™</b> <span>733</span></label><br>
               ");
            WriteLiteral(@"         <input type=""checkbox"">
                        <label> <b>Samsung</b> <span>585</span></label><br>
                        <input type=""checkbox"">
                        <label> <b>HP</b> <span>455</span></label><br>
                        <input type=""checkbox"">
                        <label> <b>Metra</b> <span>450</span></label><br>
                        <input type=""checkbox"">
                        <label> <b>Apple</b> <span>392</span></label><br>
                    </div>



                    <div class=""type"">
                        <h5><b>Type</b></h5>
                        <input type=""checkbox"">
                        <label><b>Trend cases</b> <span>452</span></label><br>
                        <input type=""checkbox"">
                        <label><b>Ult protection cases</b> <span>393</span></label><br>
                        <input type=""checkbox"">
                        <label> <b>Ink cartridges</b> <span>213</span></label><br>
                        ");
            WriteLiteral(@"<input type=""checkbox"">
                        <label><b> Business cases</b> <span>203</span></label><br>
                        <input type=""checkbox"">
                        <label> <b>Connectivity</b> <span>179</span></label><br>
                    </div>


                    <div class=""category"">
                        <h5><b>Category</b></h5>
                        <input class=""input"" type=""search"" placeholder=""Search Here"">
                        <input type=""checkbox"">
                        <label> <b>Cell Phone Accessories</b> <span>3,722</span></label><br>
                        <input type=""checkbox"">
                        <label> <b>Cell Phones</b> <span>2,919</span></label><br>
                        <input type=""checkbox"">
                        <label> <b>Computers & Tablets </b><span>2,876</span></label><br>
                        <input type=""checkbox"">
                        <label><b> Appliances</b> <span>2,470</span></label><br>
                        <");
            WriteLiteral(@"input type=""checkbox"">
                        <label><b>TV & Home Theater </b><span>1,364</span></label><br>
                    </div>



                    <div class=""price"">
                        <h5><b>Price</b></h5>
                        <input type=""radio"" name=""price"">
                        <label> Below $10 </label><br>

                        <input type=""radio"" name=""price"">
                        <label> $10 - $100</label><br>

                        <input type=""radio"" name=""price"">
                        <label> $100 - $500 </label><br>

                        <input type=""radio"" name=""price"">
                        <label> Above $500 </label><br>

                        <input type=""radio"" name=""price"">
                        <label>All </label><br>

                        <h5><b>Enter Price Range</b></h5>
                        <input class=""input"" type=""number"" placeholder=""1"" min=""0"" max=""5000"">
                        <span>-</span>
              ");
            WriteLiteral(@"          <input class=""input"" type=""number"" placeholder=""5000"" min=""0"" max=""5000"">
                        <button>Go</button>
                    </div>
                    <div class=""rating"">
                        <h5><b>Rating Menu</b></h5>
                        <ion-icon name=""star""></ion-icon>
                        <ion-icon name=""star""></ion-icon>
                        <ion-icon name=""star""></ion-icon>
                        <ion-icon name=""star""></ion-icon>
                        <ion-icon name=""star""></ion-icon>
                        <span>2150</span><br>
                        <ion-icon name=""star""></ion-icon>
                        <ion-icon name=""star""></ion-icon>
                        <ion-icon name=""star""></ion-icon>
                        <ion-icon name=""star""></ion-icon>
                        <ion-icon name=""star-outline""></ion-icon>
                        <span>16074</span><br>
                        <ion-icon name=""star""></ion-icon>
                   ");
            WriteLiteral(@"     <ion-icon name=""star""></ion-icon>
                        <ion-icon name=""star""></ion-icon>
                        <ion-icon name=""star-outline""></ion-icon>
                        <ion-icon name=""star-outline""></ion-icon>
                        <span>17696</span><br>
                        <ion-icon name=""star""></ion-icon>
                        <ion-icon name=""star""></ion-icon>
                        <ion-icon name=""star-outline""></ion-icon>
                        <ion-icon name=""star-outline""></ion-icon>
                        <ion-icon name=""star-outline""></ion-icon>
                        <span>17890</span><br>
                        <ion-icon name=""star""></ion-icon>
                        <ion-icon name=""star-outline""></ion-icon>
                        <ion-icon name=""star-outline""></ion-icon>
                        <ion-icon name=""star-outline""></ion-icon>
                        <ion-icon name=""star-outline""></ion-icon>
                        <span>17890</span>
     ");
            WriteLiteral(@"               </div>
                    <div class=""clear"">
                        <div class=""filter"">
                            <b> Clear all filters</b>
                        </div>
                    </div>
                </div>
                <div class=""col-9"">
                    <div class=""row"">
                        <div class=""col-12"">
                            <select name=""cars"" id=""cars"">
                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4c5dfe7c8b3508637cfd0571978ff9cc576bead312062", async() => {
                WriteLiteral("Highest Price");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4c5dfe7c8b3508637cfd0571978ff9cc576bead313261", async() => {
                WriteLiteral("Featured");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4c5dfe7c8b3508637cfd0571978ff9cc576bead314455", async() => {
                WriteLiteral("Lowest Price");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                            </select>\r\n                            <span class=\"span\"><b>18,046 results found in 6ms</b></span>\r\n                        </div>\r\n\r\n\r\n");
            WriteLiteral("                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "4c5dfe7c8b3508637cfd0571978ff9cc576bead315853", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            WriteLiteral(@"
                        <div class=""number"">
                            <i class=""fa-solid fa-angles-left""></i>
                            <i class=""fa-solid fa-angle-left""></i>
                            <span>1</span>
                            <span>2</span>
                            <span>3</span>
                            <span>4</span>
                            <span>5</span>
                            <i class=""fa-solid fa-angle-right""></i>
                            <i class=""fa-solid fa-angles-right""></i>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </section>



</main>

");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AccessoriesVM> Html { get; private set; }
    }
}
#pragma warning restore 1591
