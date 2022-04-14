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
    public class MessageHeader
    {
        public int Id { get; set; }
        public int ApplicationUserId { get; set; }
       
        public ApplicationUser ApplicationUser { get; set; }

       
    }
}
