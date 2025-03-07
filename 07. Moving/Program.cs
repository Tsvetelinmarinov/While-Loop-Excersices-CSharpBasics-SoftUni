/**
 * 07. Moving
 */

//Потребителят въвежда следните данни на отделни редове:
//1.	Широчина на свободното пространство - цяло число в интервала [1...1000]
//2.	Дължина на свободното пространство - цяло число в интервала [1...1000]
//3.	Височина на свободното пространство - цяло число в интервала [1...1000]
//4.	На следващите редове (до получаване на команда "Done") - брой кашони, които се пренасят в квартирата - цяло число в интервала [1...10000]
//Програмата трябва да приключи прочитането на данни при команда "Done" или ако свободното място свърши.

int roomWidth = int.Parse(Console.ReadLine());
int roomLength = int.Parse(Console.ReadLine());
int roomHeight = int.Parse(Console.ReadLine());

int roomVolume = roomWidth * roomLength * roomHeight;
int currentVolume = 0;
string iStream = Console.ReadLine();

//10
//1
//2
//4
//6
//Done

while (true)
{
    if (iStream == "Done")
    {
        Console.WriteLine("{0} Cubic meters left.", roomVolume - currentVolume);
        break;
    }

    currentVolume += int.Parse(iStream);

    if (roomVolume <= 0)
    {
        Console.WriteLine("No more free space! You need {0} Cubic meters more.", currentVolume - roomVolume);
        break;
    }

    iStream = Console.ReadLine();
}

//•	Ако стигнете до командата "Done" и има още свободно място:
//"{брой свободни куб. метри} Cubic meters left."
//•	Ако свободното място свърши преди да е дошла команда "Done":
//"No more free space! You need {брой недостигащи куб. метри} Cubic meters more."