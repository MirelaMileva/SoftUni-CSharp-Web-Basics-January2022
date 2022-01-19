using BasicHttpServer.Server.HTTP;

namespace BasicHttpServer.Server.Responses
{
    public class UnauthorizedResponse : Response
    {
        public UnauthorizedResponse()
            : base(StatusCode.Unauthorized)
        {

        }
    }
}