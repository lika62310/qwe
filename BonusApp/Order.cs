using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace BonusApp
{
    public class Order
    {
        public BonusProvider Bonus { get; set; }
        private List<Product> _products = new List<Product>();

        public void AddProduct(Product p)
        {
            _products.Add(p);
        }

        public double GetValueOfProducts()
        {
            double valueOfProducts = _products.Sum(product => product.Value);
            //foreach (Product product in _products)
            //{
            //    valueOfProducts += product.Value;
            //}
            return valueOfProducts;
        }

        public double GetValueOfProducts(DateTime date)
        {

            ////var valueOfProducts = _products 
            ////    .Where(product => product.AvailableFrom <= date && date <= product.AvailableTo)
            ////    .Sum(product => product.Value);

            //double valueOfProducts = _products.Sum(p => p.Value ? p.AvailableFrom <= date && );
            double valueOfProducts = _products.Sum(p => p.AvailableFrom <= date && date <= p.AvailableTo ? p.Value : 0);

            //foreach (Product product in _products)
            //{
            //    valueOfProducts += product.Value;
            //}
            return valueOfProducts;
        }

        public double GetBonus()
        {
            return Bonus(GetValueOfProducts());
        }

        public double GetBonus(DateTime date, Func<double, double> bonus)
        {
            return bonus(GetValueOfProducts(date));
        }


        public double GetTotalPrice()
        {
            return GetValueOfProducts() - GetBonus();
        }

        public double GetTotalPrice(DateTime date, Func<double, double> bonus)
        {
            return GetValueOfProducts(date) - GetBonus(date, bonus);
        }

        public List<Product> SortProductOrderByAvailableTo()
        {
            var sortedlist = _products.OrderBy(product => product.AvailableTo).ToList();
            return sortedlist;
        }

        public List<Product> SortProductOrderBy(Func<Product, object> keySelector)
        {
            var sortedlist = _products.OrderBy(keySelector).ToList();
            return sortedlist;
        }


    }
}
