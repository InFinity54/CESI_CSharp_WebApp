using CESI_CSharp_WebApp.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;

namespace CESI_CSharp_WebApp.Data
{
    class DataUtilisateur
    {
        private static DataUtilisateur instance = null;
        public Collection<User> usersList = new Collection<User>();

        public static DataUtilisateur getInstance()
        {
            if (instance == null)
            {
                User user1 = new User();
                user1.Id = 1;
                user1.FirstName = "John";
                user1.LastName = "DOE";

                User user2 = new User();
                user1.Id = 2;
                user2.FirstName = "Tony";
                user2.LastName = "STARK";

                instance = new DataUtilisateur();

                instance.usersList.Add(user1);
                instance.usersList.Add(user2);
            }

            return instance;
        }
    }
}
