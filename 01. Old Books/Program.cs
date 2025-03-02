/**
 * 01. Old Books
 */

string bookName = Console.ReadLine();
string guess = "";
int counter = 0;

while (true)
{
    guess = Console.ReadLine();

    if (guess == "No More Books")
    {
        Console.WriteLine("The book you search is not here!");
        Console.WriteLine($"You checked {counter} books.");
        break;
    }

    if (guess == bookName)
    {
        Console.WriteLine($"You checked {counter} books and found it.");
        break;
    }

    counter++;
}

//•	Ако не открие търсената книгата да се отпечата на два реда: 
//o   "The book you search is not here!"
//o	"You checked {брой} books."
//•	Ако открие книгата си се отпечатва един ред:
//o   "You checked {брой} books and found it."  