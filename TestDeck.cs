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
                    h = new Hoyle(numOfSuit,"Hearts");
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
                        h = new Hoyle(numOfSuit, "Diamonds");
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
                        h = new Hoyle(numOfSuit, "Spades");
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
                        h = new Hoyle(numOfSuit, "Clubs");
                        FullDeck[i] = h;
                        numOfSuit++;
                    break;
                }
            }
        }
        foreach (Hoyle Card in FullDeck)
            Console.WriteLine($"{Card}");

    }
}
