namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Menu();
            

        }
        public static void Menu()
        {
            while (true)
            {
                double[] nums;
                Console.WriteLine("================\n   Calculator\n================\n");
                Console.WriteLine("1] Start\n2] Exit");
                int choice = 0;
                while (true)
                {
                    try
                    {
                        choice = Convert.ToInt32(Console.ReadLine());

                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("Unknown Choice!");
                        continue;
                    }
                    if (choice > 2 || choice < 1)
                    {
                        Console.WriteLine("Unknown Choice!");
                        continue;
                    }
                    else break;
                }
                
                if(choice == 1)
                {
                    Console.Clear();
                    while (true)
                    {
                        Console.WriteLine("Choose The Operation\n----------------------\n");
                        Console.WriteLine("1] +\n2] -\n3] *\n4] /\n5] %\n6] Back");
                        Console.Write("Operation : ");
                        int op = 0;
                        while (true)
                        {
                            try
                            {
                                op = Convert.ToInt32(Console.ReadLine());

                            }
                            catch (Exception e)
                            {
                                Console.WriteLine("Unknown Choice!");
                                continue;
                            }
                            if (op > 6 || op < 1)
                            {
                                Console.WriteLine("Unknown Choice!");
                                continue;
                            }
                            else break;
                        }
                        
                        
                        if (op == 6) break;
                        
                        nums = Scan();
                        double n1 = nums[0];
                        double n2 = nums[1];
                        double result = 0;
                        if (op == 1)
                        {
                            result = Sum(n1, n2);
                        }
                        else if (op == 2)
                        {
                            result = Minus(n1, n2);
                        }
                        else if (op == 3)
                        {
                            result = Multiply(n1, n2);
                        }
                        else if (op == 4)
                        {
                            if (IsZero(n2))
                            {
                                Console.WriteLine("Error : Zero is not allowed in this operation!");
                                n2 = ScanNoZero();
                            }
                            result = Division(n1, n2);
                        }
                        else if (op == 5)
                        {
                            if (IsZero(n2))
                            {
                                Console.WriteLine("Error : Zero is not allowed in this operation!");
                                n2 = ScanNoZero();
                            }
                            result = Modelus(n1, n2);
                        }

                        else
                        {
                            break;
                        }
                        Console.WriteLine($"\nResult = {result}\n==================================\n");
                        Console.WriteLine("\n <Press Enter To Back >");
                        string back = Console.ReadLine();
                        Console.Clear();
                    }
                    
                    Console.Clear();
                }
                else
                {
                    break;
                }
                
                
            }
        }
        public static double[] Scan()
        {
            double n1 = 0;
            double n2 = 0;
            while (true)
            {
                try
                {
                    Console.Write("First Number : ");
                    n1 = Convert.ToDouble(Console.ReadLine());

                    break;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Please enter only numbers");
                    continue;
                }
            }
            while (true)
            {
                try
                {
                    Console.Write("Second Number : ");
                    n2 = Convert.ToDouble(Console.ReadLine());

                    break;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Please enter only numbers");
                    continue;
                }
            }
            double[] nums = { n1, n2 };
            return nums;
        }


        public static double ScanNoZero()
        {
            double n = 0;
            
            while (true)
            {
                try
                {
                    Console.Write("Second Number : ");
                    n = Convert.ToDouble(Console.ReadLine());
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Please enter only numbers");
                    continue;
                }
                if (n == 0)
                {
                    Console.WriteLine("Zero is not allowed in this operation!");
                    continue;
                }
                else break;
            } 
            return n;
        }

        public static bool IsZero(double n)
        {
            return n == 0;
        }
    
        public static double Sum(double n1,  double n2)
        {
            return n1 + n2;
        }
        public static double Minus(double n1, double n2)
        {
            return n1 - n2;
        }
        public static double Multiply(double n1, double n2)
        {
            return n1 * n2;
        }
        public static double Division(double n1, double n2)
        {
            return n1 / n2;
        }
        public static double Modelus(double n1, double n2)
        {
            return n1 % n2;
        }
    }
}
