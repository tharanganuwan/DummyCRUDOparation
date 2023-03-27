using DomainLayer.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Service.Interface
{
    public interface IUserService
    {
        //GetAll Record
        List<User> GetAllRepo();

        //GetSingle Record
        User GetSingleRepo(long id);

        //Add Record
        string AddUserRepo(User user);

        //Update or Edit Record
        string UpdateUserRepo(User user);

        //Delete or Remove
        string RemoveUserRepo(long id);
    }
}
