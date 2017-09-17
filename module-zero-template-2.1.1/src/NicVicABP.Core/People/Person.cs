using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abp.Domain.Entities;

namespace NicVicABP.People
{
    [Table("StsPeople")]
    public class Person : Entity
    {
        public virtual string Name { get; set; }
    }
}
