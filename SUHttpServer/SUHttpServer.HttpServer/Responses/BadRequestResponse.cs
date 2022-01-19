using BasicHttpServer.Server.HTTP;

namespace BasicHttpServer.Server.Responses
{
    public class BadRequestResponse : Response
    {
        public BadRequestResponse()
            : base(StatusCode.BadRequest)
        {

        }
    }
}