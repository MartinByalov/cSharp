
/*  Да се изчисли Брутен марж (Gross Margin) и да се провери логически дали целевият марж печалба е достигнат.
    
    Брутен марж = (Продажби − Разходи) / Продажби​
   
    Логическа проверка: Брутният марж > 0.30
*/
public class GrossMargin
{
    public static void Main(string[] args)
    {
        double sales = 15000.00; // Общи продажби
        double costOfGoods = 9000.00; // Разходи за стоки
        
        double grossMargin = (sales - costOfGoods) / sales; 
        
        const double TARGET_MARGIN = 0.30; // Целеви марж от 30%
        bool isTargetReached = grossMargin > TARGET_MARGIN; 

        Console.WriteLine($"Брутен марж (като десетична дроб): {grossMargin:F2}"); // 0.40
        Console.WriteLine($"Целевият марж от {TARGET_MARGIN:P0} достигнат ли е? " + isTargetReached); // True
        
        // Team building - Остатък при деление (Модулно деление)
        int clients = 7;
        int teams = 3;
        int remainingClients = clients % teams; // 7 % 3 = 1
        Console.WriteLine($"Клиенти, които не могат да бъдат разпределени в 3 отбора: " + remainingClients);
    }
}