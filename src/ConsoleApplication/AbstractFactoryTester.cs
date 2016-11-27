using DesignPatternExample.AbstractFactory;
using System;

namespace ConsoleApplication
{
    class AbstractFactoryTester
    {
        public void Run()
        {
            Console.WriteLine("***普通抽象工厂***");
            IFactory sqlFactory = new SqlserverFactory();
            var userService = sqlFactory.CreateUserService();
            var user = userService.GetUserById(100);

            IFactory accessFactory = new AccessFactory();
            var departmentService = accessFactory.CreateDepartmentService();
            var department = departmentService.GetDepartmentById(200);

            Console.WriteLine("***反射+抽象工厂***");
            var userSer= DataAccess.CreateUserService();
            userSer.GetUserById(5566);

            var depSer = DataAccess.CreateDepartmentService();
            depSer.GetDepartmentById(8899);
        }
    }
}
