using System;

class TestDeck
{
    static void Main(string[] args)
    {
        int numOfCards=52,numOfSuit=0,suit=0;
        Hoyle[] FullDeck = new Hoyle[52];
        for(int i=0; i<numOfCards; i++)
        {
            switch(suit)
            {
                case 0:
                {
                    FullDeck[i].suit="Hearts";
                    FullDeck[i].cardValue=numOfSuit;
                    numOfSuit++;
                    if (i=12)
                    {
                            suit++;
                            numOfSuit=0;
                    }
                    break;
                }
                case 1:
                {
                    FullDeck[i].suit="Diamonds";
                    FullDeck[i].cardValue=numOfSuit;
                    numOfSuit++;
                    if (i=25)
                    {
                            suit++;
                            numOfSuit=0;
                    }
                    break;
                }
                case 2:
                {
                    FullDeck[i].suit="Spades";
                    FullDeck[i].cardValue=numOfSuit;
                    numOfSuit++;
                    if (i=38)
                    {
                            suit++;
                            numOfSuit=0;
                    }
                    break;
                }
                case 3:
                {
                    FullDeck[i].suit="Clubs";
                    FullDeck[i].cardValue=numOfSuit;
                    numOfSuit++;
                    break;
                }
                default:
            }
        }
        foreach (Hoyle card in FullDeck)
            Console.WriteLine($"{Hoyle.cardValue}{Hoyle.suit}");

    }
}
