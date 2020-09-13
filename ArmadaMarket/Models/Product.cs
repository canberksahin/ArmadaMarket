using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArmadaMarket.Models
{
    [Table("Products")] // İngilizce oldugu için gerek yoktu.
    public class Product
    {
        public int Id { get; set; }

        [Required, MaxLength(30)]
        public string ProductName { get; set; }

        public Category Category { get; set; }

        public int CategoryId { get; set; }

        public decimal UnitPrice { get; set; }

        [NotMapped]
        public string ProductNameWithPrice
        {
            get
            {
                return ProductName + " - "
                + UnitPrice.ToString("C", CultureInfo.GetCultureInfo("tr-tr"));
            }

        }

    }
}
