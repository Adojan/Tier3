using System;
using System.Net.Sockets;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using TierThree.Model;
using TierThree.Repository;


namespace TierThree.Networking.User
{
    public class UserHandler
    {
        private UserModel _user;
        private IUserRepo _userRepository;

        public UserHandler()
        {
            _user = new UserModel();
            _userRepository = new UserRepo();
        }

        public async void MyUser(NetworkStream stream, string content)
        {
            UserModel actor = JsonSerializer.Deserialize<UserModel>(content);
            string username = actor.userName;
            string password = actor.password;
            _user = await _userRepository.GetUser(username, password);
            string reply = JsonSerializer.Serialize(_user);
            byte[] bytesWrite = Encoding.ASCII.GetBytes((reply));
            stream.Write(bytesWrite, 0, bytesWrite.Length);
        }

        public async void Register(NetworkStream stream, string content)
        {
            UserModel actor= JsonSerializer.Deserialize<UserModel>(content)
            string input = await _userRepository.CreateUser(actor);
            string reply = JsonSerializer.Serialize(input);
            byte[] bytesWrite = Encoding.ASCII.GetBytes(reply);
            stream.Write(bytesWrite,0,bytesWrite.Length);
        }

        public async void Edit(NetworkStream stream, string content)
        {
            UserModel actor = JsonSerializer.Deserialize<UserModel>(content);
            string input = await _userRepository.EditUser(actor);
            string reply = JsonSerializer.Serialize(input);
            byte[] bytesWrite = Encoding.ASCII.GetBytes(reply);
            stream.Write(bytesWrite,0,bytesWrite.Length);
        }

        
        //Problem here.
        public async Task DeleteUser(string content)
        {
            await _userRepository.DeleteUser(Int32.Parse(content));
        }

        public async void GetUsersById(NetworkStream stream, string contentX)
        {
            UserModel userModel = await _userRepository.GetUserById(Int32.Parse(contentX));
            string reply = JsonSerializer.Serialize(userModel);
            byte[] bytesWrite = Encoding.ASCII.GetBytes(reply);
            stream.Write(bytesWrite, 0, bytesWrite.Length);
        }



    }
}