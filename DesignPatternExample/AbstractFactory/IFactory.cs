namespace DesignPatternExample.AbstractFactory
{
    public interface IFactory
    {
        IUserService CreateUserService();

        IDepartmentService CreateDepartmentService();
    }
}
