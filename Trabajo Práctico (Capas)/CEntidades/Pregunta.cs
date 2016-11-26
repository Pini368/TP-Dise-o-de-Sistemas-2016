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
    
    public partial class Pregunta
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Pregunta()
        {
            this.ItemBloque = new HashSet<ItemBloque>();
            this.ValorRespuesta = new HashSet<ValorRespuesta>();
        }
    
        public int id_pregunta { get; set; }
        public string descripcion { get; set; }
        public string interrogante { get; set; }
        public string nombre { get; set; }
        public int codigo_factor { get; set; }
        public string id_consultor { get; set; }
        public Nullable<System.DateTime> fecha_eliminado { get; set; }
        public int id_opcion_respuesta { get; set; }
    
        public virtual Consultor Consultor { get; set; }
        public virtual Factor Factor { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ItemBloque> ItemBloque { get; set; }
        public virtual OpcionRespuesta OpcionRespuesta { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ValorRespuesta> ValorRespuesta { get; set; }
    }
}
