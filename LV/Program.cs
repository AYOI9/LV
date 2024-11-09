try
{
    Console.Write("Введите стоимость покупки в грн: ");
    double a = Convert.ToDouble(Console.ReadLine());
    double b = CalculateDiscount(a);
    double c = a - b;
    Console.WriteLine("Первоначальная стоимость: " + a + " грн.");
    Console.WriteLine("Скидка: " + b + " грн.");
    Console.WriteLine("Итоговая стоимость: " + c + " грн.");
    static double CalculateDiscount(double amount)
    {
        double discount = 0;
        if (amount > 1000 && amount < 2000)
        {
            discount = amount * 0.05; 
        }
        else if (amount >= 2000 && amount < 5000)
        {
            discount = amount * 0.10; 
        }
         return discount;
    }
}
catch
{
    Console.WriteLine("введите правильное значение.");
}
