using System;
using System.Collections.Generic;
using System.Text;

public class Hoyle
{
    protected int numOfCards { get; }
    protected string suit { get; }
    protected string cardValue { get; }
    protected Hoyle(string suit, string cardValue)
    {
        this.suit = suit;
        this.cardValue = cardValue;
    }
}

public static class FullDeck
{
}
