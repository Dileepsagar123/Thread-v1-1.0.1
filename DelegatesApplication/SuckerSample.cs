﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesApplication
{
    class SuckerSample
    {
        public delegate void EventHandler();

        
            public static event EventHandler _show;

            static void Main()
            {
                // Add event handlers to Show event.
                _show += new EventHandler(Dog);
                _show += new EventHandler(Cat);
                _show += new EventHandler(Mouse);
                _show += new EventHandler(Mouse);

                // Invoke the event.
                _show.Invoke();
            }

            static void Cat()
            {
                Console.WriteLine("Cat");
            }

            static void Dog()
            {
                Console.WriteLine("Dog");
            }

            static void Mouse()
            {
                Console.WriteLine("Mouse");
            }
         
    }
}
