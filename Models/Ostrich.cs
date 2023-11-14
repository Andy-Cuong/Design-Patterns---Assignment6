using Design_Patterns___Assignment6.MovementStrategy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns___Assignment6.Models
{
    public class Ostrich : IBird
    {
        public IMovementStrategy MovementStrategy { get; set; } = default!;

        public void Fly()
        {
            // Ostriches cannot fly
            Console.WriteLine("Ostriches cannot fly!");
            // Or throw an exception
            //throw new InvalidOperationException("Ostriches cannot fly!");
        }

        public void Walk()
        {
            // Ostriches can walk
            MovementStrategy = new WalkStrategy();
            Console.WriteLine("This ostrich is " + MovementStrategy.Move());
        }

        public void Swim()
        {
            // Ostriches cannot swim
            Console.WriteLine("Ostriches cannot swim!");
            // Or throw an exception
            //throw new InvalidOperationException("Ostriches cannot swim");
        }
    }
}
