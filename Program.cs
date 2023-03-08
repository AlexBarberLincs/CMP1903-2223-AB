class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("How many times would you like to shuffle?");

        Deck myDeck = new Deck();
        foreach (Card c in myDeck.Cards)
        {
            Console.WriteLine(c);
        }
    }
}

class Card
{
    protected Suits suit;
    protected string cardValue;

    public Card(Suits suit2, string cardValue2)
    {
        suit = suit2;
        cardValue = cardValue2;
    }
    public override string ToString()
    {
        return string.Format("{0} of {1}", cardValue, suit);
    }
}

enum Suits
{
    Hearts,
    Diamonds,
    Spades,
    Clubs
}

class Deck
{
    Card[] cards = new Card[52];
    string[] numbers = new string[] { "2", "3", "4", "5", "6", "7", "8", "9", "J", "Q", "K" };
    public Deck()
    {
        int i = 0;
        foreach (string s in numbers)
        {
            cards[i] = new Card(Suits.Clubs, s);
            i++;

        }
        foreach (string s in numbers)
        {
            cards[i] = new Card(Suits.Spades, s);
            i++;

        }
        foreach (string s in numbers)
        {
            cards[i] = new Card(Suits.Hearts, s);
            i++;

        }
        foreach (string s in numbers)
        {
            cards[i] = new Card(Suits.Diamonds, s);
            i++;

        }
    }

    public Card[] Cards
    {
        get
        {
            return cards;
        }
    }
}
