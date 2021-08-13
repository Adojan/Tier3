using System;
using System.Threading.Tasks;
using TierThree.DataAccess;
using TierThree.Model;

namespace TierThree.Repository
{
    public class UserRepo  : IUserRepo
    {
        private PokemonContext context;
        
        public  Task<string> CreateUser(UserModel user)
        {
            return null;
        }

        public Task<ItemModel> CreateItem(ItemModel item)
        {
            throw new System.NotImplementedException();
        }

        public Task<UserModel> ValidateUser(UserModel user)
        {
            throw new System.NotImplementedException();
        }

        public Task<UserModel> GetUserById(int id)
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