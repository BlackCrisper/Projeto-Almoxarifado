//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AlmoxarifadoMVC.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Produto
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Produto()
        {
            this.ItemsEntrada = new HashSet<ItemsEntrada>();
            this.ItemsSaida = new HashSet<ItemsSaida>();
        }
    
        public int ProID { get; set; }
        public string ProDescricao { get; set; }
        public Nullable<int> ProMinimo { get; set; }
        public Nullable<int> ProMaximo { get; set; }
        public Nullable<int> ProEstoque { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ItemsEntrada> ItemsEntrada { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ItemsSaida> ItemsSaida { get; set; }
    }
}
