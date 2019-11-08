using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAPI.Models
{
    public partial class BookingField
    {
        public long idProduct { get; set; }
        public long idField { get; set; }
        public bool? isRequired { get; set; }
        public bool? isMandatory { get; set; }

        [ForeignKey("idField")]
        [InverseProperty("BookingField")]
        public virtual Field idFieldNavigation { get; set; }
        [ForeignKey("idProduct")]
        [InverseProperty("BookingField")]
        public virtual Product idProductNavigation { get; set; }
    }
}