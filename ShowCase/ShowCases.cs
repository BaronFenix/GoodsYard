using System;
using System.Collections.Generic;
using System.Text;

namespace MiniShop.ShowCase
{
    public partial class ShowCases
    {
        protected event ShowcaseStateHandler OnCreated;
        protected event ShowcaseStateHandler OnChanged;
        protected event ShowcaseStateHandler OnAdded;
        protected event ShowcaseStateHandler OnRemoved;
        private List<ShowCase> showCase = new List<ShowCase>();
        internal void Menu()
        {
            do
            {
                Console.Clear();
                Console.WriteLine("1 -> create showcase");
                Console.WriteLine("2 -> output showcase");
                Console.WriteLine("3 -> remove showcase");
                Console.WriteLine("4 -> make changes in the showcase");
                Console.WriteLine("0 -> break the program\n");
                Console.WriteLine("Your input ->");
                Actions actions = new Actions();
                if (int.TryParse(Console.ReadLine(), out int choose))
                {
                    if (Enum.IsDefined(typeof(Actions), choose))
                    {
                        actions = (Actions)choose;
                    }
                }
                switch (actions)
                {
                    case Actions.Break:
                        {
                            Console.Clear();
                        }
                        break;
                    case Actions.Create:
                        {
                            Console.WriteLine("Enter name of showcase ->");
                            string nameOfShowcase = Console.ReadLine();
                            Console.WriteLine("Enter volume of showcase ->");
                            int.TryParse(Console.ReadLine(), out int volume);
                            if (volume > 0)
                                showCase.Add(new ShowCase(nameOfShowcase, volume));
                        }
                        break;
                    case Actions.Output:
                        {

                        }
                        break;
                    case Actions.Remove:
                        {

                        }
                        break;
                    case Actions.Change:
                        {

                        }
                        break;
                    default:
                        break;
                }
            }
            while (true);
        }
        internal void CreateShowCase()
        {
            string name = Console.ReadLine();
            int volume = Convert.ToInt32(Console.ReadLine());
            if(volume > 0 && name!= null)
            {

            }
        }
        internal void OutputShowCase()
        {

        }
        internal void RemoveShowCase()
        {

        }
        internal void ChangeShowCase()
        {

        }
    }
}
