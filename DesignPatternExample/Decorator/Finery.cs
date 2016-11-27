namespace DesignPatternExample.Decorator
{
    public class Finery : Person
    {
        protected Person component;

        public void Decorate(Person person)
        {
            this.component = person;
        }

        public override void Show()
        {
            if (component != null)
            {
                component.Show();
            }
        }
    }
}
