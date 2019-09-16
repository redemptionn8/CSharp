using System;
using System.Collections.Generic;
using System.Text;

public class Hoyle
{
    public char suit { get; set; }
    public string cardValue { get; set; }
    public Hoyle() { suit=' '; cardValue=""; }
    public Hoyle(int x, char y)
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

    public void getSuit(char x)
    {
        suit = x;
    }

    public override string ToString()
    {
        string formatCardValue = this.cardValue.ToString();
        return $"{formatCardValue.PadLeft(2,' ')} {this.suit}";
    }

    public int CompareValue(string x)
    {
        int intCardValue, intX;
            switch (this.cardValue)
            {
                case "A":
                    {
                        intCardValue = 14;
                    break;
                    }
                case "J":
                    {
                        intCardValue = 11;
                    break;
                }
                case "Q":
                    {
                        intCardValue = 12;
                    break;
                }
                case "K":
                    {
                        intCardValue = 13;
                    break;
                }
                default:
                    {
                        intCardValue = Convert.ToInt32(this.cardValue);
                    break;
                    }
            }
        switch (x)
        {
            case "A":
                {
                    intX = 14;
                    break;
                }
            case "J":
                {
                    intX = 11;
                    break;
                }
            case "Q":
                {
                    intX = 12;
                    break;
                }
            case "K":
                {
                    intX = 13;
                    break;
                }
            default:
                {
                    intX = Convert.ToInt32(x);
                    break;
                }
        }
        if (intCardValue > intX)
            return 1;
        if (intCardValue < intX)
            return -1;
        else
            return 0;
    }
}

