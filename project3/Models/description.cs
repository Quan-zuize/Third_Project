//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace project3.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class description
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public description()
        {
            this.vacancies = new HashSet<vacancy>();
        }
        [Key, Column(Order = 1)]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        [Display(Name = "Description ID")]
        public int id { get; set; }
        [Required]
        [Display(Name = "About")]
        [MaxLength(2000)]
        public string about { get; set; }
        [Required]
        [Display(Name = "Requirements")]
        [MaxLength(2000)]
        public string required { get; set; }
        [Required]
        [Display(Name = "Benefits")]
        [MaxLength(2000)]
        public string interests { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<vacancy> vacancies { get; set; }
    }
}
