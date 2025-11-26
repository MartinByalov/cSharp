public class Array
{
    public static void Main(string[] args)
    {

        Console.WriteLine("## 1. Едномерен масив");

        // Дефиниране на едномерен масив от цели числа (int)
        int[] numbers = { 15, 7, 22, 11, 7, 30, 5, 22, 7, 18 };

        // Масивът 'numbers' има 10 елемента.
        // Индексирането започва от 0.
        // **Промяна: string.Join() все още е най-добрият начин за извеждане на целия масив.**
        Console.WriteLine("\nМасив: [ " + string.Join(", ", numbers) + " ]");

        // Достъп до елементи чрез индекс
        Console.WriteLine("Елемент на индекс 0: " + numbers[0]); // Първи елемент (15)
        Console.WriteLine("Елемент на индекс 4: " + numbers[4]); // Пети елемент (7)
        Console.WriteLine("Последният елемент (индекс " + (numbers.Length - 1) + "): " + numbers[numbers.Length - 1]); // (18)

        // -----------------------------------------------------
        // 2. Търсене на елемент в масив (Линейно търсене)
        // -----------------------------------------------------

        Console.WriteLine("\n# 2. Търсене на елемент (Търсене на 22)");
        int target = 22;
        int foundIndex = -1; // Използва се -1 за индикация, че не е намерен

        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] == target)
            {
                foundIndex = i;
                Console.WriteLine("Елементът " + target + " е намерен на първата си позиция (индекс): " + foundIndex);
                break; // Спираме търсенето след първото намиране
            }
        }

        if (foundIndex == -1)
        {
            Console.WriteLine("Елементът " + target + " не е намерен в масива.");
        }

        // -----------------------------------------------------
        // 3. Преброяване на елементи в масив
        // -----------------------------------------------------

        Console.WriteLine("\n# 3. Преброяване на елементи (Преброяване на 7)");
        int count = 0;
        int elementToCount = 7;

        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] == elementToCount)
            {
                count++;
            }
        }

        Console.WriteLine("Елементът " + elementToCount + " се среща " + count + " пъти в масива.");

        // -----------------------------------------------------
        // 4. Намиране на минимум и максимум
        // -----------------------------------------------------

        Console.WriteLine("\n# 4. Намиране на минимум и максимум");

        // Приемаме първия елемент за начален минимум и максимум
        int min = numbers[0];
        int max = numbers[0];

        for (int i = 1; i < numbers.Length; i++)
        {
            if (numbers[i] < min)
            {
                min = numbers[i]; // Намерен е нов минимум
            }
            if (numbers[i] > max)
            {
                max = numbers[i]; // Намерен е нов максимум
            }
        }

        Console.WriteLine("Минимална стойност в масива: " + min);
        Console.WriteLine("Максимална стойност в масива: " + max);

        // -----------------------------------------------------
        // 5. Двумерни масиви – дефиниране и достъп
        // -----------------------------------------------------

        Console.WriteLine("\n# 5. Двумерни масиви (Матрица 3x4)");

        // Дефиниране на двумерен масив (матрица) с 3 реда и 4 колони
        int[,] matrix = new int[3, 4]
        {
            { 1, 2, 3, 4 },
            { 5, 6, 7, 8 },
            { 9, 10, 11, 12 }
        };

        // Достъп до елементи - използва се (ред, колона)
        Console.WriteLine("Елемент на ред 0, колона 0: " + matrix[0, 0]); // 1
        Console.WriteLine("Елемент на ред 1, колона 2: " + matrix[1, 2]); // 7
        Console.WriteLine("Елемент на ред 2, колона 3: " + matrix[2, 3]); // 12

        // Обхождане на двумерния масив
        Console.WriteLine("\nИзвеждане на цялата матрица:");
        for (int row = 0; row < matrix.GetLength(0); row++) // Обхожда редовете
        {
            for (int col = 0; col < matrix.GetLength(1); col++) // Обхожда колоните
            {
                // Използваме PadLeft(3) за форматиране
                Console.Write(matrix[row, col].ToString().PadLeft(3));
            }
            Console.WriteLine(); // Нов ред след всяка колона
        }

        Console.WriteLine("");
    }
}