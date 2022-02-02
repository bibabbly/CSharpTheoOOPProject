// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");



try {
    Console.Write("Enter First Number : ");
    int num1 = Convert.ToInt32(Console.ReadLine());

    Console.Write("Enter Second Number : ");
    int num2 = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("The answer of division is " + (num1 / num2));

}
catch(Exception e) {
    Console.WriteLine("You have Error in Division " +e.Message);
}
