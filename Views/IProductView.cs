using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermarket_mvp.Views
{
    internal interface IProductView
    {
        void ShowProducts(List<ProductModel> products);
        void ShowErrorMessage(string message);
    }
}
