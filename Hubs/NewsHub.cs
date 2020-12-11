using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewsForum.Hubs
{
    [Route("news")]
    public class NewsHub: Hub
    {
        public async Task Update(string author, string category)
        {
            await this.Clients.All.SendAsync("Update", author, category);
        }
    }
}
