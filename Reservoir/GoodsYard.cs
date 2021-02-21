using System;
using System.Collections.Generic;
using System.Text;

namespace MiniShop.Reservoir
{
    public partial class GoodsYard
    {
        public enum Action
        {
            Break,
            Add,
            Remove,
            Change,
            Output,
        }
        private List<Merchandise> merchandises = new List<Merchandise>();
        public void Service()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("1 -> add merchandise");
                Console.WriteLine("2 -> output merchandise");
                Console.WriteLine("3 -> remove merchandise");
                Console.WriteLine("4 -> make changes in the merchandise");
                Console.WriteLine("0 -> I'm tired, maybe i come later \n");
                Console.WriteLine("Your input ->");
                Action action = new Action();
                if (int.TryParse(Console.ReadLine(), out int choose))
                {
                    if (Enum.IsDefined(typeof(Action), choose))
                    {
                        action = (Action)choose;
                    }
                }
                switch (action)
                {
                    case Action.Break:
                        {
                            Console.Clear();
                        }
                        break;
                    case Action.Add:
                        {
                            AddMerchandise();
                        }
                        break;
                    case Action.Output:
                        {
                            OutputMerchandise();
                        }
                        break;
                    case Action.Remove:
                        {
                            RemoveMerchandise();
                        }
                        break;
                    case Action.Change:
                        {
                            ChangeMerchandise();
                        }
                        break;
                    default:
                        break;
                }
            }
        }
        private void AddMerchandise()
        {
            Console.WriteLine("Name of merchandise:");
            string name = Console.ReadLine();
            Console.WriteLine("Cost of merchandise:");
            int.TryParse(Console.ReadLine(), out int cost);
            Console.WriteLine("Volume of merchandise:");
            int.TryParse(Console.ReadLine(), out int volume);
            if (name == "" || cost <= 0 || volume <= 0)
            {
                Console.WriteLine("You have problem on your input!");
                Console.Write("Press enter to continue");
                Console.ReadKey();
                return;
            }
            merchandises.Add(new Merchandise
                (name, 
                (uint)cost, 
                (uint)volume));
        }
        private void RemoveMerchandise()
        {
            Console.WriteLine("1. Remove by ID");
            Console.WriteLine("2. Remove by Name");
            string choose = "";

            if(choose == "1")
            {
                string input = Console.ReadLine();
                var remove = merchandises.Find(x => x.IdentificateNumber.Equals(input));
                merchandises.Remove(remove);
            }
            else if(choose == "2")
            {
                string input = Console.ReadLine();
                var remove = merchandises.Find(x => x.NameOfItem.Equals(input));
                merchandises.Remove(remove);
            }
            else
            {
                Console.WriteLine("Uncorrect chose!");
            }
            Console.Write("Enter to continue");
            Console.ReadKey();
        }
        private void ChangeMerchandise()
        {
            Console.WriteLine("1. Change Name by ID");
            Console.WriteLine("2. Change Cost by ID");
            Console.WriteLine("3. Change Volume by ID");
            string choose = "";
            switch(choose)
            {
                case "1":
                    {
                        string name = Console.ReadLine();
                        
                        break;
                    }
                case "2":
                    {
                        string cost = Console.ReadLine();

                        break;
                    }
                case "3":
                    {
                        int.TryParse(Console.ReadLine(),out int volume);

                        break;
                    }
            }
        }
        public void OutputMerchandise()
        {
            uint counter = 1;
            foreach (var item in merchandises)
            {
                Console.WriteLine($"{counter++} merchandise:");
                Console.WriteLine($"Name of merchandise: {item.NameOfItem}");
                Console.WriteLine($"Cost of merchandise: {item.Cost}");
                Console.WriteLine($"Volume of merchandise: {item.Volume}");
                Console.WriteLine($"ID of merchandise: {item.IdentificateNumber}");
                Console.WriteLine("---");
            }
        }
    }
}