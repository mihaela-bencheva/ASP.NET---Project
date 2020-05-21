using hopTropOnlineShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace hopTropOnlineShop.DAL
{
    public interface IRepository
    {
       // public bool CreateCloth(Cloth cloth);
        public void CreateUser(User user);
        public User GetUserByID(int id);
       // public List<User> GetAllUser();
        public Cloth GetClothById(int id);
        public List<Cloth> GetAllClothes();
        public void addCustomer(Customer customer);
        public List<User> GetUserByUsername(string username);
    }
}
