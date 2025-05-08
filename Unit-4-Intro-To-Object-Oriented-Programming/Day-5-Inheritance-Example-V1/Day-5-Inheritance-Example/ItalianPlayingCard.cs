using Day_5_Inheritance_Example;

namespace Day_5_Inheritance_Example;
// This is a subclass of a playing card
public class ItalianPlayingCard : PlayingCard
{
    // Define a default ctor that calls the base class ctor
    public ItalianPlayingCard() : Base( 0, "Joker", "Black") {}
    //Define a 2-arg ctor for value and suit
    public ItalianPlayingCard (int theValue, string theSuit, string theRank) : base(theValue, theSuit, theRank) {}

}