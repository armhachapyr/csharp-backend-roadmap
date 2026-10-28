namespace Lesson2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product("Milk", 1, 10);
            Product product2 = new Product("Bread", 2, 5);
            product1.AddStock(5);
            product2.AddStock(5);
            product2.Sell(2);
            Console.WriteLine(product1.GetInfo());
            Console.WriteLine(product2.GetInfo());
            Order order = new Order();
            order.AddProduct(product1);
            order.AddProduct(product2);
            Console.WriteLine($"Total Price: {order.Total}");
            Console.WriteLine(order.CreatedAt);
            try
            {
                Product product3 = new Product("Eggs", 3, 0);
                order.AddProduct(product3);
                order.AddProduct(null);
                Product product4 = new Product("", 4, 5);

            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Unexpected error: {ex.Message}");
            }
            //product1.Stock = 100; свойство Stock имеет модификатор доступа private set, поэтому его нельзя изменить напрямую из вне класса Product.
            //order.Items.Add(product1); свойство Items имеет модификатор доступа private set, поэтому его нельзя изменить напрямую из вне класса Order.
        }
    }
}
