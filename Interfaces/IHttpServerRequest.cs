namespace Penguin.Web.Abstractions.Interfaces
{
    public interface IHttpServerRequest : IHttpInteractionBase
    {
        string Method { get; }

        string Url { get; }
    }
}