using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermarket_mvp.Product
{
    public partial class IProductRepository : Component
    {
        public IProductRepository()
        {
            InitializeComponent();
        }

        public IProductRepository(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }
    }
}
