//------------------------------------------------------------------------------
// <auto-generated>
//    Este código se generó a partir de una plantilla.
//
//    Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//    Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Hdeleon_Facturacion.Models.SAT
{
    using System;
    using System.Collections.Generic;
    
    public partial class f4_c_formapago
    {
        public int id { get; set; }
        public string c_FormaPago { get; set; }
        public string Descripción { get; set; }
        public string Bancarizado { get; set; }
        public string Número_de_operación { get; set; }
        public string RFC_del_Emisor_de_la_cuenta_ordenante { get; set; }
        public string Cuenta_Ordenante { get; set; }
        public string Patrón_para_cuenta_ordenante { get; set; }
        public string RFC_del_Emisor_Cuenta_de_Beneficiario { get; set; }
        public string Cuenta_de_Benenficiario { get; set; }
        public string Patrón_para_cuenta_Beneficiaria { get; set; }
        public string Tipo_Cadena_Pago { get; set; }
        public string Nombre_del_Banco_emisor_de_la_cuenta_ordenante_en_caso_de_extran { get; set; }
    }
}
