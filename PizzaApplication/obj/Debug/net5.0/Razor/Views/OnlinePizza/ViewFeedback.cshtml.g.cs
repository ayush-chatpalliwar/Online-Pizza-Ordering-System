#pragma checksum "D:\Mindtree\Mini Project\OnlinePizzaApplication\PizzaApplication\Views\OnlinePizza\ViewFeedback.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ad1f5e82963414a45ee5f29f41cec146201878d3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_OnlinePizza_ViewFeedback), @"mvc.1.0.view", @"/Views/OnlinePizza/ViewFeedback.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ad1f5e82963414a45ee5f29f41cec146201878d3", @"/Views/OnlinePizza/ViewFeedback.cshtml")]
    public class Views_OnlinePizza_ViewFeedback : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 4 "D:\Mindtree\Mini Project\OnlinePizzaApplication\PizzaApplication\Views\OnlinePizza\ViewFeedback.cshtml"
  
    var feedback = ViewBag.message;
    Layout = "~/Views/Shared/AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<script>
    document.getElementById(""feedbacks"").classList.add(""active"");
</script>

<div id=""contact"" class=""section db"">
    <div class=""container-fluid"">
        <div class=""section-title text-center"">
            <h3>Feedback</h3>
        </div><!-- end title -->

        <div class=""row"">
            <div class=""col-md-12"">
                <div class=""contact_form"">
                    <div id=""message""></div>
                    <form id=""contactForm"" name=""sentMessage"" novalidate=""novalidate"">
                        <div class=""row"">

                            <div class=""col-md-12"">

                                <h2 style=""color:black;"">Title :</h2>

                            </div>
                            <div class=""col-md-12 form-group"">
                                <div class=""section-title"">
                                    <h4>");
#nullable restore
#line 32 "D:\Mindtree\Mini Project\OnlinePizzaApplication\PizzaApplication\Views\OnlinePizza\ViewFeedback.cshtml"
                                   Write(feedback.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h4>
                                </div><!-- end title -->
                            </div>
                            <div class=""col-md-12"" style=""margin-top:-50px;"">

                                <h2 style=""color:black;"">Description :</h2>

                            </div>
                            <div class=""col-md-12 form-group"">
                                <div class=""section-title"">
                                    <h4>");
#nullable restore
#line 42 "D:\Mindtree\Mini Project\OnlinePizzaApplication\PizzaApplication\Views\OnlinePizza\ViewFeedback.cshtml"
                                   Write(feedback.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h4>
                                </div><!-- end title -->
                            </div>

                            <div class=""col-md-6"" style=""margin-top:-50px;"">

                                <h2 style=""color:black;"">Feedback By :</h2>

                            </div>
                            <div class=""col-md-12 form-group"">
                                <div class=""section-title"">
                                    <h4> ");
#nullable restore
#line 53 "D:\Mindtree\Mini Project\OnlinePizzaApplication\PizzaApplication\Views\OnlinePizza\ViewFeedback.cshtml"
                                    Write(feedback.UserName);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h4>
                                </div><!-- end title -->
                            </div>

                            <div class=""col-md-6"" style=""margin-top:-50px;"">

                                <h2 style=""color:black;"">Order No :</h2>

                            </div>
                            <div class=""col-md-12 form-group"">
                                <div class=""section-title"">
                                    <h4>");
#nullable restore
#line 64 "D:\Mindtree\Mini Project\OnlinePizzaApplication\PizzaApplication\Views\OnlinePizza\ViewFeedback.cshtml"
                                   Write(feedback.OrderNo);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h4>
                                </div><!-- end title -->
                            </div>

                            <div class=""col-md-6"" style=""margin-top:-50px;"">

                                <h2 style=""color:black;"">Date :</h2>

                            </div>
                            <div class=""col-md-12 form-group"">
                                <div class=""section-title"">
                                    <h4>");
#nullable restore
#line 75 "D:\Mindtree\Mini Project\OnlinePizzaApplication\PizzaApplication\Views\OnlinePizza\ViewFeedback.cshtml"
                                   Write(feedback.Date.ToString("dd/MM/yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h4>
                                </div><!-- end title -->
                            </div>


                            <!-- <div class=""clearfix""></div> -->
                            <!-- <div class=""col-lg-12 text-center""> -->
                            <!-- <div id=""success""></div> -->
                            <!-- <button id=""sendMessageButton"" class=""sim-btn hvr-radial-in"" data-text=""Send Feedback"" type=""submit"">Send Feedback</button> -->
                            <!-- </div> -->
                        </div>
                    </form>
                </div>
            </div><!-- end col -->
        </div><!-- end row -->
    </div><!-- end container -->
</div><!-- end section -->
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
