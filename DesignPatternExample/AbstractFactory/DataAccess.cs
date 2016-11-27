using System.Reflection;

namespace DesignPatternExample.AbstractFactory
{
    public class DataAccess
    {
        const string ASSEMBLYNAME = "DesignPatternExample";
        static string DbType = "Sqlserver";

        private static string getClassNameStart()
        {
            string start = "";
            switch (DbType.ToLower())
            {
                case "sqlserver":
                    start = "Sqlserver";
                    break;
                case "access":
                    start = "Access";
                    break;
            }
            return start;
        }

        public static IUserService CreateUserService()
        {
            string className = $"{ASSEMBLYNAME}.AbstractFactory.{getClassNameStart()}UserService";

            return (IUserService)Assembly.Load(ASSEMBLYNAME).CreateInstance(className);
        }

        public static IDepartmentService CreateDepartmentService()
        {
            string className = $"{ASSEMBLYNAME}.AbstractFactory.{getClassNameStart()}DepartmentService";

            return (IDepartmentService)Assembly.Load(ASSEMBLYNAME).CreateInstance(className);
        }
    }
}
