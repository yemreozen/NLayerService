using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayer.Core.Models
{
    public abstract class BaseEntity
    {
        public int Id { get; set; }
        public string? CreationDate { get; set; }
        public string? UpdateDate { get; set; }
    }
}
