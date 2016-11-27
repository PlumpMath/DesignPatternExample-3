using DesignPatternExample.Decorator;

namespace ConsoleApplication
{
    class DecorateTester
    {
        public void Run()
        {
            Person person = new Person("骚货在");

            TShirts tshirts = new TShirts();
            BigTrouser trouser = new BigTrouser();
            LeatherShoes shoes = new LeatherShoes();
            Suit suit = new Suit();
            Sneakers sneaker = new Sneakers();
            Tie tie = new Tie();

            tshirts.Decorate(person);
            trouser.Decorate(tshirts);
            shoes.Decorate(trouser);
            suit.Decorate(shoes);
            sneaker.Decorate(suit);
            tie.Decorate(sneaker);

            tie.Show();
        }
    }
}
