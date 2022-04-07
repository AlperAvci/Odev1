using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Odev1.Models
{
    [MetadataType(typeof(customerMetaData))]
    public partial class customer
    {
        public class customerMetaData
        { 

        [DisplayName("CustomerName")]
        public string custName { get; set; }

            [DisplayName("Adres")]
            public string adres { get; set; }

            [DisplayName("Mobile")]
            public Nullable<int> mobile { get; set; }
        }
    }
}