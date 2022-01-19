using BasicHttpServer.Server.HTTP;

namespace BasicHttpServer.Server.Responses
{
    public class NotFoundResponse : Response
    {
        public NotFoundResponse()
            : base(StatusCode.NotFound)
        {

        }
    }
}