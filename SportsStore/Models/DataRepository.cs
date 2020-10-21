using System.Collections.Generic;

namespace SportsStore.Models {

    public class DataRepository : IRepository {
        // private List<Product> data = new List<Product>();
        private DataContext context;
        public DataRepository(DataContext ctx) => context = ctx;
        public IEnumerable<Product> Products => context.Products;

        //public IEnumerable<Product> Products => data;

        public void AddProduct(Product product) {
            this.context.Products.Add(product);
            this.context.SaveChanges();
        }
    }
}
