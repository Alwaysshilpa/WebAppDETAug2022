namespace WebAppDETAug2022.Service
{
    public interface IHello
    {
        string SayHello(string name);
    }
    public class Hello1 : IHello
    {
        public string SayHello(string name)
        {
            return $"Hello {name},welcome to ASP.NET core";

        }
    }
    public class Hello2 : IHello
    {
        public string SayHello(string name)
        {
            return $"Hello,How are you {name}";
        }
    }
}
