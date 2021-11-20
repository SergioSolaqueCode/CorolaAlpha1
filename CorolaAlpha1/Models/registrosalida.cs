//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CorolaAlpha1.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class registrosalida
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public registrosalida()
        {
            this.Reporte = new HashSet<Reporte>();
        }
    
        public int id { get; set; }
        public string nombreespecie { get; set; }
        public string Nombreencargado { get; set; }
        public int cantidadcosecha { get; set; }
        public int cantidadperdida { get; set; }
        public System.DateTime fechatrabajada { get; set; }
        public int id_especies { get; set; }
        public int id_usuario { get; set; }
        public int id_registroentrada { get; set; }
    
        public virtual especies especies { get; set; }
        public virtual registroentrada registroentrada { get; set; }
        public virtual usuario usuario { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Reporte> Reporte { get; set; }
    }
}
