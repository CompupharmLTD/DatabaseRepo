using CompupharmLtd.Data;
using CompupharmLtd.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CompupharmLtd.Service
{
    public class ProductService
    {
        internal static ProductResponse GetProductByID(int id)
        {
            throw new NotImplementedException();
        }

        internal static ProductListResponse GetAllProduct(string status)
        {
            ProductListResponse productList = new ProductListResponse();
            List<Product> product = new List<Product>();
            product = ProductData.ProductList(status);
            if (product != null) {
                productList.statusCode=00;
                productList.status="Successful";
                productList.product = product;

            }
            else
            {
                productList.statusCode = 01;
                productList.status = "Unsuccessful";
                productList.product = null;

            }

            return productList;
        }

        internal static ProductResponse DeleteProduct(int id)
        {
            throw new NotImplementedException();
        }

        internal static ProductResponse EditProduct(Product id)
        {
            throw new NotImplementedException();
        }

        internal static ProductResponse CreateProduct(Product id)
        {
            throw new NotImplementedException();
        }
    }
}
