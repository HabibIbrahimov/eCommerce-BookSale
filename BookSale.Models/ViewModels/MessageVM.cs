using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookSale.Models.ViewModels
{
    public class MessageVM
    {
        public MessageHeader MessageHeader { get; set; }
        public IEnumerable<MessageDetail> MessageDetail { get; set; }
    }
}
