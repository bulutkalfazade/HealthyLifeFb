using Business.Concrete;
using Business.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class UserManager : IUserService
    {
        IUserDal _userDal; 
        
        client=new FireSharp.FirebaseClient(config);
        public UserManager(IUserDal userDal)
        {
            if (client != null)
            {
                _userDal = userDal;
            }
            else
            {
                
            }
            
        }

        public  void Add (User user)
        {
            if (expr)
            {
                
            }
            _userDal.Add(user);
            
        }

        public void Delete(User user)
        {
            _userDal.Delete(user);
            
        }

        public List<User> GetAll()
        {
             return _userDal.GetAll();
        }
    }
}
