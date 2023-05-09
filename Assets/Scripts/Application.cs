namespace ZenjectDemonstration
{
    public class Application
    {
        public Application(IGreeter greeter)
        {
            greeter.Greet();
        }
    }
}