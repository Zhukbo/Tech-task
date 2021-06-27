using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Task7.Core.Services
{
    public interface ILinkService
    {
        Task<string> CreateShortLink(string originalLink, string host);
        Task IncreaseTransitionCount(string shortLink);
        Task<string> GetShortLink(string originalLink);
        Task<int> GetTransitionCount(string link, DateTime startTime, DateTime endTime);
    }
}
