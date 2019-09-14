using System;
using System.Collections.Generic;
using System.Text;

public class Deck
{
    protected int numOfCards { get; }
    protected Array[] Cards { get; }
    private Deck(int numOfCards, Array[] Cards)
    {
        this.numOfCards = numOfCards;
        this.Cards = Cards;
    }

}
