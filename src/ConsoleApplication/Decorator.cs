using DesignPatternExample.Decorator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication
{
    class Decorator
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
