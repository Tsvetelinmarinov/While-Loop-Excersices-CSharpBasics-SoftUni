/**
 * 02. Exam Preparation
 */

//•	На първи ред - брой незадоволителни оценки - цяло число в интервала [1…5]
//•	След това многократно се четат по два реда:
//o	Име на задача - текст (низ)
//o	Оценка - цяло число в интервала [2…6]

int badGradesLimit = int.Parse(Console.ReadLine());
double currentGrade = 0;
double gradesSum = 0;
int badGradesCounter = 0;
int gradesCounter = 0;
string solutionName = "";
string lastSolution = "";

//•	Ако Марин стигне до командата "Enough", отпечатайте на 3 реда: 
//o   "Average score: {средна оценка}"
//o	"Number of problems: {броя на всички задачи}"
//o	"Last problem: {името на последната задача}"
//•	Ако получи определеният брой незадоволителни оценки:
//o   "You need a break, {брой незадоволителни оценки} poor grades."
//Средната оценка да бъде форматирана до втория знак след десетичната запетая.

while (true)
{
    solutionName = Console.ReadLine();

    if (solutionName == "Enough")
    {
        Console.WriteLine("Average score: {0:F2}", gradesSum / gradesCounter);
        Console.WriteLine("Number of problems: {0}", gradesCounter);
        Console.WriteLine("Last problem: " + lastSolution);
        break;
    }

    currentGrade = double.Parse(Console.ReadLine());

    if (currentGrade <= 4) 
    {
        badGradesCounter++;
        
        if (badGradesCounter == badGradesLimit)
        {
            Console.WriteLine("You need a break, {0} poor grades.", badGradesCounter);
            break;
        }
    } 

    gradesSum += currentGrade;
    gradesCounter++;
    lastSolution = solutionName;
}