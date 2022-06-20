using BurgerApp.Models.Domain;
using SEDC.BurgerApp.Models.Domain;

namespace BurgerApp
{
    public static class StaticDb
    {
        public static List<Burger> Burgers { get; set; } = new()
        {
            new Burger("Cheeseburger", 190, false, false, true),
            new Burger("Vegeburger", 150, true, false, true),
        };
        public static List<Order> Orders { get; set; } = new()
        {
        new Order("Mario Stojkovski", "ul.Gernika 77 br.7", false, new List<Burger>() {Burgers[0], Burgers[1] }, "Drachevo"),
        };
    }

}
