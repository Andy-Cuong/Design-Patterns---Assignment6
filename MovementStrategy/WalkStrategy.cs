using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns___Assignment6.MovementStrategy
{
    public class WalkStrategy : IMovementStrategy
    {
        public string Move()
        {
            // Implementation for birds which can walk
            return "running in the 90's";
        }
    }
}
