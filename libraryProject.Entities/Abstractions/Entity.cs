using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace libraryProject.Entities.Abstractions
{
    public class Entity
    {
        public Entity()
        {
            Guid Id = Guid.NewGuid();
        }
    }
}
