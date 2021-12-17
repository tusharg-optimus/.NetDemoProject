using EFCodeFirstApproach.DataAccess.Entity;
using EFCodeFirstApproach.Repository.Interfaces;
using EFCodeFirstApproach.Service.Interfaces;
using EFCodeFirstApproach.Utils.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCodeFirstApproach.Service.Implementations
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;
        public ProductService(IProductRepository productRepository)
        {
                _productRepository = productRepository;
        }
        public async Task<ProductDTO> Add(ProductDTO obj)
        {
            //Mapping from ProductDTO to Product
            var product = new Product
            {
                Id = obj.Id,
                ProductName = obj.ProductName,
                ProductAmount = obj.ProductAmount,
                ProductQuantity = obj.ProductQuantity
            };
            var result = await _productRepository.Add(product);
            var productDTO = new ProductDTO
            {
                //Mapping from Product to ProductDTO
                Id = result.Id,
                ProductName = result.ProductName,
                ProductAmount = result.ProductAmount,
                ProductQuantity = result.ProductQuantity
            };
            return productDTO;
        }

        public async Task<IEnumerable<ProductDTO>> GetAll()
        {
            List<ProductDTO> listProductDTOs = new List<ProductDTO>();
            var result = await _productRepository.GetAll();
            foreach (var item in result)
            {
                //Mapping from product to productDto
                var productDto = new ProductDTO
                {
                    Id = item.Id,
                    ProductName = item.ProductName,
                    ProductAmount = item.ProductAmount,
                    ProductQuantity = item.ProductQuantity
                };
                listProductDTOs.Add(productDto);
            }
            return listProductDTOs;
        }
    }
}
