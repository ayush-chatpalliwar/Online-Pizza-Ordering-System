#pragma checksum "D:\Mindtree\Mini Project\OnlinePizzaApplication\PizzaApplication\Views\OnlinePizza\SendFeedback.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "090d2afdfffc814605ef0ea17da86c209859c123"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_OnlinePizza_SendFeedback), @"mvc.1.0.view", @"/Views/OnlinePizza/SendFeedback.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"090d2afdfffc814605ef0ea17da86c209859c123", @"/Views/OnlinePizza/SendFeedback.cshtml")]
    public class Views_OnlinePizza_SendFeedback : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 4 "D:\Mindtree\Mini Project\OnlinePizzaApplication\PizzaApplication\Views\OnlinePizza\SendFeedback.cshtml"
  
    Layout = "~/Views/Shared/UserLayout.cshtml";
    var userid = ViewBag.UserId;
    var orderno = ViewBag.Message;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<script>
    document.getElementById(""feedbacks"").classList.add(""active"");

     var Feedback = {
         FeedbackId: 0,
         UserId: 0,
         OrderNo: 0,
         Title: """",
         Description: """",
         Date:""""
    }


    function AddFeedback(oid, uid) {
        
        var options = {};
        options.url = ""/api/Feedback"";
        options.type = ""POST"";
        var obj = Feedback;
        obj.FeedbackId = 0;
        obj.UserId = uid;
        obj.OrderNo = oid;
        obj.Title = $(""#title"").val();
        obj.Description = $('textarea#message').val();
        obj.Date = new Date();
        //alert(obj.Description);

        console.dir(obj);
        options.data = JSON.stringify(obj);
        options.contentType = ""application/json"";
        options.dataType = ""html"";

        options.success = function (msg) {
            Alert.render(msg, '/OnlinePizza/Home');
            //alert('Feedback Sent Sucessfully');
            //window.location.href = '/Onli");
            WriteLiteral(@"nePizza/Home';
        },
            options.error = function () {
                $(""#msg"").html(""Error while calling the Web API!"");
            };
        $.ajax(options);
    }
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
                                <div class=""form-group"">
                                    <input class=""form-control"" id=""title"" placeholder=""Your Title"" required=""required"" data-validation-required-message=""Please enter your title."">
                                    <p class=""help-b");
            WriteLiteral(@"lock text-danger""></p>
                                </div>
                            </div>
                            <div class=""col-md-12"">
                                <div class=""form-group"">
                                    <textarea class=""form-control"" id=""message"" placeholder=""Your Feedback"" required=""required"" data-validation-required-message=""Please enter feedback.""></textarea>
                                    <p class=""help-block text-danger""></p>
                                </div>
                            </div>

                            <div class=""clearfix""></div>
                            <div class=""col-lg-12 text-center"">
                                <div id=""success""></div>
                                <button id=""sendMessageButton""");
            BeginWriteAttribute("onclick", " onclick=\"", 3105, "\"", 3145, 5);
            WriteAttributeValue("", 3115, "AddFeedback(", 3115, 12, true);
#nullable restore
#line 82 "D:\Mindtree\Mini Project\OnlinePizzaApplication\PizzaApplication\Views\OnlinePizza\SendFeedback.cshtml"
WriteAttributeValue("", 3127, orderno, 3127, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3135, ",", 3135, 1, true);
#nullable restore
#line 82 "D:\Mindtree\Mini Project\OnlinePizzaApplication\PizzaApplication\Views\OnlinePizza\SendFeedback.cshtml"
WriteAttributeValue(" ", 3136, userid, 3137, 7, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3144, ")", 3144, 1, true);
            EndWriteAttribute();
            WriteLiteral(@" class=""sim-btn hvr-radial-in"" data-text=""Send Feedback"" type=""button"">Send Feedback</button>
                            </div>
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
