using CleanArchMvc.Aplication.DTOs;

namespace CleanArchMvc.Aplication.Interfaces
{
    public interface ICategoryService
    {
        Task<IEnumerable<CategoryDTO>> GetCategories();
        Task<CategoryDTO> GetById(int? id);
        Task Add(CategoryDTO categoryDto);
        Task Update(CategoryDTO categoryDto);
        Task Delete(int? id);

    }
}
