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

            Console.WriteLine($"��������� {amount} ����(o�). ������� ����: {chasiki}");
        }
        else
        {

            Console.WriteLine("���� ��� ����������, ������ ���� �������������.");
        }
    }

    public void delete_hours(double amount)
    {

        if (amount > 0 && amount <= chasiki)
        {

            chasiki -= amount;

            Console.WriteLine($"����� {amount} ����(��). ������� ����: {chasiki}");
        }

        else if (amount > chasiki)
        {

            Console.WriteLine("������������ ����� � ���������.");
        }
        else
        {
            Console.WriteLine("���� ��� ������ ������ ���� �������������.");
        }
    }

    public void sum_hours()
    {
        Console.WriteLine($"������� ���������� �����: {chasiki}");
    }
}

class Program
{
    static void Main()
    {
        cafe myCafe = new cafe();

        while (true)
        {
            Console.WriteLine("�������� �������: \n1. ��������� ���������� ����� \n2. �����  ���������� �����\n3. ��������� ���������� �����\n4. �����");

            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.WriteLine("������� ����� ��� ���������� �����:");
                    double hoursAmount = double.Parse(Console.ReadLine());
                    myCafe.hours(hoursAmount);
                    break;

                case 2:

                    Console.WriteLine("������� ����� ��� ������ �����:");
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
                    Console.WriteLine("������������ �������. ����������, �������� �����.");
                    break;
            }
        }
    }
}


