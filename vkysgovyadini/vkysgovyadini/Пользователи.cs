//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace vkysgovyadini
{
    using System;
    using System.Collections.Generic;
    
    public partial class Пользователи
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Пользователи()
        {
            this.Активности = new HashSet<Активности>();
        }
    
        public int idПользователя { get; set; }
        public Nullable<int> idРоль { get; set; }
        public Nullable<int> КодСтраны { get; set; }
        public Nullable<int> КодНаправления { get; set; }
        public string Телефон { get; set; }
        public string Пароль { get; set; }
        public byte[] Фото { get; set; }
        public string ФИО { get; set; }
        public string mail { get; set; }
        public string Пол { get; set; }
    
        public virtual Направление Направление { get; set; }
        public virtual Роли Роли { get; set; }
        public virtual Страны Страны { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Активности> Активности { get; set; }
    }
}
