using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAPI.Models
{
    public partial class Party
    {
        public Party()
        {
            OrderRole = new HashSet<OrderRole>();
            SessionRole = new HashSet<SessionRole>();
        }

        public long id { get; set; }
        [StringLength(4)]
        public string typeParty { get; set; }
        [StringLength(100)]
        public string alias { get; set; }
        [StringLength(100)]
        public string name { get; set; }
        [StringLength(100)]
        public string nameFirst { get; set; }
        [StringLength(100)]
        public string nameLast { get; set; }
        [StringLength(4)]
        public string gender { get; set; }
        [StringLength(4)]
        public string title { get; set; }
        [Column(TypeName = "date")]
        public DateTime? dateBirth { get; set; }

        [InverseProperty("idPartyNavigation")]
        public virtual ICollection<OrderRole> OrderRole { get; set; }
        [InverseProperty("idPartyNavigation")]
        public virtual ICollection<SessionRole> SessionRole { get; set; }
    }
}