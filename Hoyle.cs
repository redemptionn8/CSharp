using System;
using System.Collections.Generic;
using System.Text;

public static class Hoyle : Deck
{
    public static string suit { get; }
    public static string cardValue { get; }
    public static Hoyle(){}
    public static Hoyle(string suit, string cardValue)
    {
        this.suit = suit;
        this.cardValue = cardValue;
    }
}

