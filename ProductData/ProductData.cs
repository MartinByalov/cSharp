
/*
Да се намалят складовите наличности (inventory) след продажба, използвайки съкратен запис. 
Да се увеличи номер на фактура (invoiceNumber) и брой дни на забавяне (lateDays).
*/

public class ProductData
{
    public static void Main(string[] args)
    {
        // CamelCase
        double productPrice = 45.99; // Цена за единичен продукт
        int quantity = 250;          // Продадено количество

        // Променлива за процент (0.20 за 20%)
        double vatRate = 0.20;

        // PascalCase с подчертаване или само главни букви
        const double TOTAL_PROFIT_GOAL = 5000.00; // Цел за обща печалба

        double totalRevenue = productPrice * quantity;

        Console.WriteLine($"Цена на продукт: {productPrice:C}"); // :C форматира като валута
        Console.WriteLine($"Продадено количество: " + quantity);
        Console.WriteLine($"Общ приход: {totalRevenue:C}");
        Console.WriteLine($"Печалба: {TOTAL_PROFIT_GOAL:C}");
    }
}