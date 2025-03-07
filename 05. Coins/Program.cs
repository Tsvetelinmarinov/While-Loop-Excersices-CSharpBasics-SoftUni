/**
 * 05. Coins
 */
int coinsTotal = 0;
int x1 = 0;
int x2 = 0;
int x5 = 0;
int x10 = 0;
int x20 = 0;
int x50 = 0;
int x1lv = 0;
int x2lv = 0;
double sum = double.Parse(Console.ReadLine());
sum *= 100;

//Производителите на вендинг машини искали да направят машините си
//да връщат възможно най-малко монети ресто. 
//Напишете програма, която приема сума - рестото, което трябва да се върне
//и изчислява с колко най-малко монети може да стане това.

while (true)
{
    if (sum >= 200)
    {
        sum -= 200;
        x2lv++;

        if (sum >= 100)
        {
            sum -= 100;
            x1lv++;

            if (sum >= 50)
            {
                sum -= 50;
                x50++;

                if (sum >= 20)
                {
                    sum -= 20;
                    x20++;

                    if (sum >= 10)
                    {
                        sum -= 10;
                        x10++;

                        if (sum >= 5)
                        {
                            sum -= 5;
                            x5++;

                            if (sum >= 2)
                            {
                                sum -= 2;
                                x2++;

                                if (sum >= 1)
                                {
                                    sum -= 1;
                                    x1++;
                                    break;
                                }
                            }
                        }
                    }
                }
            }
        }
        
    }
    else
    {
        if (sum >= 50)
        {
            sum -= 50;
            x50++;

            if (sum >= 20)
            {
                sum -= 20;
                x20++;

                if (sum >= 10)
                {
                    sum -= 10;
                    x10++;

                    if (sum >= 5)
                    {
                        sum -= 5;
                        x5++;

                        if (sum >= 2)
                        {
                            sum -= 2;
                            x2++;

                            if (sum >= 1)
                            {
                                sum -= 1;
                                x1++;
                                break;
                            }
                        }
                    }
                }
            }
        }
    }

    if (sum <= 0) { break; }
}

   