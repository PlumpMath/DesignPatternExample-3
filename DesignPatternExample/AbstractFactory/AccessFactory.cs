using System;

namespace DesignPatternExample.AbstractFactory
{
    public class AccessFactory : IFactory
    {
        public IDepartmentService CreateDepartmentService()
        {
            return new AccessDepartmentService();
        }

        public IUserService CreateUserService()
        {
            return new AccessUserService();
        }
    }
}
