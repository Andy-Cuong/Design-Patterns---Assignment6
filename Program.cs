using Design_Patterns___Assignment6.Models;

IBird eagle = new Eagle();
IBird ostrich = new Ostrich();
IBird duck = new Duck();

//Simulate flying
eagle.Fly();
ostrich.Fly();
duck.Fly();

//Simulate walking
eagle.Walk();
ostrich.Walk();
duck.Walk();

//Simulate swimming
eagle.Swim();
ostrich.Swim();
duck.Swim();