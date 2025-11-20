public class ProductPriceSort
{
    public static void Main(string[] args)
    {
        // Извеждане на кирилица в конзолата
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        // Цени на стоки/суровини от различен доставчик/партида
        double[] productPrices = { 108.50, 42.15, 95.00, 15.30, 201.75 };
        int n = productPrices.Length;

        Console.WriteLine("Несортирани цени на стоки:");

        foreach (double price in productPrices)
        {
            Console.Write(price + " лв. ");
        }
        Console.WriteLine();

        // Bubble Sort - метод на мехурчето
        for (int i = 0; i < n - 1; i++)
        {
            for (int j = 0; j < n - i - 1; j++)
            {
                if (productPrices[j] > productPrices[j + 1])
                {
                    double temp = productPrices[j];
                    productPrices[j] = productPrices[j + 1];
                    productPrices[j + 1] = temp;
                }
            }
        }

        Console.Write("\n Сортирани цени (от най-ниска към най-висока): \n");
    
        foreach (double price in productPrices) { 
            
            Console.Write(price + " лв. "); }
        
    }
}