using System;
using System.Net;

namespace Penguin.Web.Abstractions
{
    public interface IWebClient : IDisposable
    {
        WebHeaderCollection Headers { get; }
        WebHeaderCollection ResponseHeaders { get; }

        string DownloadString(string url);

        string UploadString(string url, string data);
    }
}