namespace override_C_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int taskNumber;

            do
            {
                Console.WriteLine("Enter the task number (1-7) or 0 to exit: ");
                string input = Console.ReadLine();
                int.TryParse(input, out taskNumber);

                switch (taskNumber)
                {
                    case 0:
                        Console.WriteLine("Goodbye!");
                        break;
                    case 1:
                        Task1 emp1 = new Task1();
                        Console.WriteLine("\nEmployee 1:");
                        emp1.DisplayInfo();

                        Task1 emp2 = new Task1();
                        Console.WriteLine("\nEmployee 2:");
                        emp2.DisplayInfo();

                        Console.WriteLine("\nEmployee 1 == Employee 2: {0}", emp1 == emp2);
                        Console.WriteLine("Employee 1 != Employee 2: {0}", emp1 != emp2);

                        Console.WriteLine("\nEnter a number to increase employee 1's salary:");
                        int num = int.Parse(Console.ReadLine());
                        emp1 += num;
                        Console.WriteLine("Employee 1's salary after increase: {0}", emp1._Salary);

                        Console.WriteLine("\nEnter a number to decrease employee 2's salary:");
                        num = int.Parse(Console.ReadLine());
                        emp2 -= num;
                        Console.WriteLine("Employee 2's salary after decrease: {0}", emp2._Salary);

                        Console.WriteLine("\nEmployee 1 salary > 5000: {0}", emp1 > 5000);
                        Console.WriteLine("Employee 2 salary < 5000: {0}", emp2 < 5000);
                        break;
                    case 2:
                        Task2 matrix1 = new Task2(2, 2);
                        matrix1.FillMatrix();
                        Console.WriteLine("Matrix 1:");
                        matrix1.DisplayMatrix();

                        Task2 matrix2 = new Task2(2, 2);
                        matrix2.FillMatrix();
                        Console.WriteLine("Matrix 2:");
                        matrix2.DisplayMatrix();

                        Task2 sum = matrix1 + matrix2;
                        Console.WriteLine("Sum of matrices:");
                        sum.DisplayMatrix();

                        Task2 difference = matrix1 - matrix2;
                        Console.WriteLine("Difference of matrices:");
                        difference.DisplayMatrix();

                        Task2 product = matrix1 * matrix2;
                        Console.WriteLine("Product of matrices:");
                        product.DisplayMatrix();

                        Console.WriteLine("Max element in matrix 1: {0}", matrix1.Max());
                        Console.WriteLine("Min element in matrix 1: {0}", matrix1.Min());

                        // Test equality operators
                        Task2 matrix3 = new Task2(2, 2);
                        matrix3.FillMatrix();
                        Console.WriteLine("Matrix 3:");
                        matrix3.DisplayMatrix();

                        bool matricesEqual = matrix1 == matrix3;
                        Console.WriteLine("Matrix 1 is equal to matrix 3: {0}", matricesEqual);

                        bool matricesNotEqual = matrix2 != matrix3;
                        Console.WriteLine("Matrix 2 is not equal to matrix 3: {0}", matricesNotEqual);

                        Console.ReadLine();

                        break;
                    case 3:
                        Task3 city1 = new Task3("Kyiv", 2800000);
                        Task3 city2 = new Task3("Lviv", 720000);

                        Console.WriteLine("City 1: {0}, Population: {1}", city1.Name, city1.Population);
                        Console.WriteLine("City 2: {0}, Population: {1}", city2.Name, city2.Population);

                        Task3 city3 = city1 + 50000;
                        Console.WriteLine("City 1 + 50,000: {0}, Population: {1}", city3.Name, city3.Population);

                        Task3 city4 = city2 - 20000;
                        Console.WriteLine("City 2 - 20,000: {0}, Population: {1}", city4.Name, city4.Population);

                        Console.WriteLine("City 1 == City 2: {0}", city1 == city2);
                        Console.WriteLine("City 1 != City 2: {0}", city1 != city2);
                        Console.WriteLine("City 1.Equals(City 2): {0}", city1.Equals(city2));
                        Console.WriteLine("City 1 > City 2: {0}", city1 > city2);
                        Console.WriteLine("City 1 < City 2: {0}", city1 < city2);

                        Console.ReadLine();
                        break;
                    case 4:
                        CreditCard card1 = new CreditCard("1234 5678 9012 3456", "123", new DateTime(2025, 12, 31), 1000.0);
                        CreditCard card2 = new CreditCard("9876 5432 1098 7654", "123", new DateTime(2025, 12, 31), 2000.0);

                        // перевірка на рівність CVC коду
                        if (card1 == card2)
                        {
                            Console.WriteLine("CVC коди карток рівні.");
                        }
                        else
                        {
                            Console.WriteLine("CVC коди карток не рівні.");
                        }

                        // перевірка на меншу чи більшу кількість суми грошей
                        if (card1 < card2)
                        {
                            Console.WriteLine(" Перша має менше грошей на картці, ніж друга.");
                        }
                        else if (card1 > card2)
                        {
                            Console.WriteLine(" Перша має більше грошей на картці, ніж друга.");
                        }
                        else
                        {
                            Console.WriteLine("Обидві картки мають однакову суму грошей на картці.");
                        }

                        // збільшення суми грошей на картці на вказану кількість
                        double amountToAdd = 500.0;
                        card1 += amountToAdd;
                        Console.WriteLine(card1.Sum);

                        // зменшення суми грошей на картці на вказану кількість
                        double amountToSubtract = 700.0;
                        card2 -= amountToSubtract;
                        Console.WriteLine("{0} тепер має {1} грошей на картці.", card2.CardNumber, card2.Sum);

                        // перевірка на рівність об'єктів
                        CreditCard card3 = new CreditCard("1234 5678 9012 3456", "123", new DateTime(2025, 12, 31), 1500.0);
                        if (card1.Equals(card3))
                        {
                            Console.WriteLine("Картки {0} і {1} рівні.", card1.CardNumber, card3.CardNumber);
                        }
                        else
                        {
                            Console.WriteLine("Картки {0} і {1} не рівні.", card1.CardNumber, card3.CardNumber);
                        }

                        Console.ReadLine();
                        break;
                }
            } while (taskNumber != 0);
        }

    } 
} 