#pragma checksum "C:\Users\Hamid\Desktop\LinkArticle\ApplyWithLinkedInSample\Views\Home\CustomerConfiguration.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "68d9c7d2060ad51c74675efed6885e82b319cf7f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_CustomerConfiguration), @"mvc.1.0.view", @"/Views/Home/CustomerConfiguration.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/CustomerConfiguration.cshtml", typeof(AspNetCore.Views_Home_CustomerConfiguration))]
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
#line 1 "C:\Users\Hamid\Desktop\LinkArticle\ApplyWithLinkedInSample\Views\_ViewImports.cshtml"
using LinkedInSample;

#line default
#line hidden
#line 2 "C:\Users\Hamid\Desktop\LinkArticle\ApplyWithLinkedInSample\Views\_ViewImports.cshtml"
using LinkedInSample.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"68d9c7d2060ad51c74675efed6885e82b319cf7f", @"/Views/Home/CustomerConfiguration.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5555c3c343833ccd3be3bb1f9b8abcc5873f6559", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_CustomerConfiguration : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\Hamid\Desktop\LinkArticle\ApplyWithLinkedInSample\Views\Home\CustomerConfiguration.cshtml"
  
    ViewData["Title"] = "Customer Configuration Plugin";

#line default
#line hidden
            BeginContext(65, 1133, true);
            WriteLiteral(@"
<br />
<br />

<div class=""row"">
    <script type=""text/javascript"" src=""https://platform.linkedin.com/xdoor/scripts/in.js"">
        api_key: { your client api key , remove the curly brace}
        extensions: ATSIntegrationWidget@http://www.linkedin.com/recruiter/widget/ATSIntegration
    </script>

    <script type=""IN/ATSIntegrationWidget""
            data-supported-bundled-integration-types=""APPLY_WITH_LINKEDIN""
            data-onintegrate=""handleIntegrations""
            data-width=""800px"">
    </script>

    <script>
        function handleIntegrations(integrations) {
            /* After clicking Request, this function is called and we receive this object which is going to be used to show the linkin button on our page
             Note: the configuration will not load if we do not specify the validJsSdkDomains
               integrationContext: ""urn:li:organization:your organization number""
               integrationType: ""APPLY_WITH_LINKEDIN""
               tenantType: ""JOBS""
");
            WriteLiteral("             */\r\n\r\n            console.log(\'integrations\', integrations);\r\n        }\r\n    </script>\r\n</div>\r\n");
            EndContext();
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
