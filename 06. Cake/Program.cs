/**
 * 06. Cake
 */

int width = int.Parse(Console.ReadLine());
int length = int.Parse(Console.ReadLine());
int fullCake = width * length;

while (true)
{
    string inputStream = Console.ReadLine();
    if (inputStream == "STOP") 
    {
        Console.WriteLine("{0} pieces are left.", fullCake);
        break; 
    }
    fullCake -= int.Parse(inputStream);
    if (fullCake <= 0)
    {
        Console.WriteLine("No more cake left! You need {0} pieces more.", Math.Abs(fullCake));
        break;
    }
}

//•	"{брой парчета} pieces are left." - ако стигнете до STOP и не са свършили парчетата торта
//•	"No more cake left! You need {брой недостигащи парчета} pieces more."