//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RialtoLib.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class Location
    {
        public int location_id { get; set; }
        public string location1 { get; set; }
        public int contract_id { get; set; }
        public System.DateTime location_date { get; set; }
    
        public virtual Contract Contract { get; set; }
    }
}
