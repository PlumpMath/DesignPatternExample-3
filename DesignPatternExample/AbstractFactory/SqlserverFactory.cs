using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternExample.AbstractFactory
{
    public class SqlserverFactory : IFactory
    {
        public IUserService CreateUserService()
        {
            return new SqlserverUserService();
        }

        public IDepartmentService CreateDepartmentService()
        {
            return new SqlserverDepartmentService();
        }
    }
}
