﻿
using eShopSolution.ViewModels.Catalog.Product;
using eShopSolution.ViewModels.Common;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using eShopSolution.ViewModels.Catalog.ProductImages;

namespace eShopSolution.Application.Catalog.Products
{
    //interface
    public interface IManagedProductService
    {
        // dinh nghia phuong thuc
        //tra ve ma san pham vua tao
        Task<int> Create(ProductCreateRequest request);

        Task<int> Update(ProductUpdateRequest request);

        Task<int> Delete(int productId);

        Task<bool> UpdatePrice(int productId, decimal newPrice);

        Task<bool> UpdateStock(int productId, int addedQuantity);
        Task AddViewcount(int productId);

        Task<int> AddImage(int productId, ProductImageCreateRequest request);

        Task<int> UpdateImage(int imageId, ProductImageUpdateRequest request);

        Task<ProductImageViewModel> GetImageById(int imageId);

        Task<List<ProductImageViewModel>> GetListImages(int productId);

        Task<int> RemoveImage(int imageId);
        //truyen 1 so request 
        Task<PagedResult<ProductViewModel>> GetAllPaging(GetManageProductPagingRequest request);
    }
}
