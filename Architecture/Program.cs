using WebUI.StartUp;
namespace Architecture
{
    internal class Program
    {
        public static void Main()
        {
            try { StartUp.Start(); }
            catch (Exception ex){Console.WriteLine(ex.Message);}
        }
    }
}