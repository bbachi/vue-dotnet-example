using System;
using System.Collections.Generic;

namespace vue_dotnet_example.Models
{
    public interface IUserRepository
    {
        IEnumerable<UserModel> GetAll();
        
        UserModel Add(UserModel user);
    }
}