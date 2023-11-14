using Design_Patterns___Assignment6.MovementStrategy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns___Assignment6.Models
{
    public class Eagle : IBird
    {
        public IMovementStrategy MovementStrategy { get; set; } = default!;

        public void Fly()
        {
            // Eagles can fly
            MovementStrategy = new FlyStrategy();
            Console.WriteLine("This eagle is " + MovementStrategy.Move());
        }

        public void Walk()
        {
            // Eagles can walk
            MovementStrategy = new WalkStrategy();
            Console.WriteLine("This eagle is " + MovementStrategy.Move());
        }

        public void Swim()
        {
            // Eagles cannot swim
            Console.WriteLine("Eagles cannot swim!");
            // Or throw an exception
            //throw new InvalidOperationException("Eagles cannot swim!");
        }
    }
}
