#pragma checksum "D:\Mindtree\Mini Project\OnlinePizzaApplication\PizzaApplication\Views\OnlinePizza\Home.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c4ff17a9ef1728e64040701d4898073556ced5e8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_OnlinePizza_Home), @"mvc.1.0.view", @"/Views/OnlinePizza/Home.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c4ff17a9ef1728e64040701d4898073556ced5e8", @"/Views/OnlinePizza/Home.cshtml")]
    public class Views_OnlinePizza_Home : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("400"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("height:250px;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-fluid"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("post-img"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 4 "D:\Mindtree\Mini Project\OnlinePizzaApplication\PizzaApplication\Views\OnlinePizza\Home.cshtml"
  
    var userid = ViewBag.UserId;
    var pizza = ViewBag.Message;
    Layout = "~/Views/Shared/UserLayout.cshtml";
    int i = 0;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<script>
    document.getElementById(""home"").classList.add(""active"");
</script>

<script>
     var Pizza = {
         CartId: 0,
        UserId: 0,
        PizzaId: 0,
        Quantity: 0,
        Price: 0,
    }


    function PizzaToCart(pizzaid, pizzaPrice) {
        var options = {};
        options.url = ""/api/cart"";
        options.type = ""POST"";
        var obj = Pizza;
        obj.CartId = 0;
        obj.UserId = ");
#nullable restore
#line 32 "D:\Mindtree\Mini Project\OnlinePizzaApplication\PizzaApplication\Views\OnlinePizza\Home.cshtml"
                Write(userid);

#line default
#line hidden
#nullable disable
            WriteLiteral(@";
        obj.PizzaId = pizzaid;
        obj.Quantity = 1;
        obj.Price =  pizzaPrice;
         

        console.dir(obj);
        options.data = JSON.stringify(obj);
        options.contentType = ""application/json"";
        options.dataType = ""html"";

        options.success = function (msg) {
            Alert.render(msg, '/OnlinePizza/Home');
            //alert('Order Placed Sucessfully');
            //window.location.href = '/OnlinePizza/Home';
        },
            options.error = function () {
                $(""#msg"").html(""Error while calling the Web API!"");
            };
        $.ajax(options);
    }
</script>
<div id=""blog"" class=""section wb"" style=""margin-top:50px;"">
    <div class=""container-fluid"">

        <div class=""row"">
");
#nullable restore
#line 58 "D:\Mindtree\Mini Project\OnlinePizzaApplication\PizzaApplication\Views\OnlinePizza\Home.cshtml"
             foreach (var item in pizza)
            {

                if (i > 0 && i % 3 == 0)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                ");
            WriteLiteral("</div><hr><div class=\"row\">\r\n");
#nullable restore
#line 64 "D:\Mindtree\Mini Project\OnlinePizzaApplication\PizzaApplication\Views\OnlinePizza\Home.cshtml"
                    // close and start new row
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"col-md-4 col-sm-6 col-lg-4\">\r\n                    <div class=\"post-box\">\r\n                        <div class=\"post-thumb\">\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "c4ff17a9ef1728e64040701d4898073556ced5e86673", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1929, "~/Images/", 1929, 9, true);
#nullable restore
#line 69 "D:\Mindtree\Mini Project\OnlinePizzaApplication\PizzaApplication\Views\OnlinePizza\Home.cshtml"
AddHtmlAttributeValue("", 1938, item.Image, 1938, 11, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                            <div class=\"date\">\r\n                                <span>Price - </span>\r\n                                <span>");
#nullable restore
#line 72 "D:\Mindtree\Mini Project\OnlinePizzaApplication\PizzaApplication\Views\OnlinePizza\Home.cshtml"
                                 Write(item.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n\r\n                            </div>\r\n                        </div>\r\n\r\n                        <div class=\"post-info\" style=\"text-align:center; font-weight: bold;color:black;\">\r\n                            <h4 style=\"margin-top:-30px;\">");
#nullable restore
#line 78 "D:\Mindtree\Mini Project\OnlinePizzaApplication\PizzaApplication\Views\OnlinePizza\Home.cshtml"
                                                     Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n                            <p> Category - ");
#nullable restore
#line 79 "D:\Mindtree\Mini Project\OnlinePizzaApplication\PizzaApplication\Views\OnlinePizza\Home.cshtml"
                                      Write(item.Category);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                            <p style=\"margin-top:-20px;\"> Toppings - ");
#nullable restore
#line 80 "D:\Mindtree\Mini Project\OnlinePizzaApplication\PizzaApplication\Views\OnlinePizza\Home.cshtml"
                                                                Write(item.Toppings);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                            <div class=\"col-lg-12 text-center\">\r\n                                <div id=\"success\"></div>\r\n                                <a");
            BeginWriteAttribute("href", " href=\"", 2746, "\"", 2788, 2);
            WriteAttributeValue("", 2753, "/OnlinePizza/BuyPizza/", 2753, 22, true);
#nullable restore
#line 83 "D:\Mindtree\Mini Project\OnlinePizzaApplication\PizzaApplication\Views\OnlinePizza\Home.cshtml"
WriteAttributeValue("", 2775, item.PizzaId, 2775, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"sim-btn hvr-radial-in\">Buy Now</a>\r\n                                <button id=\"sendMessageButton\"");
            BeginWriteAttribute("onclick", " onclick=\"", 2895, "\"", 2944, 5);
            WriteAttributeValue("", 2905, "PizzaToCart(", 2905, 12, true);
#nullable restore
#line 84 "D:\Mindtree\Mini Project\OnlinePizzaApplication\PizzaApplication\Views\OnlinePizza\Home.cshtml"
WriteAttributeValue("", 2917, item.PizzaId, 2917, 13, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2930, ",", 2930, 1, true);
#nullable restore
#line 84 "D:\Mindtree\Mini Project\OnlinePizzaApplication\PizzaApplication\Views\OnlinePizza\Home.cshtml"
WriteAttributeValue(" ", 2931, item.Price, 2932, 11, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2943, ")", 2943, 1, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"sim-btn hvr-radial-in\" style=\"margin-left:20px;\" data-text=\"Send Message\" type=\"button\">Add To Cart</button>\r\n                            </div>\r\n\r\n                        </div>\r\n\r\n                    </div>\r\n                </div>\r\n");
#nullable restore
#line 91 "D:\Mindtree\Mini Project\OnlinePizzaApplication\PizzaApplication\Views\OnlinePizza\Home.cshtml"

                i = i + 1;

            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n\r\n\r\n    </div>\r\n\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591