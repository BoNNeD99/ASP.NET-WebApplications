
using SEDC.PizzaApp.Web.Models.Enums;

namespace SEDC.PizzaApp.Web.Models.ViewModels
{
    public class OrderDetailsViewModel
    {
        public string PizzaName { get; set; }
        public string UserName { get; set; }
        public PaymentMethod PaymentMethod { get; set; }
        public double Price { get; set; }
        public bool IsDelivered { get; set; }
    }
}
