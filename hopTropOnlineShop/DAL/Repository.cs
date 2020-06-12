using hopTropOnlineShop.Models;
using Microsoft.EntityFrameworkCore;
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

        public void CreateCloth(Cloth cloth)
        {
            _context.Clothes.Add(cloth);
            _context.SaveChanges();
        }
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

        public List<Cloth> GetClothesByPattern(string pattern)
        {
            List<Cloth> patternCloth = _context.Clothes.Where(x => x.TypeOfCloth.Contains(pattern)).ToList();
            return patternCloth;
        }

        public List<User> GetAllUsers()
        {
            List<User> users = _context.Users.ToList();
            return users; 
        }

        public void DeleteUserByID(int id)
        {
            User user = (User)_context.Users.FirstOrDefault(x => x.IDUser == id);
            if (user != null)
            {
                _context.Entry(user).State = EntityState.Deleted;
                _context.SaveChanges();
            }
        }

        public void SetUserToAdminByID(int id)
        {
            User user = (User)_context.Users.FirstOrDefault(x => x.IDUser == id);
            if (user != null)
            {
                user.IsAdministrator = true;
                _context.SaveChanges();
            }
        }

    }
}

