using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hello_world
{
    internal class Bike
    {
        private int speed;


        /* THIS IS THE SAME AS BELOW
        String model;
        public String Model
        { 
            get { return model; }
            set { model = value; }
        }
        */

        public String Model { get; set; }

        public Bike (String model, int speed)
        {
            Speed = speed;
            this.Model = model;
        }
        public int Speed 
        { 
            get { return speed; }
            set
            {
                if (value > 500)
                {
                    speed = 500;
                }
                else 
                { 
                speed = value;
                }
            }
        
        }  
        


    }
}
