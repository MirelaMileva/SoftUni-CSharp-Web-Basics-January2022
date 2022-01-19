using BasicHttpServer.Server.HTTP;
using System;

namespace BasicHttpServer.Server.Responses
{
    public class TextResponse : ContentResponse
    {
        public TextResponse(string text,
            Action<Request, Response> preRenderAction = null)
            : base(text, ContentType.PlainText, preRenderAction)
        {

        }
    }
}