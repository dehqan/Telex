using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telex.Business.Services.Interfaces;

namespace Telex.Business.Services
{
    public class TelegramService : ITelegramService
    {
        public async Task<string> Connect()
        {
            return "HELLO";
        }

        public Task SendCode()
        {
            throw new NotImplementedException();
        }

        public Task AuthUser()
        {
            throw new NotImplementedException();
        }

        public Task GetChatList()
        {
            throw new NotImplementedException();
        }

        public Task GetChat()
        {
            throw new NotImplementedException();
        }

        public Task GetChatInfo()
        {
            throw new NotImplementedException();
        }

        public Task GetChannelUsers()
        {
            throw new NotImplementedException();
        }

        public Task SendMessage()
        {
            throw new NotImplementedException();
        }
    }
}
