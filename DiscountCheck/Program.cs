
/* 
    Да се провери дали клиент има право на отстъпка при поръчка над 500 лв. 
    Ако има право, да се изчисли крайната сума след прилагане на отстъпката от 10%.
*/
public class DiscountCheck
{
    public static void Main(string[] args)
    {
        double orderTotal = 450.00;
        const double DISCOUNT_THRESHOLD = 500.00;
        const double DISCOUNT_PERCENT = 0.10; // 10%

        if (orderTotal > DISCOUNT_THRESHOLD)
        {
            double discountAmount = orderTotal * DISCOUNT_PERCENT;
            double finalTotal = orderTotal - discountAmount;
            Console.WriteLine($"Поздравления! Имате право на " + DISCOUNT_PERCENT + " % отстъпка");
            Console.WriteLine($"Крайна сума: " + finalTotal + " лв.");
        }
        else
        {
            Console.WriteLine($"Поръчката е " + orderTotal + " лв. " + 
            "Необходими са още " + (DISCOUNT_THRESHOLD - orderTotal) + " лв. за отстъпка");
        }
    }
}