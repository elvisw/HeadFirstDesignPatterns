using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DinerMerger.WithIEnumerable
{
    public class Program
    {
        public static void Main(string[] args)
        {
            PancakeHouseMenu pancakeHouseMenu = new PancakeHouseMenu();
            DinerMenu dinerMenu = new DinerMenu();

            Waitress waitress = new Waitress(pancakeHouseMenu.GetMenuItems(), dinerMenu.GetMenuItems());

            // Without iterators
            //printMenu();

            // With iterators
            waitress.PrintMenu();
        }
    }
}
