using System;
using System.Linq;
using System.ComponentModel.DataAnnotations;

namespace hohsys.API.models
{
    public abstract class MyEntity
    {
        public int Id { get; set; }
        public bool IsActive { get; set; }
        public DateTimeOffset DateAdded { get; set; }
        public DateTimeOffset DateUpdated { get; set; }
        [Required]
        public string UserAdded { get; set; }
        [Required]
        public string UserUpdated { get; set; }
    }

}