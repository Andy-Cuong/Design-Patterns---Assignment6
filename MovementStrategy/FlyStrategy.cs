using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns___Assignment6.MovementStrategy
{
    public class FlyStrategy : IMovementStrategy
    {
        public string Move()
        {
            // Implementation for birds which can fly
            return "flying at 30km/h";
        }
    }
}
