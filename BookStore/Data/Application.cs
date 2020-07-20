using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore.Data
{
    public class Application
    {
        public int Id { get; set; }
        public string ApiKey { get; set; }
        public string Name { get; set; }
        public DateTime DateCreated { get; set; }
    }
}
