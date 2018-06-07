//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ELSO.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("EVNT")]
    public partial class Event : BaseEntity
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Event()
        {
            this.EventMaxCount = new HashSet<EventMaxCount>();
            this.EventWebResources = new HashSet<EventWebResource>();
            this.Registrations = new HashSet<Registration>();
            this.Patterns = new HashSet<Pattern>();
        }

        [Key]
        [Column("EVNT_UID")]
        public int Id { get; set; }
        [Column("CNCLN_DTM", TypeName = "datetime2")]
        public Nullable<System.DateTime> CancellationDate { get; set; }
        [Required]
        [StringLength(150)]
        [Column("EVNT_NM")]
        public string EventName { get; set; }

        [StringLength(4)]
        [Column("EVNT_TYP_CD")]
        public string ETypeCode { get; set; }

        [StringLength(254)]
        [Column("EVNT_DESC")]
        public string EventDescription { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EventMaxCount> EventMaxCount { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EventWebResource> EventWebResources { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Registration> Registrations { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Pattern> Patterns { get; set; }
        public virtual EventType EventType { get; set; }
    }
}