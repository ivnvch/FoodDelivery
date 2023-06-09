using FoodDelivery.DAL.Entity;
using FoodDelivery.Models.Entity.DTO;
using FoodDelivery.Models.Repsonse;
using FoodDelivery.Models.ViewModel.DishViewModel;

namespace FoodDelivery.Service.Interfaces
{
    public interface IDishService
    {
        Task<IBaseResponse<Dish>> Create(DishCreateDTO dishCreateDTO);
        Task<IBaseResponse<bool>> Update(DishUpdateDTO dishUpdateDTO);
        Task<IBaseResponse<bool>> Delete(int id);
        Task<IBaseResponse<IEnumerable<DishViewModel>>> GetAll();
    }
}
