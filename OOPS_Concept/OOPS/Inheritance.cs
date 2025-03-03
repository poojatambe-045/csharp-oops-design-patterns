﻿using OOPS_Concept.OOPS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS_Concept.OOPS
{
    // Single Inheritance
    class Animal
    {
        public void Eat()
        {
            Console.WriteLine("Animal is eating.");
        }
    }

    class Dog : Animal
    {
        public void Bark()
        {
            Console.WriteLine("Dog is barking.");
        }
    }

    // Multi-level Inheritance
    class Mammal : Animal
    {
        public void Run()
        {
            Console.WriteLine("Mammal is running.");
        }
    }

    class Horse : Mammal
    {
        public void Gallop()
        {
            Console.WriteLine("Horse is galloping.");
        }
    }

    // Hierarchical Inheritance
    class Bird : Animal
    {
        public void Fly()
        {
            Console.WriteLine("Bird is flying.");
        }
    }

    class Eagle : Bird
    {
        public void Hunt()
        {
            Console.WriteLine("Eagle is hunting.");
        }
    }

    class Penguin : Bird
    {
        public void Swim()
        {
            Console.WriteLine("Penguin is swimming.");
        }
    }

    // Multiple Inheritance
    interface I1
    {
        void Method1();
    }

    interface I2
    {
        void Method2();
    }

    class MyClass : I1, I2
    {
        public void Method1()
        {
            Console.WriteLine("Method1 is called.");
        }

        public void Method2()
        {
            Console.WriteLine("Method2 is called.");
        }
    }

    class Inheritance
    {
        // Main Method
        static void Main()
        {
            // single inheritance
            Dog dog = new Dog();
            dog.Eat();

            // multi-level inheritance
            Horse horse = new Horse();
            horse.Eat();
            horse.Run();

            // hierarchical inheritance
            Eagle eagle = new Eagle();
            Penguin penguin = new Penguin();
            eagle.Fly();
            eagle.Hunt();
            penguin.Fly();
            penguin.Swim();

            // multiple inheritance
            MyClass myClass = new MyClass();
            myClass.Method1();
            myClass.Method2();

            Console.ReadLine();
        }
    }
}


//output

//Animal is eating.
//Animal is eating.
//Mammal is running.
//Bird is flying.
//Eagle is hunting.
//Bird is flying.
//Penguin is swimming.
//Method1 is called.
//Method2 is called.

