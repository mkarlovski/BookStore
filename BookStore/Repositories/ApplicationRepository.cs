using BookStore.Data;
using BookStore.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore.Repositories
{
    public class ApplicationRepository: IApplicationRepository
    {
        private readonly BookStoreDbContext context;

        public ApplicationRepository(BookStoreDbContext context)
        {
            this.context = context;
        }

        public Application GetByApiKey(string apiKey)
        {
            return context.Applications.FirstOrDefault(x => x.ApiKey.Equals(apiKey));
        }
    }
}
