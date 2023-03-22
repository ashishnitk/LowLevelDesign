using System;
using System.Collections.Generic;

namespace FlyWeight
{
    class Order
    {
        private readonly List<OrderItem> _items;

        public Order()
        {
            _items = new List<OrderItem>();
        }

        public void Add(OrderItem item)
        {
            _items.Add(item);
        }

    }


    public enum ProductType
    {
        CPU, Memory, Motherboard, GPU, PowerSupply, Storage
    }

    public enum CpuSeries
    {
        IntelCoreI9,
        IntelCoreI7,
        AmdRyzen7,
        AmdRyzen9
    }



    public class FlyWeight
    {

        private static Random _random = new Random();

        private const int CPU_PURCHACE_COUNT = 100000000;

        static void Main(string[] args)
        {

            CpuProductFlyweightFactory c = new CpuProductFlyweightFactory();

            CpuOrderItemFactory cpuOrderItemFactory = new CpuOrderItemFactory(c);

            IEnumerable<Order> orders = new List<Order>();

            for (int i = 0; i < CPU_PURCHACE_COUNT; i++)
            {
                Order order = new Order();
                CpuSeries cpuSeries = GetRandomCpuSeries();
                OrderItem cpu = cpuOrderItemFactory.Create(cpuSeries, 2); //
                order.Add(cpu);
                orders.Add(order);
            }

            Console.WriteLine("Hello World!");
        }

        private static CpuSeries GetRandomCpuSeries()
        {
            return (CpuSeries)_random.Next(0, 3);
        }
    }

    internal class CpuOrderItemFactory
    {

        private CpuProductFlyweightFactory _cpuProdcutFactory;

        public CpuOrderItemFactory(CpuProductFlyweightFactory cpuProdcutFactory)
        {
            _cpuProdcutFactory = cpuProdcutFactory;
        }

        /// <summary>
        /// should be able to combine interinsic properties object and context
        /// </summary>
        /// <param name="cpuSeries"></param>
        /// <param name="quantity"></param>
        /// <returns></returns>
        internal OrderItem Create(CpuSeries cpuSeries, int quantity)
        {
            Product cpuProduct = _cpuProdcutFactory.Create(cpuSeries);
            return new OrderItem(cpuProduct, quantity);

        }
    }

    internal class CpuProductFlyweightFactory
    {
        private readonly Dictionary<CpuSeries, Product> _cpuSeriesToProduct;

        public CpuProductFlyweightFactory()
        {
            _cpuSeriesToProduct = new Dictionary<CpuSeries, Product>();
        }

        public Product Create(CpuSeries series)
        {
            if (!_cpuSeriesToProduct.ContainsKey(series))
            {
                switch (series)
                {
                    case CpuSeries.IntelCoreI9:
                        _cpuSeriesToProduct.Add(series, new Product("Intel Core i9", "A powerful intel CPU", ProductType.CPU, 500));
                        break;
                    case CpuSeries.IntelCoreI7:
                        _cpuSeriesToProduct.Add(series, new Product("Intel Core i7", "A intel CPU", ProductType.CPU, 300));
                        break;
                    case CpuSeries.AmdRyzen7:
                        _cpuSeriesToProduct.Add(series, new Product("Amd Ryzen 7", "A  AMD CPU", ProductType.CPU, 300));
                        break;
                    case CpuSeries.AmdRyzen9:
                        _cpuSeriesToProduct.Add(series, new Product("Amd Ryzen 9", "A powerful AMD CPU", ProductType.CPU, 500));
                        break;
                    default:
                        break;
                }
            }
            return _cpuSeriesToProduct[series];
        }

    }

    public class OrderItem
    {
        public Product Product { get; set; }
        public double Quantity { get; set; }

        public OrderItem(Product product, double quantity)
        {
            Product = product;
            Quantity = quantity;
        }
    }

    public class Product
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public ProductType Type { get; set; }
        public int Price { get; set; }

        public Product(string name, string description, ProductType type, int price)
        {
            this.Name = name;
            this.Description = description;
            this.Type = type;
            this.Price = price;
        }
    }


}