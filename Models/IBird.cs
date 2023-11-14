using Design_Patterns___Assignment6.MovementStrategy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns___Assignment6.Models
{
    public interface IBird
    {
        protected IMovementStrategy MovementStrategy { get; set; }
        public void Fly();
        public void Walk();
        public void Swim();
    }
}
