public class VATCalculation
{
    public static void Main(string[] args)
    {
        double price = 100.00;
        const double VAT_RATE = 0.20; // 20% ДДС
        
        // Формула: Цена + (Цена * ДДС ставка) или Цена * (1 + ДДС ставка)
        double priceWithVAT = price * (1 + VAT_RATE);
        
        Console.WriteLine($"Цена без ДДС: {price} лв."); // 100 лв.
        Console.WriteLine($"ДДС ставка: {VAT_RATE:P0}"); // :P0 форматира като процент
        Console.WriteLine($"Цена с ДДС: {priceWithVAT} лв."); // 120.00 лв.
    }
}