using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Businiss.Model
{
    public class Entity
    {
        public Entity()
        {
            Id = new Guid();
        }
        public Guid Id { get; set; }
    }
}
