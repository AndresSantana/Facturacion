//------------------------------------------------------------------------------
// <auto-generated>
//    Este código se generó a partir de una plantilla.
//
//    Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//    Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Hdeleon_Facturacion.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class ctype_invoice
    {
        public ctype_invoice()
        {
            this.invoice = new HashSet<invoice>();
        }
    
        public int id { get; set; }
        public string name { get; set; }
    
        public virtual ICollection<invoice> invoice { get; set; }
    }
}
