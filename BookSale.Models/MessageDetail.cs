using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookSale.Models
{
    public class MessageDetail
    {
        public int Id { get; set; }
        [Required]
        public int MessageId { get; set; }
        [ForeignKey("MessageId")]
        [ValidateNever]
        public OrderHeader MessageHeader { get; set; }

        [Required]
        public int UserId { get; set; }
       
        public string Title { get; set; }
        public string Description { get; set; }
    }
}
