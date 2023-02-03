using CleanArchMvc.Domain.Entities;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CleanArchMvc.Aplication.DTOs
{
    public class ProductDTO
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "The Name is Required")]
        [MinLength(3)]
        [MaxLength(100)]
        [DisplayName("Nome")]
        public string Name { get; set; }

        [Required(ErrorMessage = "The Description is Required")]
        [MinLength(5)]
        [MaxLength(200)]
        [DisplayName("Descrição")]
        public string Description { get; set; }

        [Required(ErrorMessage = "The Price is Required")]
        [Column(TypeName = "decimal(18,2")]
        [DisplayFormat(DataFormatString = "R$ {0:C2}")]
        [DataType(DataType.Currency)]
        [DisplayName("Preço")]
        public string Price { get; set; }

        [Required(ErrorMessage = "The Stock is required")]
        [Range(1, 9999)]
        [DisplayName("Estoque")]
        public int Stock { get; set; }

        [MaxLength(250)]
        [DisplayName("Imagem do Produto")]
        public string Image { get; set; }

        //public Category category { get; set; }

        [DisplayName("Categoria")]
        public int CategoryId { get; set; }
    }   
}
