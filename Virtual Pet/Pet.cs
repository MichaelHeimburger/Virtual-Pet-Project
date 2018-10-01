using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Virtual_Pet
{
    
    class Pet
    {
        //fields
        public int hunger;
        public int thirst;
        public int boredom;
        public string name;
        //properties
        
        public string Name
        {
            get { return this.name; }
            set {
                
                this.name = value; }
        }
        public int Hunger
        {
            get { return this.hunger; }
            set { this.hunger = value; }
        }
        public int Thirst
        {
            get { return this.thirst; }
            set { this.thirst = value; }
        }
        public int Boredom
        {
            get { return this.boredom; }
            set { this.boredom = value; }
        }
        //default constructor
        public Pet()
        {

        }
        //Loaded constrctor
        public Pet(string name)
        {
            this.name = name;
            this.hunger = 20;
            this.thirst = 20;
            this.boredom = 20;
        }
        //Methods
        public void Feed()
        {
            hunger += 35;
            boredom -= 10;
            
        }
        public void Drink()
        {
            this.thirst += 35;
            this.boredom -= 10;
        }
        public void Play()
        {
            this.boredom += 55;
            this.hunger -= 15;
            this.thirst -= 15;
        }
        public void Tick()
        {
            this.boredom -= 5;
            this.hunger -= 5;
            this.thirst -= 5;
        }

        

    }

}
