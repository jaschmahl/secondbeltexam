#pragma checksum "C:\Users\josep\Bootcamp\csharp\secondbeltexam\Views\Home\OneHobby.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "98222ae32e781032a881e6d9834a6cd18e0e2e5d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_OneHobby), @"mvc.1.0.view", @"/Views/Home/OneHobby.cshtml")]
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
#line 1 "C:\Users\josep\Bootcamp\csharp\secondbeltexam\Views\_ViewImports.cshtml"
using secondbeltexam;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\josep\Bootcamp\csharp\secondbeltexam\Views\_ViewImports.cshtml"
using secondbeltexam.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"98222ae32e781032a881e6d9834a6cd18e0e2e5d", @"/Views/Home/OneHobby.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5bf9bdbdc01480e164829964801f256aaac8f840", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_OneHobby : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Hobby>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\josep\Bootcamp\csharp\secondbeltexam\Views\Home\OneHobby.cshtml"
  
    ViewData["Title"] = ViewBag.hobby.name;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 7 "C:\Users\josep\Bootcamp\csharp\secondbeltexam\Views\Home\OneHobby.cshtml"
  bool creator = false;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\josep\Bootcamp\csharp\secondbeltexam\Views\Home\OneHobby.cshtml"
 if (ViewBag.loggeduser.userid == ViewBag.hobby.userid)
{
    creator = true;
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"container d-flex justify-content-between align-items-center\">\r\n    <h1>");
#nullable restore
#line 14 "C:\Users\josep\Bootcamp\csharp\secondbeltexam\Views\Home\OneHobby.cshtml"
   Write(ViewBag.hobby.name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n");
#nullable restore
#line 15 "C:\Users\josep\Bootcamp\csharp\secondbeltexam\Views\Home\OneHobby.cshtml"
     if (creator)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"px-2\">\r\n            <a");
            BeginWriteAttribute("href", " href=\"", 359, "\"", 404, 2);
            WriteAttributeValue("", 366, "/hobbies/delete/", 366, 16, true);
#nullable restore
#line 18 "C:\Users\josep\Bootcamp\csharp\secondbeltexam\Views\Home\OneHobby.cshtml"
WriteAttributeValue("", 382, ViewBag.hobby.hobbyid, 382, 22, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-danger btn-md\">Delete Hobby</a>\r\n            <a");
            BeginWriteAttribute("href", " href=\"", 468, "\"", 511, 2);
            WriteAttributeValue("", 475, "/hobbies/edit/", 475, 14, true);
#nullable restore
#line 19 "C:\Users\josep\Bootcamp\csharp\secondbeltexam\Views\Home\OneHobby.cshtml"
WriteAttributeValue("", 489, ViewBag.hobby.hobbyid, 489, 22, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-secondary btn-md\">Edit Hobby</a>\r\n        </div>\r\n");
#nullable restore
#line 21 "C:\Users\josep\Bootcamp\csharp\secondbeltexam\Views\Home\OneHobby.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n\r\n<div class=\"container\">\r\n    <h3>Description:</h3>\r\n    <p>");
#nullable restore
#line 26 "C:\Users\josep\Bootcamp\csharp\secondbeltexam\Views\Home\OneHobby.cshtml"
  Write(ViewBag.hobby.description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n</div>\r\n\r\n<div class=\"container d-flex justify-content-between\">\r\n    <div>\r\n        <h3>");
#nullable restore
#line 31 "C:\Users\josep\Bootcamp\csharp\secondbeltexam\Views\Home\OneHobby.cshtml"
       Write(ViewBag.hobby.name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" Enthusiasts:</h3>\r\n        <ul>\r\n");
#nullable restore
#line 33 "C:\Users\josep\Bootcamp\csharp\secondbeltexam\Views\Home\OneHobby.cshtml"
             foreach (Enthusiast e in ViewBag.hobby.Enthusiasts)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <li>");
#nullable restore
#line 35 "C:\Users\josep\Bootcamp\csharp\secondbeltexam\Views\Home\OneHobby.cshtml"
               Write(e.user.firstname);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n");
#nullable restore
#line 36 "C:\Users\josep\Bootcamp\csharp\secondbeltexam\Views\Home\OneHobby.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </ul>\r\n    </div>\r\n");
#nullable restore
#line 39 "C:\Users\josep\Bootcamp\csharp\secondbeltexam\Views\Home\OneHobby.cshtml"
      bool foundenthusiast = false;

#line default
#line hidden
#nullable disable
#nullable restore
#line 40 "C:\Users\josep\Bootcamp\csharp\secondbeltexam\Views\Home\OneHobby.cshtml"
     foreach (Enthusiast e in ViewBag.hobby.Enthusiasts)
    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 42 "C:\Users\josep\Bootcamp\csharp\secondbeltexam\Views\Home\OneHobby.cshtml"
         if (ViewBag.loggeduser.userid == e.userid)
        {
            foundenthusiast = true;
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 45 "C:\Users\josep\Bootcamp\csharp\secondbeltexam\Views\Home\OneHobby.cshtml"
                 
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 47 "C:\Users\josep\Bootcamp\csharp\secondbeltexam\Views\Home\OneHobby.cshtml"
     if (!foundenthusiast)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"justify-content-end\">\r\n            <h3>Become an Enthusiast!</h3>\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "98222ae32e781032a881e6d9834a6cd18e0e2e5d9002", async() => {
                WriteLiteral("\r\n                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "98222ae32e781032a881e6d9834a6cd18e0e2e5d9276", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 52 "C:\Users\josep\Bootcamp\csharp\secondbeltexam\Views\Home\OneHobby.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.userid);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 52 "C:\Users\josep\Bootcamp\csharp\secondbeltexam\Views\Home\OneHobby.cshtml"
                                                 WriteLiteral(ViewBag.loggeduser.userid);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "98222ae32e781032a881e6d9834a6cd18e0e2e5d11688", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 53 "C:\Users\josep\Bootcamp\csharp\secondbeltexam\Views\Home\OneHobby.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.hobbyid);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 53 "C:\Users\josep\Bootcamp\csharp\secondbeltexam\Views\Home\OneHobby.cshtml"
                                                  WriteLiteral(ViewBag.hobby.hobbyid);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                <input type=\"submit\" value=\"Add to Hobbies\" class=\"btn btn-primary btn-md\">\r\n            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "action", 4, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1373, "/enthusiasts/add/", 1373, 17, true);
#nullable restore
#line 51 "C:\Users\josep\Bootcamp\csharp\secondbeltexam\Views\Home\OneHobby.cshtml"
AddHtmlAttributeValue("", 1390, ViewBag.loggeduser.userid, 1390, 26, false);

#line default
#line hidden
#nullable disable
            AddHtmlAttributeValue("", 1416, "/", 1416, 1, true);
#nullable restore
#line 51 "C:\Users\josep\Bootcamp\csharp\secondbeltexam\Views\Home\OneHobby.cshtml"
AddHtmlAttributeValue("", 1417, ViewBag.hobby.hobbyid, 1417, 22, false);

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
            WriteLiteral("\r\n        </div>\r\n");
#nullable restore
#line 57 "C:\Users\josep\Bootcamp\csharp\secondbeltexam\Views\Home\OneHobby.cshtml"
    }
    else
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"justify-content-end\">\r\n            <a");
            BeginWriteAttribute("href", " href=\"", 1847, "\"", 1900, 2);
            WriteAttributeValue("", 1854, "/enthusiasts/delete/", 1854, 20, true);
#nullable restore
#line 61 "C:\Users\josep\Bootcamp\csharp\secondbeltexam\Views\Home\OneHobby.cshtml"
WriteAttributeValue("", 1874, ViewBag.loggeduser.userid, 1874, 26, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-danger btn-lg\">Remove from Hobbies</a>\r\n        </div>\r\n");
#nullable restore
#line 63 "C:\Users\josep\Bootcamp\csharp\secondbeltexam\Views\Home\OneHobby.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Hobby> Html { get; private set; }
    }
}
#pragma warning restore 1591
