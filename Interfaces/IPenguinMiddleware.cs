using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;

namespace Penguin.Web.Abstractions.Interfaces
{
    public interface IPenguinMiddleware
    {
        Task Invoke(HttpContext context);
    }
}