namespace WebUI.Services
{
    public class ManagerForCustomer
    {
        public void CrudCustomer()
        {
            Mediator mediator = new Mediator();
            bool isA = true;
            while (isA)
            {
                Console.WriteLine("---- Welcome CrudCustomerManager ----");
                Console.WriteLine("1 - Create\n2 - GetAll\n3 - GetById\n4 - Update\n5 - Delete\n6 - Exit");
                byte select = byte.Parse(Console.ReadLine() ?? "");
                switch (select)
                {
                    case 1: mediator.Create(); break;
                    case 2: mediator.ReadAll(); break;
                    case 3: mediator.GetById(); break;
                    case 4: mediator.Update(); break;
                    case 5: mediator.Delete(); break;
                    case 6: isA = false; break;
                    default:
                        {
                            Console.WriteLine("You enter wrong button enter again !!!");
                            Console.ReadKey();
                        }
                        break;
                }
            }

        }

    }
}
