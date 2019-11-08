using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAPI.Models
{
    public partial class SessionTemplateWeek
    {
        public long idTemplate { get; set; }
        public short weekday { get; set; }
        public TimeSpan? timeStart { get; set; }
        public TimeSpan? timeEnd { get; set; }

        [ForeignKey("idTemplate")]
        [InverseProperty("SessionTemplateWeek")]
        public virtual SessionTemplate idTemplateNavigation { get; set; }
    }
}