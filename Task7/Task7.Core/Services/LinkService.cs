using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task7.Core.Entities;
using Task7.Core.Repositories;

namespace Task7.Core.Services
{
    public class LinkService : ILinkService
    {
        private const int DEFAULT_STRING_LENGTH = 20;
        private readonly ITransitionRepository _transitionRepository;
        private readonly ILinkRepository _linkRepository;

        public LinkService(ITransitionRepository transitionRepository,
            ILinkRepository linkRepository)
        {
            _transitionRepository = transitionRepository;
            _linkRepository = linkRepository;
        }
        public async Task<string> CreateShortLink(string originalLink, string host)
        {

            string shrtLink = $"{host}/{CreateRandomString()}";
            var newEntity = new Link
            {
                CreationTime = DateTime.UtcNow,
                OriginalLink = originalLink,
                ShortLink = shrtLink
            };
            await _linkRepository.Insert(newEntity);
            return shrtLink;
        }

        public async Task<string> GetShortLink(string originalLink)
        {
            var link = await _linkRepository.SingleOrDefault(x => x.OriginalLink == originalLink);
            if (link == null)
            {
                //throw NotFoundException()
            }
            return link.ShortLink;
        }

        public async Task<int> GetTransitionCount(string shortLink, DateTime startTime, DateTime endTime)
        {
            var link = await _linkRepository.SingleOrDefault(x => x.ShortLink == shortLink);

            if (link == null)
            {
                //throw NotFoundException()
            }

            return _transitionRepository
                .GetList(x => x.LinkId == link.Id
                    && DateTime.Compare(x.TransitionDate, startTime) >= 0
                    && DateTime.Compare(x.TransitionDate, endTime) < 0).Count();
        }

        public async Task IncreaseTransitionCount(string shortLink)
        {
            var link = await _linkRepository.SingleOrDefault(x => x.ShortLink == shortLink);

            if (link == null)
            {
                //throw NotFoundException()
            }

            var newEntity = new Transition
            {
                LinkId = link.Id,
                TransitionDate = DateTime.UtcNow
            };
            await _transitionRepository.Insert(newEntity);
        }
        private string CreateRandomString(int length = DEFAULT_STRING_LENGTH)
        {
            return Guid.NewGuid().ToString("n").Substring(0, length);
        }
    }
}
