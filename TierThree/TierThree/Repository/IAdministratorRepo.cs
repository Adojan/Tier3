using System.Collections.Generic;
using System.Threading.Tasks;
using TierThree.Model;

namespace TierThree.Repository
{
    public interface IAdministratorRepo
    {
        Task<ItemModel> CreateItem(ItemModel item);
        Task<List<UserModel>> GetUsers(string userName);
        Task DeleteUser(int userId);
        Task DeleteItem(int itemId);
        Task<string> EditUser(UserModel userEdit);
        Task<string> EditItem(ItemModel itemEdit);
        
    }
}