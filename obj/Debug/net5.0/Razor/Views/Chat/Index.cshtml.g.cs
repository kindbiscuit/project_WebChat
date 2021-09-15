#pragma checksum "C:\Users\guilh\OneDrive\Área de Trabalho\P\blue\exercicios_aulas\módulo_4\projetos\WebZap\Webzap\Views\Chat\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "081a26858636c69f7bc11dfd70ac599646e47464"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Chat_Index), @"mvc.1.0.view", @"/Views/Chat/Index.cshtml")]
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
#line 1 "C:\Users\guilh\OneDrive\Área de Trabalho\P\blue\exercicios_aulas\módulo_4\projetos\WebZap\Webzap\Views\_ViewImports.cshtml"
using GrupoChat;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\guilh\OneDrive\Área de Trabalho\P\blue\exercicios_aulas\módulo_4\projetos\WebZap\Webzap\Views\_ViewImports.cshtml"
using GrupoChat.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"081a26858636c69f7bc11dfd70ac599646e47464", @"/Views/Chat/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3456d7544d356a12c41b0972b139ca64ab75cd86", @"/Views/_ViewImports.cshtml")]
    public class Views_Chat_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Message>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "SendMessage", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("SendMessageForm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("row"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "C:\Users\guilh\OneDrive\Área de Trabalho\P\blue\exercicios_aulas\módulo_4\projetos\WebZap\Webzap\Views\Chat\Index.cshtml"
  
    var messages = ViewBag.Messages as List<Message>;
    var username = ViewBag.CurrentUserName as string;
    var nome = ViewBag.NomeUsuario as string;
    var privateMessageUrl = "/Chat/PrivateMessage/";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<style>
    .chat {
        max-height: 500px;
        overflow-y: scroll;
        border: 1px red #00FFFF;
        background: #00FFFF;
    }

        .chat::-webkit-scrollbar {
            width: 5px;
        }

        .chat::-webkit-scrollbar-thumb {
            box-shadow: inset 0 0 6px rgba(0,0,0,.3);
            background-color: silver;
        }
</style>

<h2>WebZap da tristeza</h2>
<div class=""bg-dark chat jumbotron"" id=""chat"">
");
#nullable restore
#line 30 "C:\Users\guilh\OneDrive\Área de Trabalho\P\blue\exercicios_aulas\módulo_4\projetos\WebZap\Webzap\Views\Chat\Index.cshtml"
     if (messages != null)
    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 32 "C:\Users\guilh\OneDrive\Área de Trabalho\P\blue\exercicios_aulas\módulo_4\projetos\WebZap\Webzap\Views\Chat\Index.cshtml"
         foreach (var message in messages.OrderBy(m => m.Datetime))
        {
            var position = username == message.UserName ? "text-right" : "text-left";
            var alert = username == message.UserName ? "alert-info" : "alert-secondary";

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"row\">\r\n                <div");
            BeginWriteAttribute("class", " class=\"", 1043, "\"", 1070, 2);
            WriteAttributeValue("", 1051, "col-md-12", 1051, 9, true);
#nullable restore
#line 37 "C:\Users\guilh\OneDrive\Área de Trabalho\P\blue\exercicios_aulas\módulo_4\projetos\WebZap\Webzap\Views\Chat\Index.cshtml"
WriteAttributeValue(" ", 1060, position, 1061, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                    <small class=\"text-info\">");
#nullable restore
#line 38 "C:\Users\guilh\OneDrive\Área de Trabalho\P\blue\exercicios_aulas\módulo_4\projetos\WebZap\Webzap\Views\Chat\Index.cshtml"
                                        Write(message.NomeUsuario);

#line default
#line hidden
#nullable disable
            WriteLiteral("</small>\r\n                    <div");
            BeginWriteAttribute("class", " class=\"", 1173, "\"", 1198, 3);
            WriteAttributeValue("", 1181, "alert", 1181, 5, true);
            WriteAttributeValue(" ", 1186, "mb-0", 1187, 5, true);
#nullable restore
#line 39 "C:\Users\guilh\OneDrive\Área de Trabalho\P\blue\exercicios_aulas\módulo_4\projetos\WebZap\Webzap\Views\Chat\Index.cshtml"
WriteAttributeValue(" ", 1191, alert, 1192, 6, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" role=\"alert\">\r\n                        <span class=\"d-block\">");
#nullable restore
#line 40 "C:\Users\guilh\OneDrive\Área de Trabalho\P\blue\exercicios_aulas\módulo_4\projetos\WebZap\Webzap\Views\Chat\Index.cshtml"
                                         Write(message.Text);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                    </div>\r\n                    <small class=\"text-info\">");
#nullable restore
#line 42 "C:\Users\guilh\OneDrive\Área de Trabalho\P\blue\exercicios_aulas\módulo_4\projetos\WebZap\Webzap\Views\Chat\Index.cshtml"
                                        Write(message.Datetime.ToString("dd/MM HH:mm"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</small>\r\n                </div>\r\n            </div>\r\n");
#nullable restore
#line 45 "C:\Users\guilh\OneDrive\Área de Trabalho\P\blue\exercicios_aulas\módulo_4\projetos\WebZap\Webzap\Views\Chat\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 45 "C:\Users\guilh\OneDrive\Área de Trabalho\P\blue\exercicios_aulas\módulo_4\projetos\WebZap\Webzap\Views\Chat\Index.cshtml"
         
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "081a26858636c69f7bc11dfd70ac599646e474648757", async() => {
                WriteLiteral(@"
    <div class=""input-group col-md-12 mb-4"" id=""MessageDiv"">
        <input name=""Text"" id=""MessageText"" placeholder=""pipipipopopopo...."" class=""form-control"" />
        <button type=""submit"" style=""margin-top:0px; margin-left:5px; padding:5px;"" id=""submitBtn"" class=""btn btn-info"">Enviar</button>
    </div>
");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n");
            DefineSection("scripts", async() => {
                WriteLiteral("\r\n    <script src=\"https://cdnjs.cloudflare.com/ajax/libs/microsoft-signalr/3.1.7/signalr.min.js\"></script>\r\n    <script src=\"https://cdn.jsdelivr.net/npm/axios/dist/axios.min.js\"></script>\r\n\r\n    <script>\r\n       var username = \"");
#nullable restore
#line 61 "C:\Users\guilh\OneDrive\Área de Trabalho\P\blue\exercicios_aulas\módulo_4\projetos\WebZap\Webzap\Views\Chat\Index.cshtml"
                  Write(username);

#line default
#line hidden
#nullable disable
                WriteLiteral("\";\r\n        var nomeusuario = \"");
#nullable restore
#line 62 "C:\Users\guilh\OneDrive\Área de Trabalho\P\blue\exercicios_aulas\módulo_4\projetos\WebZap\Webzap\Views\Chat\Index.cshtml"
                      Write(nome);

#line default
#line hidden
#nullable disable
                WriteLiteral("\";\r\n        var privateUrl = \"");
#nullable restore
#line 63 "C:\Users\guilh\OneDrive\Área de Trabalho\P\blue\exercicios_aulas\módulo_4\projetos\WebZap\Webzap\Views\Chat\Index.cshtml"
                     Write(privateMessageUrl);

#line default
#line hidden
#nullable disable
                WriteLiteral(@""";
        var objDiv = document.getElementById(""chat"");
        objDiv.scrollTop = objDiv.scrollHeight;

        var connection = new signalR.HubConnectionBuilder().withUrl(""/chathub"").build();

        function formataData(dateString) {
            var date = new Date(Date.parse(dateString));
            var dateStr =
                (""00"" + date.getDate()).slice(-2) + ""/"" +
                (""00"" + (date.getMonth() + 1)).slice(-2) + "" "" + 
                (""00"" + date.getHours()).slice(-2) + "":"" +
                (""00"" + date.getMinutes()).slice(-2);
            return dateStr;
        }

        connection.on(""ReceiveMessage"", (data) => {
            var position = data.userName === username ? ""text-right"" : ""text-left"";
            var alert = data.userName === username ? ""alert-info"" : ""alert-dark"";

            var message = document.createElement(""div"");
            message.className = ""row"";

            var messageCol = document.createElement(""div"");
            messageCol.cla");
                WriteLiteral(@"ssList = ""col-md-12 "" + position;

            var messageUser = document.createElement(""a"");
            messageUser.className = ""text-info"";
            messageUser.href = privateUrl + data.nomeUsuario;
            messageUser.textContent = data.nomeUsuario;

            var messageAlert = document.createElement(""div"");
            messageAlert.classList = ""alert mb-0 "" + alert;

            var messageAlertMessage = document.createElement(""div"");
            messageAlertMessage.className = ""d-block"";
            messageAlertMessage.innerHTML = data.text;

            var messageDt = document.createElement(""small"");
            messageDt.className = ""text-info"";
            messageDt.textContent = formataData(data.datetime);

            messageAlert.appendChild(messageAlertMessage);
            messageCol.appendChild(messageUser);
            messageCol.appendChild(messageAlert);
            messageCol.appendChild(messageDt);
            message.appendChild(messageCol);
            c");
                WriteLiteral(@"onsole.log(message);
            document.getElementById(""chat"").appendChild(message);
            objDiv.scrollTop = objDiv.scrollHeight;
        });

        connection.start().then(function () {
            console.log(""Connected"");
            document.getElementById(""SendMessageForm"").addEventListener(""submit"", function (event) {
                event.preventDefault();

                var data = {
                    Text: document.getElementById(""MessageText"").value,
                    UserName: username,
                    NomeUsuario: nomeusuario
                }

                document.getElementById(""MessageText"").value = """";

                connection.invoke(""sendMessage"", data).catch(function (err) {
                    return console.error(err.toString());
                });
            });
        }).catch(function (err) {
            return console.error(err.toString());
        });
    </script>
");
            }
            );
            WriteLiteral(" ");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Message> Html { get; private set; }
    }
}
#pragma warning restore 1591
