/**
 * 04. Walking
 */

int target = 10000;
string steps = ""; //Стъпките всеки ден
int stepsCounter = 0;

//1500
//300
//2500
//3000
//Going home
//200

while (true)
{
    steps = Console.ReadLine();
    
    if (steps != "Going home") { stepsCounter += int.Parse(steps); }

    if (stepsCounter >= target)
    {
        Console.WriteLine("Goal reached! Good job!");
        Console.WriteLine("{0} steps over the goal!", stepsCounter - target);
        break;
    }

    if (steps == "Going home")
    {
        steps = Console.ReadLine();
        stepsCounter += int.Parse(steps);

        if (stepsCounter >= target)
        {
            Console.WriteLine("Goal reached! Good job!");
            Console.WriteLine("{0} steps over the goal!", stepsCounter - target);
            break;
        }
        else
        {
            Console.WriteLine("{0} steps more to reach goal!", target - stepsCounter);
            break;
        }
    }
}