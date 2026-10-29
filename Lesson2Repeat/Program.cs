namespace Lesson2Repeat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product(1, "Bread", 10.99m);
            Product product2 = new Product(2, "Milk", 5.49m);
            product1.AddStock(10);
            product1.Sell(2);
            Console.WriteLine(product1.GetInfo());
            Console.WriteLine(product2.GetInfo());

            Order order1 = new Order();
            order1.AddProduct(product1);
            
            try
            {
                order1.AddProduct(product2);
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }

            try
            {
                product2.Sell(10);
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
            try
            {
                product1.ChangePrice(-200);
            } catch(ArgumentOutOfRangeException ex)
            {
                Console.WriteLine($"Error:  {ex.Message}");
            }
            try
            {
                Product product3 = new Product(3, "", 15.99m);

            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
            try
            {
                order1.AddProduct(null);
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
            //product1.Stock=500;
            //order1.Items.Add(product1);
            Console.WriteLine(order1.Total);
            Console.WriteLine(order1.CreatedAt);

        }
    }
}
