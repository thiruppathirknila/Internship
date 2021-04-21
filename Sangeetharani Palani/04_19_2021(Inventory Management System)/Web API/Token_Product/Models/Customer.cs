using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Token_Product.Models
{
    [Table("tbl_Customer")]
    public class Customer
    {

        [Key]
        public int Customer_Id { get; set; }
        public DateTime Ordered_Date { get; set; }
        public string Customer_Name { get; set; }
        public string Address { get; set; }
        public string Email_Id { get; set; }
        public string Mobile_no { get; set; }

    }
}
