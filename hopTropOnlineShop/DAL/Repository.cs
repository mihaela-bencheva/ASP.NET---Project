using hopTropOnlineShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace hopTropOnlineShop.DAL
{
    public class Repository : IRepository
    {
        OnlineShopContext _context;
        public Repository(OnlineShopContext context)
        {
            _context = context;
        }

        // public bool CreateCloth(Cloth cloth)
        // {
        //     _context.Clothes.Add(cloth);
        //     _context.SaveChanges();
        //     return true;
        // }

        // public bool CreateUser(User user)
        // {
        //     _context.Users.Add(user);
        //     _context.SaveChanges();
        //     return true;
        // }

        //// public List<Cloth> Test() => _context.Clothes.Where(x => x.UserId == 2).ToList();

        // public List<User> GetAllUser()
        // {
        //     var users_con = _context.Users;
        //     List<User> users = users_con.ToList();
        //     return users;
        // }
        public Cloth GetClothById(int id)
        {
            Cloth cloth = _context.Clothes.FirstOrDefault(x => x.IDCloth == id);
            return cloth;
        }

        public List<Cloth> GetAllClothes()
        {
            List<Cloth> clothes = _context.Clothes.ToList();
            return clothes;
        }

        public void addCustomer(Customer customer)
        {
            _context.Customers.Add(customer);
            _context.SaveChanges();
        }

        public List<User> GetUserByUsername(string username)
        {
            List<User> users = _context.Users.Where(x => x.Username == username).ToList();
            return users;
        }

        public void CreateUser(User user)
        {
            _context.Users.Add(user);
            _context.SaveChanges();
        }

        public User GetUserByID(int id)
        {
            User user = _context.Users.Where(x => x.IDUser == id).FirstOrDefault();
            return user;
        }



        //public bool IsUserAuthenticated(byte[] userIdentity)
        //{
        //    if (userIdentity != null)
        //    {
        //        return _context.Users.Any(u => u.Identity == new Guid(userIdentity));
        //    }
        //    else
        //    {
        //        return false;
        //    }
        //}

        //public User GetUserByIdentity(Guid guid)
        //    => _context.Users.Where(x => x.Identity == guid).SingleOrDefault();

        //public List<Restaurant> GetAllRestaurants()
        //    => _context.Restaurants.ToList();
    }
}

