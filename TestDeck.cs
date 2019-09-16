using System;

class TestDeck
{
    static void Main(string[] args)
    {
        int numOfCards=52, numOfSuit=1, suit=0;
        Hoyle h = new Hoyle();
        Hoyle[] FullDeck = new Hoyle[numOfCards];
        for(int i=0; i<numOfCards; i++)
        {
            switch(suit)
            {
                case 0:
                {
                    h = new Hoyle(numOfSuit,'H');
                    FullDeck[i] = h;
                    numOfSuit++;
                    if (i == 12)
                    {
                            suit++;
                            numOfSuit=1;
                    }
                    break;
                }
                case 1:
                    {
                        h = new Hoyle(numOfSuit, 'D');
                        FullDeck[i] = h;
                        numOfSuit++;
                    if (i==25)
                    {
                            suit++;
                            numOfSuit=1;
                    }
                    break;
                }
                case 2:
                    {
                        h = new Hoyle(numOfSuit, 'S');
                        FullDeck[i] = h;
                        numOfSuit++;
                    if (i==38)
                    {
                            suit++;
                            numOfSuit=1;
                    }
                    break;
                }
                case 3:
                    {
                        h = new Hoyle(numOfSuit, 'C');
                        FullDeck[i] = h;
                        numOfSuit++;
                    break;
                }
            }
        }
        Random C = new Random();
        Hoyle A = FullDeck[C.Next(52)], B = FullDeck[C.Next(52)];
        if (A.CompareValue(B.cardValue) == 1)
            Console.WriteLine($"{A} is greater than {B}");

        else if (A.CompareValue(B.cardValue) == -1)
            Console.WriteLine($"{A} is less than {B}");
        else
            Console.WriteLine($"{A} is equal to {B}");

    }
}
