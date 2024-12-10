using BlogifyAPI.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogifyAPI.Domain.Entities.Common
{
    public class BaseEntity : IBaseEntity
    {
        public Guid Id { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public DateTime? ModifiedDate { get; set; }
        public DateTime? DeletedDate { get; set; }
        public EntityStatus Status { get; set; } = EntityStatus.Active; // Aktif, Pasif, Silinmiş..
        public bool IsDeleted { get; set; } = false;
    }
}
