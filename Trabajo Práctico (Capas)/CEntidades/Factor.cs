//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CEntidades
{
    using System;
    using System.Collections.Generic;
    
    public partial class Factor
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Factor()
        {
            this.Pregunta = new HashSet<Pregunta>();
        }
    
        public int codigo_factor { get; set; }
        public string nombre { get; set; }
        public string descripcion { get; set; }
        public string estado { get; set; }
        public int nro_orden { get; set; }
        public int codigo_competencia { get; set; }
        public Nullable<System.DateTime> fecha_eliminado { get; set; }
        public string id_consultor { get; set; }
    
        public virtual Competencia Competencia { get; set; }
        public virtual Consultor Consultor { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Pregunta> Pregunta { get; set; }
    }
}
