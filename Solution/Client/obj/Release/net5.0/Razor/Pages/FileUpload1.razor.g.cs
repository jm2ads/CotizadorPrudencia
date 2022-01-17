#pragma checksum "D:\JM2\WP\CotizadorPrudencia\Solution\Client\Pages\FileUpload1.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "30d203255794309de9007160fd3195307e77ce06"
// <auto-generated/>
#pragma warning disable 1591
namespace Project.Client.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\JM2\WP\CotizadorPrudencia\Solution\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\JM2\WP\CotizadorPrudencia\Solution\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\JM2\WP\CotizadorPrudencia\Solution\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\JM2\WP\CotizadorPrudencia\Solution\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\JM2\WP\CotizadorPrudencia\Solution\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\JM2\WP\CotizadorPrudencia\Solution\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\JM2\WP\CotizadorPrudencia\Solution\Client\_Imports.razor"
using Project.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\JM2\WP\CotizadorPrudencia\Solution\Client\_Imports.razor"
using Project.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\JM2\WP\CotizadorPrudencia\Solution\Client\_Imports.razor"
using Project.Client.Helpers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\JM2\WP\CotizadorPrudencia\Solution\Client\_Imports.razor"
using Project.Shared.Entidades;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "D:\JM2\WP\CotizadorPrudencia\Solution\Client\_Imports.razor"
using Project.Shared.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "D:\JM2\WP\CotizadorPrudencia\Solution\Client\_Imports.razor"
using Project.Client.Repositorios;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "D:\JM2\WP\CotizadorPrudencia\Solution\Client\_Imports.razor"
using Project.Shared.PrudenciaDTOs;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\JM2\WP\CotizadorPrudencia\Solution\Client\Pages\FileUpload1.razor"
using Microsoft.Extensions.Logging;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/test/file-upload-1")]
    public partial class FileUpload1 : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Upload Files</h3>\r\n\r\n");
            __builder.OpenElement(1, "p");
            __builder.OpenElement(2, "label");
            __builder.AddMarkupContent(3, "\r\n        Max file size:\r\n        ");
            __builder.OpenElement(4, "input");
            __builder.AddAttribute(5, "type", "number");
            __builder.AddAttribute(6, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 10 "D:\JM2\WP\CotizadorPrudencia\Solution\Client\Pages\FileUpload1.razor"
                                    maxFileSize

#line default
#line hidden
#nullable disable
            , culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.AddAttribute(7, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => maxFileSize = __value, maxFileSize, culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(8, "\r\n\r\n");
            __builder.OpenElement(9, "p");
            __builder.OpenElement(10, "label");
            __builder.AddMarkupContent(11, "\r\n        Max allowed files:\r\n        ");
            __builder.OpenElement(12, "input");
            __builder.AddAttribute(13, "type", "number");
            __builder.AddAttribute(14, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 17 "D:\JM2\WP\CotizadorPrudencia\Solution\Client\Pages\FileUpload1.razor"
                                    maxAllowedFiles

#line default
#line hidden
#nullable disable
            , culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.AddAttribute(15, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => maxAllowedFiles = __value, maxAllowedFiles, culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\r\n\r\n");
            __builder.OpenElement(17, "p");
            __builder.OpenElement(18, "label");
            __builder.AddMarkupContent(19, "\r\n        Upload up to ");
            __builder.AddContent(20, 
#nullable restore
#line 23 "D:\JM2\WP\CotizadorPrudencia\Solution\Client\Pages\FileUpload1.razor"
                      maxAllowedFiles

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(21, " of up to ");
            __builder.AddContent(22, 
#nullable restore
#line 23 "D:\JM2\WP\CotizadorPrudencia\Solution\Client\Pages\FileUpload1.razor"
                                                maxFileSize

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(23, " bytes:\r\n        ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputFile>(24);
            __builder.AddAttribute(25, "OnChange", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.InputFileChangeEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.InputFileChangeEventArgs>(this, 
#nullable restore
#line 24 "D:\JM2\WP\CotizadorPrudencia\Solution\Client\Pages\FileUpload1.razor"
                              LoadFiles

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(26, "multiple", true);
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 28 "D:\JM2\WP\CotizadorPrudencia\Solution\Client\Pages\FileUpload1.razor"
 if (isLoading)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(27, "<p>Uploading...</p>");
#nullable restore
#line 31 "D:\JM2\WP\CotizadorPrudencia\Solution\Client\Pages\FileUpload1.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(28, "ul");
#nullable restore
#line 35 "D:\JM2\WP\CotizadorPrudencia\Solution\Client\Pages\FileUpload1.razor"
         foreach (var file in loadedFiles)
        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(29, "li");
            __builder.OpenElement(30, "ul");
            __builder.OpenElement(31, "li");
            __builder.AddContent(32, "Name: ");
            __builder.AddContent(33, 
#nullable restore
#line 39 "D:\JM2\WP\CotizadorPrudencia\Solution\Client\Pages\FileUpload1.razor"
                               file.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(34, "\r\n                    ");
            __builder.OpenElement(35, "li");
            __builder.AddContent(36, "Last modified: ");
            __builder.AddContent(37, 
#nullable restore
#line 40 "D:\JM2\WP\CotizadorPrudencia\Solution\Client\Pages\FileUpload1.razor"
                                        file.LastModified.ToString()

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(38, "\r\n                    ");
            __builder.OpenElement(39, "li");
            __builder.AddContent(40, "Size (bytes): ");
            __builder.AddContent(41, 
#nullable restore
#line 41 "D:\JM2\WP\CotizadorPrudencia\Solution\Client\Pages\FileUpload1.razor"
                                       file.Size

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(42, "\r\n                    ");
            __builder.OpenElement(43, "li");
            __builder.AddContent(44, "Content type: ");
            __builder.AddContent(45, 
#nullable restore
#line 42 "D:\JM2\WP\CotizadorPrudencia\Solution\Client\Pages\FileUpload1.razor"
                                       file.ContentType

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 45 "D:\JM2\WP\CotizadorPrudencia\Solution\Client\Pages\FileUpload1.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
#nullable restore
#line 47 "D:\JM2\WP\CotizadorPrudencia\Solution\Client\Pages\FileUpload1.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 49 "D:\JM2\WP\CotizadorPrudencia\Solution\Client\Pages\FileUpload1.razor"
       
    private List<IBrowserFile> loadedFiles = new();
    private long maxFileSize = 1024 * 15;
    private int maxAllowedFiles = 3;
    private bool isLoading;

    private async Task LoadFiles(InputFileChangeEventArgs e)
    {
        isLoading = true;
        loadedFiles.Clear();

        foreach (var file in e.GetMultipleFiles(maxAllowedFiles))
        {
            var arrbytes = new byte[file.Size];
           await file.OpenReadStream().ReadAsync(arrbytes);
            string imagenBase64 = Convert.ToBase64String(arrbytes);


            try
            {
                loadedFiles.Add(file);
            }
            catch (Exception ex)
            {
                Logger.LogError("File: {Filename} Error: {Error}",
                    file.Name, ex.Message);
            }
        }

        isLoading = false;
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ILogger<FileUpload1> Logger { get; set; }
    }
}
#pragma warning restore 1591