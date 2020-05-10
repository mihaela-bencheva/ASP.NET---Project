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
       // public bool CreateUser(User user);
       // public List<User> GetAllUser();
       // public List<Cloth> GetClothesById(int id);
        public List<Cloth> GetAllClothes();
    }
}
