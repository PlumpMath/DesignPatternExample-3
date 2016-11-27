using System;

namespace DesignPatternExample.AbstractFactory
{
    public class AccessUserService : IUserService
    {
        public User GetUserById(int id)
        {
            Console.WriteLine("在Access中从User表中获取一条用户信息");

            return new User { Id = id, Name = "姓名" };
        }
    }
}
