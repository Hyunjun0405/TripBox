using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAPI.Models
{
    public partial class SessionTemplate
    {
        public SessionTemplate()
        {
            Session = new HashSet<Session>();
            SessionTemplateWeek = new HashSet<SessionTemplateWeek>();
        }

        public long id { get; set; }
        public long idProduct { get; set; }
        public short? minuteDuration { get; set; }
        [Column(TypeName = "date")]
        public DateTime? dateStart { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? timeStart { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? timeEnd { get; set; }
        [Column(TypeName = "date")]
        public DateTime? dateUntil { get; set; }
        [StringLength(4)]
        public string datetypeRepeat { get; set; }
        public short? valueRepeat { get; set; }

        [ForeignKey("idProduct")]
        [InverseProperty("SessionTemplate")]
        public virtual Product idProductNavigation { get; set; }
        [InverseProperty("idTemplateNavigation")]
        public virtual ICollection<Session> Session { get; set; }
        [InverseProperty("idTemplateNavigation")]
        public virtual ICollection<SessionTemplateWeek> SessionTemplateWeek { get; set; }
    }
}