using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace MultipleDataBase.FirstDbEntities
{
    [Table("Flow")]
    public class Flow : Entity, IHasCreationTime
    {
        public virtual string DevID { get; set; }

        public virtual string Dhost { get; set; }

        public virtual string Act { get; set; }

        public virtual int? Proto { get; set; }

        public virtual DateTime? Stime { get; set; }

        public virtual string Sip { get; set; }

        public virtual string Dip { get; set; }

        public virtual int? Sport { get; set; }

        public virtual int? DPort { get; set; }

        public virtual int? Up { get; set; }

        public virtual int? Down { get; set; }

        public virtual DateTime CreationTime { get; set; }

        public Flow()
        {
            CreationTime = DateTime.Now;
        }
    }
}


