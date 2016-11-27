using DesignPatternExample.Prototype;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication
{
    class PrototypeTester
    {
        public void Run()
        {
            Resume resume = new Resume();
            resume.Name = "求职者";
            resume.Sex = "男";
            resume.Age = 25;
            resume.Work = new WorkExperience { Company = "深圳XX公司", WorkDate = "2010-2016" };

            Resume rs2 = (Resume)resume.Clone();
            Resume rs3 = (Resume)rs2.Clone();

            rs2.Work.Company = "深圳YY公司";
            resume.Work.Company = "深圳ZZ公司";

            Console.WriteLine($"{resume.Name}，{resume.Sex}，{resume.Age}，曾在{resume.Work.WorkDate}就职于{resume.Work.Company}");
            Console.WriteLine($"{rs2.Name}，{rs2.Sex}，{rs2.Age}，曾在{rs2.Work.WorkDate}就职于{rs2.Work.Company}");
            Console.WriteLine($"{rs3.Name}，{rs3.Sex}，{rs3.Age}，曾在{rs3.Work.WorkDate}就职于{rs3.Work.Company}");
        }
    }
}
