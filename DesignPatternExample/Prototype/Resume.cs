namespace DesignPatternExample.Prototype
{
    public class Resume
    {
        private string name;
        private string sex;
        private int age;
        private WorkExperience work;

        public Resume() { }

        private Resume(WorkExperience work)
        {
            this.work = (WorkExperience)work.Clone();
        }

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        public string Sex
        {
            get { return this.sex; }
            set { this.sex = value; }
        }

        public int Age
        {
            get { return this.age; }
            set { this.age = value; }
        }

        public WorkExperience Work
        {
            get { return this.work; }
            set { this.work = value; }
        }

        public object Clone()
        {
            Resume obj = new Resume(this.work);
            obj.Name = name;
            obj.Sex = sex;
            obj.Age = age;
            return obj;
        }
    }
}
