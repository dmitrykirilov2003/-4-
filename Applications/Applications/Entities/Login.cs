//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Applications.Entities
{
    using System;
    using System.Collections.Generic;
    
    public partial class Login
    {
        public int Id { get; set; }
        public string Login1 { get; set; }
        public string Password { get; set; }
        public Nullable<int> UserId { get; set; }
        public Nullable<int> Role { get; set; }
    
        public virtual Role Role1 { get; set; }
        public virtual User User { get; set; }
    }
}