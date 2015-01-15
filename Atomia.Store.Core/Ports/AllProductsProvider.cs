﻿using System.Collections.Generic;

namespace Atomia.Store.Core
{
    public abstract class AllProductsProvider : IProductsProvider
    {
        public abstract IEnumerable<Product> GetProducts(ProductSearchQuery searchQuery);
    }
}
