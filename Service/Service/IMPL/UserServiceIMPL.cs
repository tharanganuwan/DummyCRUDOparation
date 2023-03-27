using DomainLayer.Model;
using RepositoryLayer.DbContextLayer;
using ServiceLayer.Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Service.IMPL
{
    public class UserServiceIMPL : IUserService
    {
        private readonly AppDbContext _dbContext;
        public UserServiceIMPL(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        
        
        public string AddUserRepo(User user)
        {
            try
            {
                _dbContext.tblUser.Add(user);
                _dbContext.SaveChanges();

                return "success";
            }
            catch (Exception ex)
            {
                return $"Not success : {ex.Message}";
            }
            
        }

        public List<User> GetAllRepo()
        {
            return _dbContext.tblUser.ToList();
        }

        public User GetSingleRepo(long id)
        {
            //return _dbContext.tblUser.Find(id);
            return _dbContext.tblUser.Where(x => x.userId == id).FirstOrDefault();
        }

        public string RemoveUserRepo(long id)
        {
            try
            {
                var user = _dbContext.tblUser.Find(id);
                _dbContext.tblUser.Remove(user);
                _dbContext.SaveChanges();
                return "success remove";
            }
            catch (Exception ex)
            {
                return $"Error : {ex.Message}";
            }
           
        }

        public string UpdateUserRepo(User user)
        {
            try
            {
                if (user == null)
                {
                    return "User cannot be null";
                }

                var userValue = _dbContext.tblUser.Find(user.userId);
                if (userValue == null)
                {
                    return "User not found";
                }

                // validate input before updating
                if (!string.IsNullOrEmpty(user.userName))
                {
                    userValue.userName = user.userName;
                }

                if (!string.IsNullOrEmpty(user.userEmailId))
                {
                    userValue.userEmailId = user.userEmailId;
                }

                if (!string.IsNullOrEmpty(user.userPhone))
                {
                    userValue.userPhone = user.userPhone;
                }

                if (!string.IsNullOrEmpty(user.userAddress))
                {
                    userValue.userAddress = user.userAddress;
                }

                // save changes to the database
                _dbContext.SaveChanges();

                return "User updated successfully";
            }
            catch (Exception ex)
            {
                // log the error message for debugging purposes
                Console.WriteLine($"Error updating user: {ex.Message}");

                // return a user-friendly error message to the client
                return "An error occurred while updating the user";
            }
        }
    }
}
