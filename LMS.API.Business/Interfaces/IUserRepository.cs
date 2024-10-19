﻿using APL.API.Extensions.Repository;
using APL.API.Extensions.Service.GenericRequestObjects;

using LMS.API.DataModel;
using LMS.API.ViewModel;

namespace LMS.Repository.Business.Interfaces
{
    public interface IUserRepository 
    {
        UserDM Add(UserVM input);
        UserDM Login(AuthenticationObject authenticationObject);

    }
}