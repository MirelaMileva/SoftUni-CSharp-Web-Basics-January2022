using BasicHttpServer.Server.HTTP;

namespace BasicHttpServer.Server.Responses
{
    public class HtmlResponse : ContentResponse
    {
        public HtmlResponse(string text)
            : base(text, ContentType.Html)
        {

        }
    }
}