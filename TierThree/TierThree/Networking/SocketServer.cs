using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Text.Json;
using System.Threading;
using TierThree.Networking.Item;
using TierThree.Networking.User;

namespace TierThree.Networking
{
    public class SocketServer
    {
        private static List<TcpClient> connected;
        private UserHandler _userHandler;
        private AdministratorHandler _administratorHandler;

        public SocketServer()
        {
            connected = new List<TcpClient>();
            _userHandler = new UserHandler();
            _administratorHandler = new AdministratorHandler();
        }

        public void StartServer()
        {
            Console.WriteLine("Starting server ...");
            TcpListener tcpListener = new TcpListener(IPAddress.Parse("127.0.0.1"), 8070);
            tcpListener.Start();

            Console.WriteLine("Server started ...");

            while (true)
            {
                TcpClient tcpClient = tcpListener.AcceptTcpClient();
                connected.Add(tcpClient);
                Console.WriteLine("Client connected!!!!!");

                new Thread(() => Handler(tcpClient)).Start();
            }
        }

        private void Handler(TcpClient tcpClient)
        {
            NetworkStream stream = tcpClient.GetStream();

            while (true)
            {
                try
                {
                    byte[] data = new byte[1024 * 1024];
                    int bytesToRead = stream.Read(data, 0, data.Length);
                    string request = Encoding.ASCII.GetString(data, 0, bytesToRead);
                    NetworkRequest request1 = JsonSerializer.Deserialize<NetworkRequest>(request);

                    Console.WriteLine(request1.Content);
                    Console.WriteLine(request1.NetworkType);

                    switch (request1.NetworkType)
                    {

                        case "GETUSERS":
                            _userHandler.GetUsersById(stream, request1.Content);
                            break;
                        case "GETPRODUCT":
                            _userHandler.GetUsersById(stream, request1.Content);
                            break;
                        case "EDIT":
                            _userHandler.Edit(stream, request1.Content);
                            break;
                        case "DELETEUSER":
                            _userHandler.DeleteUser(request1.Content);
                            break;


                        default:
                            string reply = JsonSerializer.Serialize("confirmation from tier3");
                            Console.WriteLine("It is: " + reply);
                            byte[] bytesWrite = Encoding.ASCII.GetBytes(reply);
                            stream.Write(bytesWrite, 0, bytesWrite.Length);
                            break;
                    }

                    stream.Close();
                    break;
                }
                catch (IOException e)
                {
                    connected.Remove(tcpClient);
                }
            }
        }
    }
}