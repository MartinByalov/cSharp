public class InventoryUpdate
{
    public static void Main(string[] args)
    {
        int inventory = 500;
        int itemsSold = 75;
        int invoiceNumber = 2024001;
        int lateDays = 0;

        // Съкратен запис за изваждане (Продажба)
        inventory -= itemsSold; // inventory = 500 - 75; => 425
        Console.WriteLine($"Оставаща наличност: " + inventory);
        
        // Съкратен запис за умножение (Месечно натрупване)
        lateDays = 1; 
        lateDays *= 3; // Натрупване на забава от 3 месеца
        Console.WriteLine($"Натрупани дни забавяне: " + lateDays);

        // Инкрементиране (Следваща фактура)
        invoiceNumber++; // invoiceNumber = 2024002
        Console.WriteLine($"Следващ номер на фактура: " + invoiceNumber);
    }
}