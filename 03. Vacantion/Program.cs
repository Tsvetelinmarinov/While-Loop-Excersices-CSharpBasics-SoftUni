/**
 * 03. Vacantion
 */

double neededMoney = double.Parse(Console.ReadLine());
double currentMoney = double.Parse(Console.ReadLine());
int daysCounter = 0;
int daysOfSpending = 0;

//2000
//1000
//spend
//1200
//save
//2000

while (true)
{ 
    string action = Console.ReadLine();
    double sum = double.Parse(Console.ReadLine());
    daysCounter++;

    switch (action)
    {
        case "save":
            currentMoney += sum;
            if (currentMoney >= neededMoney)
            {
                Console.WriteLine("You saved the money for {0} days.", daysCounter);
                Environment.Exit(0);
            }
            daysOfSpending = 0;
            break;
        case "spend":
            if (currentMoney > sum)
            {
                currentMoney -= sum;
            }
            else
            {
                currentMoney = 0;
            }
            daysOfSpending++;
            if (daysOfSpending == 5)
            {
                Console.WriteLine("You can't save the money.");
                Console.WriteLine(daysCounter);
                Environment.Exit(0);
            }
            break;
        default:
            Console.WriteLine("Invalid action!");
        break;
    }
}