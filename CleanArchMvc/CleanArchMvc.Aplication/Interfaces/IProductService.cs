using CleanArchMvc.Aplication.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchMvc.Aplication.Interfaces
{
    public interface IProductService
    {
        Task<IEnumerable<ProductDTO>> GetProducts();
        Task<ProductDTO> GetById(int? id);
        Task Add(ProductDTO productDto);
        Task Update(ProductDTO productDto);
        Task Delete(int? id);
    }
}
