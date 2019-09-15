using System;
using System.Collections.Generic;
using System.Text;

public class Hoyle
{
    public string suit { get; set; }
    public string cardValue { get; set; }
    public Hoyle() { suit=""; cardValue=""; }
    public Hoyle(int x, string y)
    {
        getValue(x);
        getSuit(y);
    }

    public void getValue(int x)
    {
        string value;
        switch(x)
        {
            case 1:
                {
                    value = "A";
                    break;
                }
            case 11:
                {
                    value = "J";
                    break;
                }
            case 12:
                {
                    value = "Q";
                    break;
                }
            case 13:
                {
                    value = "K";
                    break;
                }
            default:
                {
                    value = x.ToString();
                    break;
                }
        }
        cardValue = value;
    }

    public void getSuit(string x)
    {
        suit = x;
    }

    public override string ToString()
    {
        return $"{this.cardValue} {this.suit}";
    }
}

