//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace nails_sack.database
{
    using System;
    using System.Collections.Generic;
    
    public partial class Order
    {
        public int orderID { get; set; }
        public Nullable<int> reservationID { get; set; }
    
        public virtual Reservation Reservation { get; set; }
    }
}
