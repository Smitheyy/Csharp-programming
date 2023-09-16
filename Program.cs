using System.Linq.Expressions;

bool try_again = true;
double result;
String calculate_a;
String chance;


while (try_again)    
{
    try
    {
       
        Console.WriteLine("------------------------------------------------");
        Console.WriteLine("CALCULATOR");
        Console.WriteLine("------------------------------------------------");

        
        Console.Write("Choose a first number: ");
        double num_1 = Convert.ToDouble(Console.ReadLine());


        Console.Write("Choose a second number: ");
        double num_2 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine();
        Console.WriteLine("------------------------------------------------");


        Console.WriteLine("Enter an option (type to do equation +, -, *, /, R, P, S): ");
        Console.WriteLine("\t+ : Add");
        Console.WriteLine("\t- : Subtract");
        Console.WriteLine("\t* : Multiply");
        Console.WriteLine("\t/ : Divide");
        Console.WriteLine("\tR : Remainder");
        Console.WriteLine("\tP : Power | note: the first number is raised to the power equivalent to the second number");
        Console.WriteLine("\tS : Square root of");
        Console.Write("Enter one of the following symbols: ");
        chance = Console.ReadLine();
        chance = chance.ToUpper();


        switch (chance)
        {
            case "+":
                Console.WriteLine("------------------------------------------------");
                result = num_1 + num_2;
                Console.WriteLine($"{num_1} + {num_2} = " + result); break;


            case "-":
                Console.WriteLine("------------------------------------------------");
                result = num_1 - num_2;
                Console.WriteLine($"{num_1} - {num_2} = " + result); break;


            case "*":
                Console.WriteLine("------------------------------------------------");
                result = num_1 * num_2;
                Console.WriteLine($"{num_1} * {num_2} = " + result); break;


            case "/":                               
                {
                    Console.WriteLine("------------------------------------------------");
                    result = num_1 / num_2;
                    Console.WriteLine($"{num_1} / {num_2} = " + result);

                    if (double.IsNaN(result))
                    {
                        Console.WriteLine("You can't divide by zero!");
                    }
                }
                break;


            case "R":
                {
                    Console.WriteLine("------------------------------------------------");
                    result = num_1 % num_2;
                    Console.WriteLine($"{num_1} % {num_2} = " + result);

                    if (double.IsNaN(result))
                    {
                        Console.WriteLine("The result is not a number");
                    }
                }
                break;


            case "P":                
                {
                    Console.WriteLine("------------------------------------------------");
                    Console.Write("Enter a number that you want to raise: ");
                    double powered_num = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("------------------------------------------------");
                    Console.Write("Enter the power that will raise the number to its value of power: ");
                    double power_num = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("------------------------------------------------");                   
                    Console.WriteLine(Math.Pow(powered_num, power_num));                   
                }               
                break;


            case "S":
                {
                    Console.WriteLine("------------------------------------------------");
                    Console.Write("Enter a number you want to square root: ");
                    double squareroot_num = Convert.ToDouble(Console.ReadLine());


                    Console.WriteLine("------------------------------------------------");
                    result = Math.Sqrt(squareroot_num);
                    Console.WriteLine(result);

                    if (double.IsNaN(result))
                    {
                        Console.WriteLine("You can't square root this number!");
                    }
                }
                break;

            default:
            {
                    while (chance != "+" && chance != "-" && chance != "*" && chance != "/" && chance != "R" && chance != "P" && chance != "S")
                    {
                        Console.WriteLine("------------------------------------------------");
                        Console.Write("In order to solve an equation you need to enter one of the following symbols(+, -, *, /, R, P, S): ");
                        chance = Console.ReadLine();
                        chance = chance.ToUpper();


                        switch (chance)
                        {

                            case "+":
                                Console.WriteLine("------------------------------------------------");
                                result = num_1 + num_2;
                                Console.WriteLine($"{num_1} + {num_2} = " + result); break;


                            case "-":
                                Console.WriteLine("------------------------------------------------");
                                result = num_1 - num_2;
                                Console.WriteLine($"{num_1} - {num_2} = " + result); break;


                            case "*":
                                Console.WriteLine("------------------------------------------------");
                                result = num_1 * num_2;
                                Console.WriteLine($"{num_1} * {num_2} = " + result); break;


                            case "/":
                                {
                                    Console.WriteLine("------------------------------------------------");
                                    result = num_1 / num_2;
                                    Console.WriteLine($"{num_1} / {num_2} = " + result);

                                    if (double.IsNaN(result))
                                    {
                                        Console.WriteLine("You can't divide by zero!");
                                    }                                                                                                 
                                }
                                break;


                            case "R":
                                {
                                    Console.WriteLine("------------------------------------------------");
                                    result = num_1 % num_2;
                                    Console.WriteLine($"{num_1} % {num_2} = " + result);

                                    if (double.IsNaN(result))
                                    {
                                        Console.WriteLine("The result is not a number");
                                    }

                                }
                                break;


                            case "P":
                                {
                                    Console.WriteLine("------------------------------------------------");
                                    Console.Write("Enter a number that you want to raise: ");
                                    double powered_num = Convert.ToDouble(Console.ReadLine());

                                    Console.WriteLine("------------------------------------------------");
                                    Console.Write("Enter the power that will raise the number to its value of power: ");
                                    double power_num = Convert.ToDouble(Console.ReadLine());

                                    Console.WriteLine("------------------------------------------------");
                                    Console.WriteLine(Math.Pow(powered_num, power_num));


                                }
                                break;


                            case "S":
                                {
                                    Console.WriteLine("------------------------------------------------");
                                    Console.Write("Enter a number you want to square root: ");
                                    double squareroot_num = Convert.ToDouble(Console.ReadLine());

                                    Console.WriteLine("------------------------------------------------");
                                    result = Math.Sqrt(squareroot_num);
                                    Console.WriteLine(result);
                                    
                                    if (double.IsNaN(result))
                                    {
                                        Console.WriteLine("You can't square root this number!");
                                    }                                  
                                }
                                break;
                        }
                    }                             
            }
            break;
        }


        Console.WriteLine("------------------------------------------------");
        Console.Write("Do you want to calculate again?(type Y or N): ");
        calculate_a = Console.ReadLine();
        calculate_a = calculate_a.ToUpper();


        if (calculate_a == "Y")
        {
            Console.WriteLine("------------------------------------------------");
            try_again = true;
            Console.Clear();
        }


        else if (calculate_a == "N")
        {
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine("Goodbye!");
            Console.WriteLine("------------------------------------------------");
            try_again = false;
        }


        while (calculate_a != "Y" && calculate_a != "N")
        {
            Console.WriteLine("------------------------------------------------");
            Console.Write("In order to submit your answer you nedd to type either Y or N: ");
            calculate_a = Console.ReadLine();
            calculate_a = calculate_a.ToUpper();


            if (calculate_a == "Y")
            {
                Console.Clear();
                try_again = true;
            }


            else if (calculate_a == "N")
            {
                Console.WriteLine("------------------------------------------------");
                Console.WriteLine("Goodbye!");
                Console.WriteLine("------------------------------------------------");
                try_again = false;
            }
        }
    }
 
    
    catch (FormatException)
    {
        Console.Clear();
        Console.WriteLine("--------------------------------------------");
        Console.WriteLine("Enter only numbers, please!");
        try_again = true;
    }        
}

Console.ReadKey();