using System;
using System.Net;

namespace Penguin.Web.Abstractions.Interfaces
{
    public interface IWebClient : IDisposable
    {
        WebHeaderCollection Headers { get; }
        WebHeaderCollection ResponseHeaders { get; }

        string DownloadString(string url);

        string UploadString(string url, string data);

        string UploadString(string url, string method, string data);
    }
}