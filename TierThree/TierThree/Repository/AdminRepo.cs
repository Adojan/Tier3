using System.Collections.Generic;
using System.Threading.Tasks;
using TierThree.DataAccess;
using TierThree.Model;

namespace TierThree.Repository
{
    public class AdminRepo : IAdministratorRepo
    {
        private PokemonContext context;
        

        public Task<ItemModel> CreateItem(ItemModel item)
        {
            throw new System.NotImplementedException();
        }

        public Task<List<UserModel>> GetUsers(string userName)
        {
            throw new System.NotImplementedException();
        }

        public Task DeleteUser(int userId)
        {
            throw new System.NotImplementedException();
        }

        public Task DeleteItem(int itemId)
        {
            throw new System.NotImplementedException();
        }

        public Task<string> EditUser(UserModel userEdit)
        {
            throw new System.NotImplementedException();
        }

        public Task<string> EditItem(ItemModel itemEdit)
        {
            throw new System.NotImplementedException();
        }
    }
}