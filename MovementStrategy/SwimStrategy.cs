using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns___Assignment6.MovementStrategy
{
    public class SwimStrategy : IMovementStrategy
    {
        public string Move()
        {
            return "floating on the water surface";
        }
    }
}
