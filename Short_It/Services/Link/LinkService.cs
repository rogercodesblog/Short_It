﻿using Short_It.Data;
using Short_It.DTOs.Link;

namespace Short_It.Services.Link
{
    public class LinkService : ILinkService
    {
        private readonly ShortItAppContext _database;
        public LinkService(ShortItAppContext database)
        {
            _database = database;
        }
        public Task<ServiceResponse<LinkDTO>> AddLinkAsync(CreateLinkDTO createLinkDTO)
        {
            throw new NotImplementedException();
        }

        public Task<ServiceResponse<LinkDTO>> DeleteLinkAsync(LinkDTO linkDTO)
        {
            throw new NotImplementedException();
        }

        public Task<ServiceResponse<LinkDTO>> GetLinkByShortUrlAsync(string shortUrl)
        {
            throw new NotImplementedException();
        }
    }
}
