using System.Threading.Tasks;

namespace Telex.Business.Services.Interfaces
{
    public interface ITelegramService
    {
        Task<string> Connect();
        Task SendCode();
        Task AuthUser();
        Task GetChatList();
        Task GetChat();
        Task GetChatInfo();
        Task GetChannelUsers();
        Task SendMessage();

    }
}
