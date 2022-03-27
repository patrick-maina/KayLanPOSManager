using KayLanPOSDesktopUI.Models;
using System.Threading.Tasks;

namespace KayLanPOSDesktopUI.Helper
{
    public interface IApiHelper
    {
        Task<AuthenticatedUser> Authenticate(string userName, string password);
    }
}