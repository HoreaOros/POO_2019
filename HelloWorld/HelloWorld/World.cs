using System;
namespace HelloWorld
{
    internal class World
    {
        string name;
        public void SayHello()
        {
            Console.WriteLine("Hello from {0}", name);
        }
        /// <summary>
        /// Metoda constructor - initializeaza instantele clasei
        /// </summary>
        /// <param name="name">World name</param>
        public World(string name1)
        {
            name = name1;
        }
        /// <summary>
        /// Metoda constructor - implicit
        /// </summary>
        public World()
        {
            this.name = "<none/>";
        }
    }
}