using System;
using System.Collections.Generic;
using System.Net.Sockets;
using TierThree.Model;
using TierThree.Repository;


namespace TierThree.Networking.Item
{
    public class AdministratorHandler
    {
        private AdministratorModel adminModel;
        private IAdministratorRepo adminRepo;

        public AdministratorHandler()
        {
            adminModel = new AdministratorModel();
            adminRepo = new AdminRepo();
        }
        
    }
}