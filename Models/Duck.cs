using Design_Patterns___Assignment6.MovementStrategy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns___Assignment6.Models
{
    public class Duck : IBird
    {
        public IMovementStrategy MovementStrategy { get; set; } = default!;

        public void Fly()
        {
            // Ducks can fly
            MovementStrategy = new FlyStrategy();
            Console.WriteLine("This duck is " + MovementStrategy.Move());
        }

        public void Walk()
        {
            // Ducks can walk
            MovementStrategy = new WalkStrategy();
            Console.WriteLine("This duck is " + MovementStrategy.Move());
        }

        public void Swim()
        {
            // Ducks can swim
            MovementStrategy = new SwimStrategy();
            Console.WriteLine("This duck is " + MovementStrategy.Move());
        }
    }
}
