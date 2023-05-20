using System.Threading.Tasks;
using HomeApp.Data.Tables;

namespace HomeApp.Data
{
    public interface IHomeDeviceRepository
    {
        Task<int> AddHomeDevice(HomeDevice homeDevice);
        Task<int> DeleteHomeDevice(HomeDevice homeDevice);
        Task<HomeDevice> GetHomeDevice(int id);
        Task<HomeDevice[]> GetHomeDevices();
        Task InitDatabase();
        Task<int> UpdateHomeDevice(HomeDevice homeDevice);
    }
}