﻿using FoodDelivery.DAL.Entity;
using FoodDelivery.Models.Repsonse;
using FoodDelivery.Models.ViewModel.User;

namespace FoodDelivery.Service.Interfaces
{
    public interface IUserService
    {
        Task<IBaseResponse<IEnumerable<UserViewModel>>> GetUsers();
        Task<IBaseResponse<bool>> DeleteUser(int id);
        Task<User> GetUser(string userToken);
    }
}
