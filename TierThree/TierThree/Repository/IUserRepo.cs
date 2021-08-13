using System.Threading.Tasks;
using TierThree.Model;

namespace TierThree.Repository
{
    public interface IUserRepo
    {
        Task<string> CreateUser(UserModel user);
        Task<ItemModel> CreateItem(ItemModel item);
        Task<UserModel> ValidateUser(UserModel user);
        Task<UserModel> GetUserById(int userId);
        Task DeleteUser(int userId);
        Task DeleteItem(int itemId);
        Task<string> EditUser(UserModel userEdit);
        Task<string> EditItem(ItemModel itemEdit);
    }
}