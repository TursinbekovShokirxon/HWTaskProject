namespace WebUI.Services
{
    public class GlobalManager
    {
        public static ManagerForCustomer managerForCustomer;
        public GlobalManager()
        {
            managerForCustomer = new();
        }
        public  void AllManager()
        {
            bool isA = true;
            Console.WriteLine("--- Welcome Global manager ---");
            Console.WriteLine("1 - Customer");
            Console.WriteLine("2 - Exit");
            byte select = byte.Parse(Console.ReadLine() ?? "");

            while (isA)
            {
                switch (select)
                {
                    case 1: { managerForCustomer.CrudCustomer(); } break;
                    case 2: { isA = false; Console.WriteLine("Thank for use our application"); } break;
                        case 3: { Console.WriteLine("you enter wrong button !!!"); Console.ReadKey(); } break;
                }
            }
        }
    }
}
