using System;

class cafe
{
    private double chasiki;

    public cafe()
    {
        chasiki = 0;
    }

    public void hours(double amount)
    {

        if (amount > 0)
        {

            chasiki += amount;

            Console.WriteLine($"Добавлено {amount} часа(oв). Текущие часы: {chasiki}");
        }
        else
        {

            Console.WriteLine("часы для добавления, должна быть положительной.");
        }
    }

    public void delete_hours(double amount)
    {

        if (amount > 0 && amount <= chasiki)
        {

            chasiki -= amount;

            Console.WriteLine($"Снято {amount} часа(ов). Текущие часы: {chasiki}");
        }

        else if (amount > chasiki)
        {

            Console.WriteLine("Недостаточно часов у сотруника.");
        }
        else
        {
            Console.WriteLine("часы для снятия должна быть положительной.");
        }
    }

    public void sum_hours()
    {
        Console.WriteLine($"Текущее количество часов: {chasiki}");
    }
}

class Program
{
    static void Main()
    {
        cafe myCafe = new cafe();

        while (true)
        {
            Console.WriteLine("Выберите команду: \n1. Пополнить количество часов \n2. Снять  количество часов\n3. Проверить количество часов\n4. Выйти");

            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.WriteLine("Введите сумму для пополнения часов:");
                    double hoursAmount = double.Parse(Console.ReadLine());
                    myCafe.hours(hoursAmount);
                    break;

                case 2:

                    Console.WriteLine("Введите сумму для снятия часов:");
                    double delete_hoursAmount = double.Parse(Console.ReadLine());
                    myCafe.delete_hours(delete_hoursAmount);
                    break;

                case 3:
                    myCafe.sum_hours();
                    break;

                case 4:
                    Environment.Exit(0);
                    break;

                default:
                    Console.WriteLine("Некорректная команда. Пожалуйста, выберите снова.");
                    break;
            }
        }
    }
}


