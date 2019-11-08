using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAPI.Models
{
    public partial class SessionRole
    {
        public long id { get; set; }
        public long idSession { get; set; }
        public long idParty { get; set; }
        [Required]
        [StringLength(4)]
        public string typeRole { get; set; }

        [ForeignKey("idParty")]
        [InverseProperty("SessionRole")]
        public virtual Party idPartyNavigation { get; set; }
        [ForeignKey("idSession")]
        [InverseProperty("SessionRole")]
        public virtual SessionOrdered idSessionNavigation { get; set; }
    }
}