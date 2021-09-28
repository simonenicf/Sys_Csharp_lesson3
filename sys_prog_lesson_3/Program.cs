using System;

namespace sys_prog_lesson_3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Creates my objects
            Rectangle vierkant = new Rectangle(50.0f,50.0f,50.0f);
            Rectangle rechthoek = new Rectangle(100.0f, 100.0f, 50.0f, 60.0f);
            Rectangle vierkantBeweeg = new Rectangle(50.0f);
            Rectangle rechthoekBeweeg = new Rectangle(20.0f, 30.0f);

            // debug line to check if it all works
            Console.WriteLine(vierkantBeweeg.Get());
            Console.WriteLine(rechthoekBeweeg.Get());

            // change the objects varibles
            vierkantBeweeg.MoveTo(50.0f, 50.0f);
            rechthoekBeweeg.Set(100.0f, 100.0f, 50.0f, 60.0f);

            // debug line to check if it all works
            Console.WriteLine(vierkant.Get());
            Console.WriteLine(vierkant.IsSquare());
            Console.WriteLine(rechthoek.Get());
            Console.WriteLine(vierkantBeweeg.Get());
            Console.WriteLine(vierkantBeweeg.IsSquare());
            Console.WriteLine(rechthoekBeweeg.Get());
        }
    }

    class Rectangle
    {
        // could all be int but already was busy with float and don't want to change everything for assignment
        // My varible's of this class
        private float x;
        private float y;
        private float witdh;
        private float height;
        public float size;

        // functions
        public bool IsSquare()
        {
            bool square;
            // checks if the witdh is equal to height
            // also works if I only give a size because both of my witdh and height are 0 so equal
            if (witdh == height)
            {
                square = true;
            } else
            {
                square = false;
            }
            return square;
        }

        public (float, float, float, float) Set(float x, float y, float witdh, float height)
        {
            // let the private variable's be equal to my arguments
            this.x = x;
            this.y = y;
            this.witdh = witdh;
            this.height = height;
            return (x, y, witdh, height);
        }

        public (float, float) MoveTo(float x, float y)
        {
            // Set the object on the new x and y cords
            this.x = x;
            this.y = y;
            return (x, y);
        }

        public (float, float, float, float, float) Get()
        {
            // to check if my other functions work correct
            return (x, y, witdh, height, size);
        }
        
        // constructers
        public Rectangle(float size)
        {
            // only gets called if there is 1 argument of type float
            this.size = size;
        }

        public Rectangle(float witdh, float height)
        {
            // only get called if there are two arguments of type float
            this.witdh = witdh;
            this.height = height;
        }

        public Rectangle(float x, float y, float size)
        {
            // only gets called if it has 3 arguments of type float
            this.x = x;
            this.y = y;
            this.size = size;
        }

        public Rectangle(float x, float y, float witdh, float height)
        {
            // only gets called if it has 4 arguments of type float
            this.x = x;
            this.y = y; 
            this.witdh = witdh;
            this.height = height;
        }
    }
}
