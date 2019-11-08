using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAPI.Models
{
    public partial class OrderRole
    {
        public long id { get; set; }
        public long idOrder { get; set; }
        public long? idParty { get; set; }
        [Required]
        [StringLength(4)]
        public string typeRole { get; set; }

        [ForeignKey("idOrder")]
        [InverseProperty("OrderRole")]
        public virtual Order idOrderNavigation { get; set; }
        [ForeignKey("idParty")]
        [InverseProperty("OrderRole")]
        public virtual Party idPartyNavigation { get; set; }
    }
}