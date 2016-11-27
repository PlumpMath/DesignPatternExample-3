namespace DesignPatternExample.Prototype
{
    public class WorkExperience
    {
        private string workDate;
        public string WorkDate
        {
            get { return this.workDate; }
            set { this.workDate = value; }
        }

        private string company;
        public string Company
        {
            get { return this.company; }
            set { this.company = value; }
        }

        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}
