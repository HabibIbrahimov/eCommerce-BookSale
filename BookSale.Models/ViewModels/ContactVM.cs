using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookSale.Models.ViewModels
{
    public class ContactVM
    {
        public Contact Contact { get; set; }
        public ApplicationUser User { get; set; }
        public Message Message { get; set; }
    }
}
