#pragma checksum "E:\POC BACKUP\LoginView1\LoginView1\Views\Login\NewPage.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "425855db8d19ec441cb4c25bf9490cf74dca2b70"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Login_NewPage), @"mvc.1.0.view", @"/Views/Login/NewPage.cshtml")]
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
#line 1 "E:\POC BACKUP\LoginView1\LoginView1\Views\_ViewImports.cshtml"
using LoginView1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\POC BACKUP\LoginView1\LoginView1\Views\_ViewImports.cshtml"
using LoginView1.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"425855db8d19ec441cb4c25bf9490cf74dca2b70", @"/Views/Login/NewPage.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"27bd2e7d88e5bb22d16041f7d08a3c93be749238", @"/Views/_ViewImports.cshtml")]
    public class Views_Login_NewPage : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "E:\POC BACKUP\LoginView1\LoginView1\Views\Login\NewPage.cshtml"
  
    ViewData["Title"] = "NewPage";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n    <nav class=\"navbar navbar-dark\" style=\"background-color :black\">\r\n      <a class=\"navbar-brand text-white\">Authentication</a>\r\n");
            WriteLiteral(@"    </nav>
<div id=""name""></div>
<div id=""email""></div>
<div id=""fullName""></div>

<script src=""https://ajax.googleapis.com/ajax/libs/jquery/3.4.1/jquery.min.js""></script>


<script>
    $(document).ready(function () {
      //  document.getElementById(""email"").textContent = window.localStorage.getItem(""Token"");
        console.log('Hi')

        var token = window.localStorage.getItem(""Token"");
        console.log(token);
        if (token != null) {

            $.ajax({
                type: ""GET"",
                url: ""http://localhost:63697/api/UserProfile/GetUserProfile"",
                contentType: ""application/json; charset=utf-8"",
                dataType: ""json"",
                //  headers: { ""Authorization"": localStorage.getItem('Token') },
                //beforeSend: function (xhr) {
                //    xhr.setRequestHeader(""Authorization"", ""Bearer "" + localStorage.getItem('Token'))
                //},
                headers: {
                    'Authorization'");
            WriteLiteral(@": 'Bearer ' + JSON.parse(token).token
                },
                success: function (data, textStatus, xhr) {
                    $('#name').append(JSON.stringify(data));
                    document.getElementById(""email"").textContent = window.localStorage.getItem(""Token"")

                },

                failure: function (data) {
                    //console.log('Failure Function');
                },
                error: function (data) {
                    //console.log(data);
                }

            });
        }
        else {
            window.location.href = ""/Login/LogIn"";
        }
      




    });



</script>
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
